using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Speech.Recognition;

namespace ChessGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            Recognizer recognizer = new Recognizer();
            recognizer.Recognize(RecognizeMode.Multiple);
        }
    }
}
