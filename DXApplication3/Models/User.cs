using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication3.Models
{
    public class User
    {
        public User()
        {
        }

        public User(string name, DateTime dateofBirth)
        {
            Name = name;
            DateofBirth = dateofBirth;
        }

        public string Name { get; set; }
        public DateTime DateofBirth { get; set; }
    }
}
