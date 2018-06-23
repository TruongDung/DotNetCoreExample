using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetCoreHelloWorldTutorial
{
    class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
    }
}
