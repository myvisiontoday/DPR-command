
namespace Television
{
    // command interface defines the common interface for all concrete commands.
    public interface ICommand
    {
        /// <summary>
        /// // The execution method is declared for all concrete commands to provide their own implementations.
        /// </summary>
        void Execute();
    }
}
