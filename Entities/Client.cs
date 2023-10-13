using System;

namespace Projeto_Aula_132.Entities
{
    internal class Client
    {
        public string PersonName { get; set; }
        public string Email { get; set; }
        public DateTime DateBirth { get; set; }

        public Client()
        {
        }

        public Client(string personName, string email, DateTime dateBirth)
        {
            PersonName = personName;
            Email = email;
            DateBirth = dateBirth;
        }
    }
}
