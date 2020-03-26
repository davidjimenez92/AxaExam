using System;

namespace AxaExam.Domain.Entities
{
    public abstract class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public abstract string Role { get; }
    }
}
