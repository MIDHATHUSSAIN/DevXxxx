using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevX.Model
{
    public class Teacher
    {
        private string teacherId;
        private string teacherName;
        private string teacherFatherName;
        private string teacherClass;
        private string teacherSubject;
        private string teacherSalary;
        private string teacherEmail;
        private string teacherExperience;
        private string teacherDateofJoining;
        private string teacherPhone;
        public string TeacherId
        {
            get { return teacherId; }
            set { teacherId = value; }
        }

        public string TeacherName
        {
            get { return teacherName; }
            set { teacherName = value; }
        }

        public string TeacherFatherName
        {
            get { return teacherFatherName; }
            set { teacherFatherName = value; }
        }

        public string TeacherClass
        {
            get { return teacherClass; }
            set { teacherClass = value; }
        }

        public string TeacherSubject
        {
            get { return teacherSubject; }
            set { teacherSubject = value; }

        }

        public string TeacherSalary
        {
            get { return teacherSalary; }
            set { teacherSalary = value; }
        }

        public string TeacherEmail
        {
            get { return teacherEmail; }    
            set { teacherEmail = value; }
        }

        public string TeacherExperience
        {
            get { return teacherExperience; }
            set { teacherExperience = value; }
        }

        public string TeacherDateofJoining
        {
            get { return teacherDateofJoining; }
            set { teacherDateofJoining = value; }
        }

        public string TeacherPhone
        {
            get { return teacherPhone; }
            set { teacherPhone = value; }
        }
    }
}
