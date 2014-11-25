using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpChess
{
    class ResponseGenerator
    {
        public enum Situation
        {
            QuitGame_Yes,
            QuitGame_No,
        }

        private static Random randomGenerator = new Random();

        private static String[] responseQuitGame_Yes = {
                                                           "What a coward!",
                                                           "Loser!",
                                                           "I win!",
                                                           "Who's next?"
                                                       };
        private static String[] responseQuitGame_No = {
                                                          "Through so.",
                                                          "That's right.",
                                                          "Make your move then."
                                                      };
        private static String[] responseDefault = {
                                                      "I don't know what to say."
                                                  };


        public static String generateResponse(Situation situation, String[] paramList = null)
        {
            switch (situation)
            {
                case Situation.QuitGame_Yes:
                    return responseQuitGame_Yes[randomNumber(responseQuitGame_Yes.Length)];
                case Situation.QuitGame_No:
                    return responseQuitGame_No[randomNumber(responseQuitGame_No.Length)];
                default:
                    return responseDefault[randomNumber(responseDefault.Length)];
            }
        }

        private static int randomNumber(int max)
        {
            return randomGenerator.Next(max);
        }
    }
}
