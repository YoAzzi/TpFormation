using Injection.App_Start;
using Shared.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFormation.Dto;
using TpFormation.Helper;
using Unity;
using Unity.Extension;

namespace TpFormation
{
    internal class Program
    {
        public static UnityContainer RegisterComponents()
        {
            UnityContainer container = new UnityContainer();
            UnityConfig.RegisterComponents(container);
            return container;
        }
        static void Main(string[] args)
        {
            var unity = RegisterComponents();
            ISchoolService service=unity.Resolve<ISchoolService>();

                //service.StudentAdded += Service_StudentAdded;
                //service.AddStudent(new Student() { FirstName = "student 1", LastName = "student 1", BirthDate = DateTime.Now });

                try
                {
                    var allStudents = service.GetAllStdents();
                    //service.TestMethod();
                    foreach (var student in allStudents)
                    {
                        Console.WriteLine(student.FirstName);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to find student {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Move to next method");
                }
                Console.WriteLine("****************");

                try
                {
                    var studentsClass1 = service.GetStudentsByClassCode("CLS 222");
                    foreach (var studentsClass2 in studentsClass1)
                    {
                        Console.WriteLine(studentsClass2.FirstName.CleanString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            
            GC.Collect();
            Console.ReadLine();
        }

        //private static void Service_StudentAdded(object sender, StudentEventArgs args)
        //{
        //    Console.WriteLine($"New student added: Name = {args.Student.FirstName}, BirthDate = {args.Student.BirthDate}");
        //}
    }
}
