namespace GraphQL.Data
{
    public class SessionSpeaker
    {
        public int SessionId { get; set; }
        public int SpeakerId { get; set; }
        public Session? Session { get; set; }
        public Speaker? Speaker { get; set; }
    }
}