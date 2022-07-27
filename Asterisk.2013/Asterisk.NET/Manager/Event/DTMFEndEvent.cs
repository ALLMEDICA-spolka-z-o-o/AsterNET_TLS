namespace AsterNET.Manager.Event
{
    public class DTMFEndEvent : DTMFEvent
    {
        /// <summary>
        ///     Creates a new DialEvent.
        /// </summary>
        public DTMFEndEvent(ManagerConnection source)
            : base(source)
        {
        }
    }
}