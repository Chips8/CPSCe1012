using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//inside our classes there is no prompting for the user
//we are just getting and setting
//gets will always use a return

namespace Student_Problem2
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int idNumber;

        public Student()
        {

        }
        public Student(string fname, string lname, int id)
        {
            firstName = fname;
            lastName = lname;
            idNumber = id;
        }
        public string GetFirstName()
        {
            return firstName;
        }
        public void SetFirstName(string name)
        {
            firstName = name;
        }
        public string GetLastName()
        {
            return lastName;
        }
        public void SetLastName(string name)
        {
            lastName = name;
        }
        public int GetIdNumber()
        {
            return idNumber;
        }
        public void SetIdNumber(int id)
        {
            idNumber = id;
        }
        public string GetFullName()
        {
            return GetLastName() + ", " + GetFirstName();
        }
        /*
        + GetFirstName(): String  this colon means we are returning what is coming out
        + SetFirstName(FirstName: String): Void
        + GetLastName(): String
        + SetLastName(LastName: String): Void
        + GetIdNumber(): Integer
        + SetIdNumber(IdNumber: Integer): Integer
        + GetFullName(): String
        ctor tab tab for constructor shortcut
        */

    }
}