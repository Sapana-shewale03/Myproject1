using System;
using System.Collections.Generic;
using System.Text;

namespace Advancecsharp.exception_handling
{
    class InvalidPasswordException : ApplicationException
    {
        public  InvalidPasswordException()
            {

            }
        public  InvalidPasswordException(string msg):base(msg)
        {

        }
     }
    class PB_CustomeException
    {
        string username;string  password;

        public string Username { set { this.username = value; } get { return username; } }
        public string Password
        { 
            set {
                if (value.Length <= 5)
                    throw new InvalidPasswordException("password have ataleast 5 value");
                else
                this.password = value; 
            } 
            get { return password; }
        }

        static void Main(string[] args)
        {
            PB_CustomeException pb = new PB_CustomeException();
            pb.Username = "siya";
            try
            {
                pb.Password = "abcd";
            }
            catch(InvalidPasswordException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("main ends");

        }
    }
}
