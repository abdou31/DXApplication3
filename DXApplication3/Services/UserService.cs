using DXApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication3.Services
{
    public class UserService : IUserService
    {
        public int CalculateAge(User user)
        {
            DateTime birthDate = user.DateofBirth;
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            // Check if the birthday for this year has not occurred yet
            if (birthDate > today.AddYears(-age))
            {
                age--;
            }

           return age;
        }
    }

    public interface IUserService
    {
        int CalculateAge(User user);
    }
}
