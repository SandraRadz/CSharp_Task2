using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CSharp_Task2_3.Annotations;
using CSharp_Task2_3.Models;

namespace CSharp_Task2_3.ViewModels
{
    class ResultViewModel: INotifyPropertyChanged
    {
        private static Person _person;

        public ResultViewModel(Person person)
        {
            _person = person;
        }

        public string Name => $"Your name:\n{_person.Name}";
        public string Surname => $"Your surname:\n{_person.LastName}";
        public string Email => $"Your email:\n{_person.Email}";
        public string BirthDate => $"Your birthday:\n{_person.Birth.ToShortDateString()}";
        public string SunSign => $"Your sun sign:\n{_person.GetSunSign}";
        public string ChineseSign => $"Your chinese sign:\n{_person.GetChineseSign}";
        public string IsBirthday => $"Today is {(_person.GetIsBirthday ? "" : "not ")}your birthday";
        public string IsAdult => $"You are {(_person.GetIsAdult ? "" : "not ")}adult";


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
