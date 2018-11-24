using Phonebook.Data.Models;
using System.Collections.Generic;

namespace Phonebook.Data
{
    public class DataAccess
    {
        public static List<Contact> Contacts { get; set; } = new List<Contact>()
        {
            new Contact {Name = "Pesho", Number = "0888548456"}
        };
    }
}
