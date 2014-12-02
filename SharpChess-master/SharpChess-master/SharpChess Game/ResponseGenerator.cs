using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpChess.Model;

namespace SharpChess
{
    class ResponseGenerator
    {

        public enum Situation
        {
            QuitGame_Yes,
            QuitGame_No,
            AskRepeat,
            NoCommand
        }

        private static Random randomGenerator = new Random();

        private static int randomNumber(int max)
        {
            return randomGenerator.Next(max);
        }

        private static String[] responseNoCommand = {
                                                        "I don't recognize that.",
                                                        "I don't know what you mean.",
                                                        "Unrecognized Command."
                                                    };

        private static String[] responseAskRepeat = {
                                                         "Excuse me?",
                                                         "Pardon?",
                                                         "I'm sorry?"
                                                     };

        private static String[] responseQuitGame_Yes = {
                                                           "What a coward!",
                                                           "Loser!",
                                                           "I win!",
                                                           "So who's up next?"
                                                       };
        private static String[] responseQuitGame_No = {
                                                          "Through so.",
                                                          "That's right.",
                                                          "Make your move then.",
                                                          "For a second there I though you'd chickened out!"
                                                      };
        private static String[] responseDefault = {
                                                      "I don't know what to say.",
                                                      "I have no idea what to say next",
                                                      "Hmm, I do not have a good responce",
                                                      "Oh hi, you have reached the default responce."
                                                  };

        private static String[] responsePawn = {
                                                   "Pawn moving!",
                                                   "Sir yes sir!",
                                                   "Yes Sir!",
                                                   "At Once!",
                                                   "Moving now!"
                                               };

        private static String[] responseKnight = {
                                                     "Kight moving!",
                                                     "For the king!"
                                                 };

        private static String[] responseKing = {
                                                    "The King makes his move!",
                                                    "The king moves",
                                                    "The king is on the move",
                                                    "How dare you giving me order!",
                                                     "I shall do as I please"
                                               };

        private static String[] responseQueen = {
                                                    "The Queen makes her move",
                                                    "The queen moves swiftly",
                                                    "Where is my husband?"
                                                };

        private static String[] responseBishop = {
                                                     "Bishop moving!"
                                                 };

        private static String[] responseRook = {
                                                   "Rook on the move!"
                                               };

        public static String generateResponse(Piece.PieceNames PieceName) 
        {
            switch (PieceName) 
            {
                case Piece.PieceNames.Pawn:
                    return responsePawn[randomNumber(responsePawn.Length)];
                case Piece.PieceNames.Knight:
                    return responseKnight[randomNumber(responseKnight.Length)];
                case Piece.PieceNames.Bishop:
                    return responseBishop[randomNumber(responseBishop.Length)];
                case Piece.PieceNames.King:
                    return responseKing[randomNumber(responseKing.Length)];
                case Piece.PieceNames.Queen:
                    return responseQueen[randomNumber(responseQueen.Length)];
                case Piece.PieceNames.Rook:
                    return responseRook[randomNumber(responseRook.Length)];
                default:
                    return "I don't know what to say!";
            }
        }

        public static String generateResponse(Situation situation, String[] paramList = null)
        {
            switch (situation)
            {
                case Situation.QuitGame_Yes:
                    return responseQuitGame_Yes[randomNumber(responseQuitGame_Yes.Length)];
                case Situation.QuitGame_No:
                    return responseQuitGame_No[randomNumber(responseQuitGame_No.Length)];
                case Situation.AskRepeat:
                    return responseAskRepeat[randomNumber(responseAskRepeat.Length)];
                case Situation.NoCommand:
                    return responseNoCommand[randomNumber(responseNoCommand.Length)];
                default:
                    return responseDefault[randomNumber(responseDefault.Length)];
            }
        }

        public static String noMoves()
        {
            String[] responces = {
                                    "There are no possible move for that piece.",
                                    "That piece can not move anywhere.",
                                    "Looks like you cant go anywhere.",
                                    "There is no way out",
                                    "Looks like youre stuck there buddy, try another piece"
                                 };
            return responces[randomNumber(responces.Length)];
        }

        public static String posibleMoves(string name, string position)
        {
            String[] responces = {
                                    "I am highlighting the possible moves for " + name + " at " + position,
                                    "The possible moves for " + name + " at " + position + " are now highlighted"
                                 };
            return responces[randomNumber(responces.Length)];
        }
    }
}
