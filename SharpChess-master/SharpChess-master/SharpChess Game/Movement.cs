using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpChess.Model;
using SharpChess.Model.AI;

namespace SharpChess
{
    class Movement
    {
        public Movement()
        {
            ChessPiece = Piece.PieceNames.King;
            fileFrom = -1;
            fileTo = -1;
            rankFrom = -1;
            rankTo = -1;
        }
        public Piece.PieceNames ChessPiece { get; set; }
        public int fileFrom { get; set; }
        public int rankFrom { get; set; }
        public int fileTo { get; set; }
        public int rankTo { get; set; }
    }
}
