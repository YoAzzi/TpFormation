using Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using TpFormation.Dto;

namespace TpFormation.Services
{
    public class StudentEventArgs : EventArgs
    {
        public Student Student { get; set; }
    }
    public partial class SchoolService : ISchoolService
    {
        public ISchoolRepository _repositoy;
        public SchoolService(ISchoolRepository repository)
        {
            _repositoy = repository;
        }
        //SchoolRepositoy _repositoy;
        public delegate void StudentEventHandler(object sender, StudentEventArgs args);
        public event StudentEventHandler StudentAdded;

        public void AddStudent(Student student)
        {
            _repositoy.Students.Add(student);
            StudentAdded?.Invoke(this, new StudentEventArgs { Student = student });
        }
        public List<Student> GetStudentsByClassCode(string classCode)
        {
            var classRoom = _repositoy.Classes.Where(r => r.Code == classCode).FirstOrDefault();
            if (classRoom == null)
            {
                throw new Exception("class not found");
            }
            else
            {
                return classRoom.Students;
            }
        }

        public List<Student> GetAllStdents()
        {
            var result = from s in _repositoy.Students
                         where s.Id > 1
                         select new { s.FirstName, s.LastName };
            var result2 = _repositoy.Students.Where(r => r.Id > 1).Select(s => new { s.FirstName, s.LastName });
            var result3 = _repositoy.Students.OrderByDescending(r => r.BirthDate).ThenBy(r => r.Id).ToList();
            var result4 = _repositoy.Students.GroupBy(r => r.BirthDate.Value.Year).Select(r => new { Year = r.Key, Count = r.Count() });
            return _repositoy.Students.ToList();
        }

        public void Dispose()
        {
            Console.WriteLine("Service has been disposed");
        }

        public string CleanString(string str)
        {
            return str.Replace("\r\n", "\n").Replace("*", "");
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }
    }

}
