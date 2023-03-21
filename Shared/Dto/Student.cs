using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpFormation.Dto
{
    public class Student
    {
        #region Properties  
        public int Id { get; set; }
        private string lastName;
        public string LastName
        {
            get { return lastName.ToUpper(); }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Last Name should be longer than 0");
                }
                lastName = value;
            }
        }
        public string FirstName { get; set; }
        public DateTime? BirthDate { get; set; }

        #endregion
        #region Ctor
        public Student()
        {
        }

        public Student(int id, string lastName, string firstName, DateTime birthDate)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
        }


        #endregion

        public string GetBirthdayFormated()
        {
            if (this.BirthDate.HasValue)
            {
                return this.BirthDate.Value.ToShortDateString();
            }

            return "Empty";
        }
    }
}
