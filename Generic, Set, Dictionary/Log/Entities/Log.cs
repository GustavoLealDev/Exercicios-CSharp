using System;

namespace Course.Entities
{
    class Log
    {

        public string Name { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Log))
            {
                return false;
            }
            Log other = obj as Log;
            return Name.Equals(other.Name);
        }
    }
}