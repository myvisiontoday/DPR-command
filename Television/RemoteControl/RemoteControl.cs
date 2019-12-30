using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Television
{
    /// <summary>
    /// The RemoteControl class (acts as invoker) is responsible for initiating requests.
    /// </summary>
    public class RemoteControl
    {
        //a field for storing a reference to a command object.
        private ICommand command;
        public void setCommand(ICommand command)
        {
            this.command = command;
        }

        /// <summary>
        /// This triggers that command instead of sending the request directly to the receiver.
        /// </summary>
        public void executeCommand()
        {
            this.command.Execute();
        }
    }
}
