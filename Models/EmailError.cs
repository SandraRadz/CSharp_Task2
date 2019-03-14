﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Task2_3.Models
{
    class EmailError: Exception
    {
        private string _message;
       

        public EmailError(string message)
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
