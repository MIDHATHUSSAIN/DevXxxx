using DevX.Helper;
using DevX.View.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DevX.ViewModel
{
    public class TopBarViewModel : INotifyPropertyChanged
    {
        public ICommand MoveToTeacher { get; }
        public ICommand MoveToStudent { get; }
        public ICommand MoveToAnnouncement { get; }
        public ICommand MoveToCourse { get; }
        private object _currentPage;

        public event PropertyChangedEventHandler? PropertyChanged;

        public object CurrentPage
        {
            get => _currentPage;
            set { _currentPage = value; OnPropertyChanged(); }
        }
        public TopBarViewModel()
        {
            MoveToTeacher = new RelayCommand(MovingToTeacher);
            MoveToStudent = new RelayCommand(MovingToStudent);
        }
        public void MovingToTeacher()
        {
            try
            {
                CurrentPage = new AddNewTeacher();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //MessageBox.Show("I am inside teacher");
        }

        public void MovingToStudent()
        {
            CurrentPage = new AddNewStudent();
        }
        private void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
