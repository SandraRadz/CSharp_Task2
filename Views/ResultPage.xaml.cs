using System;
using System.Windows;
using System.Windows.Controls;
using CSharp_Task2_3.Models;
using CSharp_Task2_3.ViewModels;

namespace CSharp_Task2_3.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ResultPage : Window
    {
        public ResultPage(Person person)
        {
            InitializeComponent();
            DataContext = new ResultViewModel(person);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
    }
}
