using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using CSharp_Task2_3.Models;
using CSharp_Task2_3.Tools;

namespace CSharp_Task2_3.ViewModels
{
    class UserPageViewModel : INotifyPropertyChanged

    {
        private string _name;
        private string _lastName;
        private string _email;
        private DateTime _birth;

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

      

        public RelayCommand<object> GoCommand
        {
            get
            {
                return _goCommand ?? (_goCommand = new RelayCommand<object>(
                           CreateUser, o => CanExecuteCommand()));
            }
        }

        private async void CreateUser(object o)
        {

            await Task.Run((() =>
            {
                Person person = new Person(_name, _lastName, _email, _birth);
                MessageBox.Show(
                    $"First name: {person.Name}\n" +
                    $"Last name: {person.LastName}\n" +
                    $"Email: {person.Email}\n" +
                    $"Date of birth: {person.Birth}\n" +
                    $"Is user adult?: {person.GetIsAdult}\n" +
                    $"Sun Sign: {person.GetSunSign}\n" +
                    $"Chinese Sign: {person.GetChineseSign}\n"+
                    $"Is birthday today?: {person.GetIsBirthday}\n" 
                );
            }));
        }

        public bool CanExecuteCommand()
        {
            return !string.IsNullOrWhiteSpace(_name) && !string.IsNullOrWhiteSpace(_lastName) && !string.IsNullOrWhiteSpace(_email) && !(_birth==default(DateTime));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
