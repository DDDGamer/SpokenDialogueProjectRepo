using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpChess
{
    class Movement
    {
        public Movement()
        {
            ChessPiece = null;
            fileFrom = -1;
            fileTo = -1;
            rankFrom = -1;
            rankTo = -1;
        }
        public String ChessPiece { get; set; }
        public int fileFrom { get; set; }
        public int rankFrom { get; set; }
        public int fileTo { get; set; }
        public int rankTo { get; set; }
    }
}
