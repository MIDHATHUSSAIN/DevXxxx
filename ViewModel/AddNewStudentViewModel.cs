using DevX.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DevX.ViewModel
{
    class AddNewStudentViewModel
    {
        public ICommand StudentSaveButton { get; }

        public AddNewStudentViewModel()
        {
            StudentSaveButton = new RelayCommand(SavingStudent);
        }

        public void SavingStudent()
        {
            MessageBox.Show("I'm in side Saving Student");
        }
    }
}
