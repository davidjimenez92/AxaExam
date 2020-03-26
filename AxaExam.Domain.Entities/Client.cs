using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AxaExam.Domain.Entities
{
    public abstract class Client
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public abstract string Role { get; }

        public virtual ICollection<Policies> Policies { get; set; }
    }
}
