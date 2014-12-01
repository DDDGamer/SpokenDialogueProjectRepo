using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpChess
{
    class LastUnfinishedCommand
    {
        public ConfirmationType confirmationType { get; set; }
        public LastCommandType lastCommandType { get; set; }
        public Movement movement { get; set; }
        public String lastCommand { get; set; }

        public enum ConfirmationType
        {
            YesNo,
            Position,
            Null
        }

        public enum LastCommandType
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
            lastCommandType = LastCommandType.Null;
            lastCommand = null;
        }

        public LastUnfinishedCommand(ConfirmationType confirmationType, LastCommandType lastCommandType, Movement movement)
        {
            this.confirmationType = confirmationType;
            this.lastCommandType = lastCommandType;
            this.movement = movement;
        }
    }
}
