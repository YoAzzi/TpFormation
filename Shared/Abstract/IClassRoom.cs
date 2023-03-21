using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFormation.Dto;

namespace TpFormation.Abstract
{
    interface IClassRoom
    {
        string Code { get; set; }
        string Description { get; set; }
        List<Student> Students { get; set; }
        string GetFullName();

    }
}
