using DevX.Helper;
using DevX.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DevX.ViewModel
{
    internal class MainWindowViewModel :INotifyPropertyChanged
    {
        AccessingData Ad = new AccessingData();

        private ObservableCollection<Student> students;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Student> Students
        {
            get { return students; }
            set { students = value;
               OnPropertyChanged();
            }

        
        }
        public ICommand Save { get; }

        public ICommand GetData { get; }

        public MainWindowViewModel()
        {
            Save = new RelayCommand(SaveData);
            GetData = new RelayCommand(RetriveData);
        }

        public void SaveData()
        {
            Ad.SavingData();
        }

        public void DeleteData()
        {
            Ad.DeletingData();
        }
        public void UpdateData()
        {
            Ad.UpdatingData();
        }
        public void RetriveData()
        {
            Students = Ad.RetrivingData();
        }

        private void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));

        }
    }
}
