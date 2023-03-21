using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFormation.Dto;

namespace Shared.Abstract
{
    public interface ISchoolService : IDisposable
    {
        List<Student> GetStudentsByClassCode(string classCode);
        List<Student> GetAllStdents();
    }
}
