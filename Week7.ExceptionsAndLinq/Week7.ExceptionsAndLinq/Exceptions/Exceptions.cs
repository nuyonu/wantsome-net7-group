﻿namespace Week7.ExceptionsAndLinq.Exceptions
{
    public static class Exceptions
    {
        public static void Run()
        {
            Student student = new Student
            {
                Id = 1
            };

            while (true)
            {
                Console.WriteLine("Insert your name");

                string name = Console.ReadLine();

                try
                {
                    student.Name = name;
                }
                catch (NameException nameException)
                {
                    Console.WriteLine(nameException.Message);
                }

                if (!string.IsNullOrEmpty(student.Name))
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Insert your email");

                string email = Console.ReadLine();

                try
                {
                    student.Email = email;
                }
                catch (EmailException emailException)
                {
                    Console.WriteLine(emailException.Message);
                }

                if (!string.IsNullOrEmpty(student.Email))
                {
                    break;
                }
            }

            WithFinallyOnFunctionWithoutReturn();
            WithFinallyOnFunctionWithReturn();
        }

        static int WithoutFinallyOnFunctionWithReturn()
        {
            try
            {
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                return 1;
            }
        }

        static void WithFinallyOnFunctionWithoutReturn()
        {
            try
            {
                Console.WriteLine("Try");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch");
            }

            //Console.WriteLine("Finally");

            // OR

            //finally
            //{
            //    Console.WriteLine("Finally");
            //}
        }

        static int WithFinallyOnFunctionWithReturn()
        {
            try
            {
                Console.WriteLine("Try");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Catch");
                return 1;
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
    }
}
