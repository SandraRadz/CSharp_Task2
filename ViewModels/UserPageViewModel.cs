using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using CSharp_Task2_3.Models;
using CSharp_Task2_3.Properties;
using CSharp_Task2_3.Tools;

namespace CSharp_Task2_3.ViewModels
{
    class UserPageViewModel :  BaseViewModel

    {
        private string _name;
        private string _lastName;
        private string _email;
        private DateTime _birth;
        private bool _isAdult;
        private string _sunSign;
        private string _chineseSign;
        private bool _isBirthday;

        private RelayCommand<object> _goCommand;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged();
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
                OnPropertyChanged();
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
                OnPropertyChanged();
            }
        }
        public string Birth
        {
            get
            {
                return ("birth "+_birth);
            }
            set
            {
                _birth = Convert.ToDateTime(value);
                OnPropertyChanged();
            }
        }

        public string IsAdult
        {
            get
            {
                return ("Is you adult? "+_isAdult);
            }
            set
            {
                _isAdult = Convert.ToBoolean(value);
                OnPropertyChanged();
            }
        }

        public string SunSign
        {
            get
            {
                return _sunSign;
            }
            set
            {
                _sunSign = value;
                OnPropertyChanged();
            }
        }

        public string ChineseSign
        {
            get
            {
                return _chineseSign;
            }
            set
            {
                _chineseSign = value;
                OnPropertyChanged();
            }
        }

        public string IsBirthday
        {
            get
            {
                return ("Is today your birthday?"+ _isBirthday);
            }
            set
            {
                _isBirthday = Convert.ToBoolean(value);
                OnPropertyChanged();
            }
        }

        public RelayCommand<object> GoCommand
        {
            get
            {
                return _goCommand ?? (_goCommand = new RelayCommand<object>(
                            obj =>
                           {
                               Person person = new Person(_name, _lastName, _email, _birth);
                               _isAdult = person.IsAdult;
                               _sunSign = person.SunSign;
                               _chineseSign = person.ChineseSign;
                               _isBirthday = person.IsBirthday;

                           }, o => CanExecuteCommand()));
            }
        }


        public bool CanExecuteCommand()
        {
            //TO DO check if data is null
            return !string.IsNullOrWhiteSpace(_name) && !string.IsNullOrWhiteSpace(_lastName) && !string.IsNullOrWhiteSpace(_email) ;
        }

    }
}
