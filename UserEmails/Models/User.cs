using System.Collections.Generic;

namespace UserEmails.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Email> Email { get; set; }
    }
}