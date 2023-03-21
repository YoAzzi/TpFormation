using Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFormation.Dto;

namespace TpFormation.Repository
{
    public class SchoolRepositoy : ISchoolRepository
    {

        public List<Student> Students { get; set; }
        public List<ClassRoom> Classes { get; set; }

        public SchoolRepositoy()
        {
            Students = new List<Student>()
        {
            new Student(1,"Last Name 1"," Firt Name 1",new DateTime(1995,01,01)),
            new Student(2,"Last Name 2"," Firt Name 2",new DateTime(1996,01,01)),
            new Student(3,"Last Name 3"," Firt Name 3",new DateTime(1996,01,01)),
            new Student(4,"Last Name 4"," Firt Name 4",new DateTime(1998,01,01)),
        };
            Classes = new List<ClassRoom>()
        {
            new ClassRoom()
            {
                Code="CLS 1",
                Name="Class Room 1",
                Students= new List<Student>()
                {
                     new Student(1,"Last Name 1"," Firt Name 1",new DateTime(1995,01,01)),
                     new Student(2,"Last Name 2"," Firt Name 2",new DateTime(1995,01,01)),
                }
            },
            new ClassRoom()
            {
                Code="CLS 2",
                Name="Class Room 2",
                Students= new List<Student>()
                {
                     new Student(3,"Last Name 3"," Firt Name 3",new DateTime(1995,01,01)),
                    new Student(4,"Last Name 4"," Firt Name 4",new DateTime(1995,01,01)),
                }
            },

        };

        }
    }

}
