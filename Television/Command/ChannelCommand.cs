namespace Television
{
    class ChannelCommand : ICommand
    {
        private Television television;
        private bool channelUp;

        /// <summary>
        /// takes receiver as Television and channelUp as parameter
        /// </summary>
        /// <param name="receiver"></param>
        /// <param name="channelUp"></param>
        public ChannelCommand(Television receiver, bool channelUp)
        {
            this.television = receiver;
            this.channelUp = channelUp;
        }

        /// <summary>
        /// it delegates the command to the television(receiver)
        /// if channelUp is true then it will invoke channelUp method from television if not channelDown
        /// </summary>
        public void Execute()
        {
            if (channelUp)
                television.channelUp();
            else
                television.channelDown();
        }
    }
}
