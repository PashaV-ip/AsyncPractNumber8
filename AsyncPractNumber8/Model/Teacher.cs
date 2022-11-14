using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncPractNumber8.Model
{
    public class Teacher
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _login;
        private string _password;
        public int ID
        {
            get => _id;
            set => _id = value;
        }
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }
        public string Login
        {
            get => _login;
            set => _login = value;
        }
        public string Password
        {
            get => _password;
            set => _password = value;
        }
    }
}
