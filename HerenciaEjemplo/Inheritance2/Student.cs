using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEjemplo.Inheritance2
{
    class Student : Person
    {
        private float _CGPA;
        private byte _completedCourse;
        private DateTime _joinDate;

        public float CGPA
        {
            get
            {
                return _CGPA;
            }

            set
            {
                _CGPA = value;
            }
        }
        public byte CompletedCourse
        {
            get
            {
                return _completedCourse;
            }

            set
            {
                _completedCourse = value;
            }
        }
        public DateTime JoinDate
        {
            get
            {
                return _joinDate;
            }

            set
            {
                _joinDate = value;
            }
        }

        public Student() : base() /*explicitly calling the base class constructor, but it can also be called without the base() reference. */
        {
            Console.WriteLine("Derived class Student constructor called");
        }

        public void Display() {
            Console.WriteLine("Student: " + base.FirstName + " " + base.LastName);
            Console.WriteLine("Date of birth: " + base.DateOfBirth.ToString());
            Console.WriteLine("CGPA: " + this.CGPA);
            Console.WriteLine("Completed courses: " + this.CompletedCourse.ToString());
        }
    }
}
