namespace UserEmails.Models
{
    public class Email
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string Mail { get; set; }
        public virtual User User { get; set; }
    }
}