using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Television
{
    class VolumeCommand : ICommand
    {
        private Television television;
        private bool volumeUp;

        public VolumeCommand(Television television, bool volumeUp)
        {
            this.television = television;
            this.volumeUp = volumeUp;
        }

        /// <summary>
        /// it delegates the command to the television(receiver)
        /// if volumeUp is true then it will invoke volumelUp method from television if not volumeDown is invoked.
        /// </summary>
        public void Execute()
        {
            if (volumeUp)
                television.volumeUp();
            else
                television.volumeDown();
        }
    }
}
