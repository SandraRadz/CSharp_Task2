using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task2_3.Models
{
    class NameError : Exception
    {
        private string _message;


        public NameError(string message)
        {
            _message = message;
        }


        public override string Message
        {
            get
            {
                return _message;
            }
        }
    }
}
