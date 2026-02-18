using DevX.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DevX.ViewModel
{
    class AddNewTeacherViewModel
    {
        public ICommand TeacherSaveButton { get; }

        public AddNewTeacherViewModel()
        {
            TeacherSaveButton = new RelayCommand(SavingTeacher);
        }

        public void SavingTeacher()
        {
            MessageBox.Show("I'm inside SavingTeacher");

        }
    }
}
