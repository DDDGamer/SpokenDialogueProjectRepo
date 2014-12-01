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

        private static String[] responsePawn = {
                                                   "Sir yes sir!"
                                               };

        private static String[] responseKnight = {
                                                     "For the king!"
                                                 };

        private static String[] responseKing = {
                                                     "How dare you giving me order!"
                                               };

        private static String[] responseQueen = {
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
