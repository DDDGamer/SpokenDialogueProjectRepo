using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpChess
{
    class LastUnfinishedCommand
    {
        public ConfirmationType confirmationType { get; set; }
        public LastCommand lastCommand { get; set; }
        public Movement movement { get; set; } 

        public enum ConfirmationType
        {
            YesNo,
            Position,
            Null
        }

        public enum LastCommand
        {
            QuitCommand,
            NewCommand,
            MovePieceToPositionCommand,
            MovePositionToPositionCommand,
            AskPossibleMoveCommand,
            NewGameCommand,
            Null
        }

        public LastUnfinishedCommand()
        {
            movement = null;
            confirmationType = ConfirmationType.Null;
            lastCommand = LastCommand.Null;
        }

        public LastUnfinishedCommand(ConfirmationType confirmationType, LastCommand lastCommand, Movement movement)
        {
            this.confirmationType = confirmationType;
            this.lastCommand = lastCommand;
            this.movement = movement;
        }
    }
}
