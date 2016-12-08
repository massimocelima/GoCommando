namespace GoCommando
{
    /// <summary>
    /// Implement this interface on each command
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Main run method that is invoked by GoCommando
        /// </summary>
        void Run();
        /// <summary>
        /// Terminate the session
        /// </summary>
        bool Terminate { get; }
    }
}