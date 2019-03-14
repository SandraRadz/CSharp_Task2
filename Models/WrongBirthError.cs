using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task2_3.Models
{
    class WrongBirthError: Exception
    {
        private string _message;
        private DateTime? _birth;

        public WrongBirthError(string message, DateTime birth)
        {
            _message = message;
            _birth = birth;
        }

        public WrongBirthError(string message)
        {
            _message = message;
        }

        public WrongBirthError(DateTime birth) : this("The date of birth is incorrect", birth)
        {
        }

        public override string Message
        {
            get
            {
                if (_birth != null)
                {
                    return _message + " " + _birth;
                }
                return _message;
            }
        }
    }
}
