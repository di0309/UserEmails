using System.Collections.Generic;
using UserEmails.Models;
using System.Data.Entity;

namespace UserEmails.DAL
{
    public class UserEmailsInitializer : CreateDatabaseIfNotExists<UserEmailsContext>
    {
        protected override void Seed(UserEmailsContext context)
        {
            var users = new List<User>
            {
                new User {Name = "Вася"},
                new User {Name = "Петя"},
                new User {Name = "Маша"},
                new User {Name = "Саша"}
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var emails = new List<Email>
            {
                new Email {UserID = 1, Mail = "ewrg@erge.er"},
                new Email {UserID = 1, Mail = "edfqew@erg.ru"},
                new Email {UserID = 2, Mail = "sef@rwq.sd"},
                new Email {UserID = 4, Mail = "lfd@ds.sw"},
                new Email {UserID = 3, Mail = "ergwer@dfq.re"},
                new Email {UserID = 3, Mail = "dwretj@tyjket.hr"},
                new Email {UserID = 4, Mail = "ewrgwe@yjke.wer"},
                new Email {UserID = 2, Mail = "ergeh@etyj.tr"}
            };
            emails.ForEach(s => context.Emails.Add(s));
            context.SaveChanges();
        }
    }
}