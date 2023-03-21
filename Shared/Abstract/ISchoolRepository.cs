using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFormation.Dto;

namespace Shared.Abstract
{
    public interface ISchoolRepository
    {
        List<Student> Students { get; set; }
        List<ClassRoom> Classes { get; set; }
    }
}
