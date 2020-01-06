
namespace Television
{
    class PowerCommand : ICommand
    {
        private Television television;

        public PowerCommand(Television television)
        {
            this.television = television;
        }

        /// <summary>
        /// it delegates the command to the television(receiver)
        /// </summary>
        public void Execute()
        {
            this.television.powerOnOff();
        }
    }
}
