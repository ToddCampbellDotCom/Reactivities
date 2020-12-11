using System;

namespace Domain
{
    public class Value
    {
        // Code first.  Create classes then db

        public int Id { get; set; }     // Id automatically PK with Entity

        public string Name { get; set; }
    }
}
