using System;

namespace Domain
{
    public class Command : BaseEntity
    {
        public Guid Id { get; set; } 
        public string HowTo { get; set; }
        public string Line { get; set; }
        public string Platform { get; set; }
      
    }
}