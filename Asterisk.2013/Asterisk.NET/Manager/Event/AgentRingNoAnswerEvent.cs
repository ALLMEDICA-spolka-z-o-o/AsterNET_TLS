namespace AsterNET.Manager.Event
{
    /// <summary>
    ///     An AgentCompleteEvent is triggered when at the end of a call if the caller was connected to an agent.
    /// </summary>
    public class AgentRingNoAnswerEvent : AbstractAgentEvent
    {
        public AgentRingNoAnswerEvent(ManagerConnection source)
            : base(source)
        {
        }

        /// <summary>
        ///     Get/Set the amount of time the caller was ringing.
        /// </summary>
        public long RingTime { get; set; }
    }
}