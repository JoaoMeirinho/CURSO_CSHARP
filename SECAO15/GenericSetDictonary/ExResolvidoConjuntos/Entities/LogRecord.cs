using System;


namespace ExResolvidoConjuntos.Entities
{
    class LogRecord
    {
        public string Username { get; set; }
        public DateTime Instant { get; set; }



        public override bool Equals(object? obj)
        {
            if(!(obj is LogRecord))
                return false;
            LogRecord logRecord = (LogRecord)obj;
            return Username.Equals(logRecord.Username);
        }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }
    }
}
