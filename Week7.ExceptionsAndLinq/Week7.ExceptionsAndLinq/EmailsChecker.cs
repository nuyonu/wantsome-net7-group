using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.ExceptionsAndLinq
{
    public class EmailsChecker
    {
        public void ReadAndCheckEmails()
        {
            List<string> emails = new List<string>();

            Console.WriteLine("Enter emails, separated by a space:");

            string input = Console.ReadLine();

            string[] inputParsed = input.Split(" "); // a b c => ["a", "b", "c"]

            emails.AddRange(inputParsed);

            try
            {
                CheckAllEmails(emails);

                Console.WriteLine("All emails are ok.");
            }
            catch (InvalidEmailException exception) 
            {
                Console.WriteLine(exception.Message);
            }

        }

        private void CheckAllEmails(List<string> emails)
        {
            foreach(string email in emails)
            {
                if (!IsAValidEmail(email))
                {
                    throw new InvalidEmailException($"Email {email} is not valid.");
                }
            }
        }

        private bool IsAValidEmail(string email)
        {
            if (!email.Contains("@"))
            {
                return false;
            }

            return true;
        }

        public class InvalidEmailException : Exception
        {
            public InvalidEmailException(string? message) : base(message)
            { }
        }
    }
}
