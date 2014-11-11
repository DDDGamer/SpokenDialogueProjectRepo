using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Speech.Recognition;
using Microsoft.Speech.Recognition.SrgsGrammar;
using Microsoft.Speech.Synthesis;

namespace ChessGame2
{
    class Recognizer
    {
        private SpeechRecognitionEngine sre;
        private SpeechSynthesizer ss;
        private Grammar g;
        private bool isRecognizing;
        
        public Recognizer()
        {
            InitGrammar();
            InitSpeechRecognitionEngine();
            InitSpeechSynthesizer();
            isRecognizing = false;
        }

        public void Recognize(RecognizeMode mode)
        {
            isRecognizing = true;
            try
            {
                sre.RecognizeAsync(mode);
                Console.WriteLine("Start recognizing...");
                while (isRecognizing)
                {

                }
                Console.WriteLine("Finished recognition.");
            }
            catch (Exception ex)
            {
                isRecognizing = false;
                Console.WriteLine(ex);
                throw new Exception("We have a problem while recognizing.");
            }
            
        }

        private void InitSpeechSynthesizer()
        {
            try
            {
                ss = new SpeechSynthesizer();
                ss.SelectVoiceByHints(VoiceGender.Female);
                ss.SetOutputToDefaultAudioDevice();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception("Failed to initialize SpeechSynthesizer.");
            }
            
        }

        private void InitSpeechRecognitionEngine()
        {
            try
            {
                sre = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
                sre.SetInputToDefaultAudioDevice();
                sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
                sre.LoadGrammar(g);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception("Failed to initialize SpeechRecognitionEngine.");
            }
        }

        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e != null)
            {
                if (e.Result.Confidence >= 0.5)
                {
                    if (e.Result.Semantics.ContainsKey("QuitCommands"))
                    {
                        isRecognizing = false;
                    }
                    else if (IsLegalMove())
                    {
                        String response = "Okay, moving ";
                        if (e.Result.Semantics.ContainsKey("ChessPiece"))
                        {
                            response += e.Result.Semantics["ChessPiece"].Value.ToString();
                        }
                        else
                        {
                            response = response
                                + e.Result.Semantics["HorizontalPositionS"].Value.ToString()
                                + " "
                                + e.Result.Semantics["VerticalPositionS"].Value.ToString();
                        }
                        response += " to "
                            + e.Result.Semantics["HorizontalPositionE"].Value.ToString()
                            + " "
                            + e.Result.Semantics["VerticalPositionE"].Value.ToString();
                        Console.WriteLine(response);
                        ss.Speak(response);
                        Console.WriteLine(e.Result.Semantics.Count);
                    }
                    else
                    {
                        String result = "I'm sorry Dave. I'm afraid I can't do that.";
                        System.Media.SoundPlayer m_SoundPlayer =
                  new System.Media.SoundPlayer(@"..\..\sound\cantdo.wav");
                        m_SoundPlayer.Play();
                        Console.WriteLine(result);
                    }
                }
                else
                {
                    Console.WriteLine("Pardon me?");
                    ss.Speak("Pardon me?");
                }
            }
        }

        private bool IsLegalMove()
        {
            Random randomGenerator = new Random();
            int randomNum = randomGenerator.Next(2);
            if (randomNum == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void InitGrammar()
        {
            try
            {
                // Initialize grammar g with document and name of "ChessCommands
                g = new Grammar(@"..\..\xml\Commands.xml");
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to initialize gramma.");
            }
        }
    }
}
