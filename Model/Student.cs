using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevX.Model
{
    public class Student
    {
        private string studentId;
        private string studentFatherName;
        private string studentName;
        private string studentEmail;
        private string studentClass;
        private string studentFee;
        private string studentPhone;
        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public string StudentFatherName
        {
            get { return studentFatherName; }
            set { studentFatherName = value; }
        }
        public string StudentEmail
        {
            get { return studentEmail; }
            set { studentEmail = value; }
        }

        public string StudentClass
        {
            get { return studentClass; }
            set { studentClass = value; }
        }

        public string StudentFee
        {
            get { return studentFee; }
            set { studentFee = value; }
        }

        public string StudentPhone
        {
            get { return studentPhone; }
            set { studentPhone = value; }
        }
    }
}
