namespace AsterNET.Manager.Event
{
    public class DTMFBeginEvent : DTMFEvent
    {
        /// <summary>
        ///     Creates a new DialEvent.
        /// </summary>
        public DTMFBeginEvent(ManagerConnection source)
            : base(source)
        {
        }
    }
}