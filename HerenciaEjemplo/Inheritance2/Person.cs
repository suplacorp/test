using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEjemplo.Inheritance2
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;
        
            
        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }

            set
            {
                _dateOfBirth = value;
            }
        }

        public Person(){
            Console.WriteLine("Base class(superclass) Person constructor called (Person created)");
        }

        
    }
}
