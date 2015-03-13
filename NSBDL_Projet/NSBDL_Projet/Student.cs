using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSBDL_Projet
{
    /// <summary>
    /// Student object with his properties
    /// </summary>
    class Student
    {
        private string _firstName;


        private string _lastName;
        /// <summary>
        /// The student last name
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        /// <summary>
        /// The first name of the student
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
    }
}
