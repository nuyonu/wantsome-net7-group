using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Advanced
{
    public class Teacher
    {
        public string name;
        public string email;
        public string password;
        private int salary;

        public string Name { get; set; }

        public string Email { get; set; }

        public Teacher()
        { }

        public void SetSalary(int salary)
        {
            if (salary < 0)
            {
                throw new Exception("Salary is invalid.");
            }

            this.salary = salary;

            //
        }

        public void SetPassword(string password)
        {
            SaveToDatabase(EncryptPassword(password));
        }

        private void SaveToDatabase(string encryptedPassword)
        {
            throw new NotImplementedException();
        }

        private string EncryptPassword(string password)
        {
            throw new NotImplementedException();
        }
        // Private methods
    }
}
