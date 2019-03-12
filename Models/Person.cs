using System;

namespace CSharp_Task2_3.Models
{
    class Person
    {
        private string _name;
        private string _lastName;
        private string _email;
        private DateTime _birth;
        private readonly bool _isAdult;
        private readonly string _sunSign;
        private readonly string _chineseSign;
        private readonly bool _isBirthday;

        public Person(string name, string lastName, string email, DateTime birth)
        {
            _name = name;
            _lastName = lastName;
            _email = email;
            _birth = birth;
            _isAdult = CalcIsAdult();
            _sunSign = CalcSunSign();
            _chineseSign = CalcChineseSign();
            _isBirthday = CalcIsBirthday();
        }

        public Person(string name, string lastName,  DateTime birth): this(name, lastName, "none", birth)
        {
        }

        public Person(string name, string lastName, string email) : this(name, lastName, email, DateTime.MinValue)
        {
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public DateTime Birth
        {
            get
            {
                return _birth;
            }
            set
            {
                _birth = value;
            }
        }

        public bool IsAdult
        {
            get
            {
                return _isAdult;
            }
        }

        public string SunSign
        {
            get
            {
                return _sunSign;
            }
        }

        public string ChineseSign
        {
            get
            {
                return _chineseSign;
            }
        }

        public bool IsBirthday
        {
            get
            {
                return _isBirthday;
            }
        }

        public bool CalcIsAdult()
        {
            return CalcAge() >= 18 ? true : false;
        }

        public int CalcAge()
        {
            if (DateTime.Today.Month < _birth.Month ||
                (DateTime.Today.Month == _birth.Month && DateTime.Today.Day < _birth.Day))
            {
                return DateTime.Today.Year - _birth.Year-1;
            }
        return DateTime.Today.Year - _birth.Year;
        }

        public string CalcSunSign()
        {
            //TO DO 
            return "leo";
        }

        public string CalcChineseSign()
        {
            //TO DO 
            return "horse";
        }

        public bool CalcIsBirthday()
        {
            if (DateTime.Today.Month == _birth.Month && DateTime.Today.Day == _birth.Day)
                return true;
            return false;
        }
    }
}
