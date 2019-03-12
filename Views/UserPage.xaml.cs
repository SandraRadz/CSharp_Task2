using System.Windows.Controls;
using CSharp_Task2_3.ViewModels;

namespace CSharp_Task2_3.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class UserPage : UserControl
    {
        public UserPage()
        {
            InitializeComponent();
            DataContext = new UserPageViewModel();
        }
    }
}
