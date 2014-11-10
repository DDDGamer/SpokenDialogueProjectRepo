using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Speech.Recognition;
using Microsoft.Speech.Synthesis;

namespace ChessSpeechTest1
{
    class Program
    {
        static bool done = false;
        static string XML_PATH = "C:\\Users\\Denis\\Documents\\Github\\SpokenDialogueProjectRepo\\ChessSpeechTest1\\ChessSpeechTest1\\";
        static string XML_FILE = "MovePieceGrammar.xml";

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("I'm listening");

                System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-us");
                SpeechRecognitionEngine sre = new SpeechRecognitionEngine(ci);
                sre.SetInputToDefaultAudioDevice();
                sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
                sre.RecognizeCompleted += new EventHandler<RecognizeCompletedEventArgs>(sre_RecognizeCompleted);

                Grammar playCommandsGrammar = new Grammar(XML_PATH + XML_FILE);
                sre.LoadGrammar(playCommandsGrammar);

                sre.RecognizeAsync(RecognizeMode.Multiple);

                while (done == false) { ; }

                Console.WriteLine("Done");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        } // Main

        static void sre_SpeechRecognized(object sender,
        SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence >= 0.5)
                Console.WriteLine("I heard " + e.Result.Text);
            else
                Console.WriteLine("Unknown word");
            Console.WriteLine("Semantics contains key: " + e.Result.Semantics.ContainsKey("QuitCommands"));
            if (e.Result.Semantics.ContainsKey("QuitCommands"))
            {
                done = true;
                ((SpeechRecognitionEngine)sender).RecognizeAsyncCancel();
                return;
            }
        }

        static void sre_RecognizeCompleted(object sender,
        RecognizeCompletedEventArgs e)
        {
            done = true;
        }
    }
}
