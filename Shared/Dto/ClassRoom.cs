using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpFormation.Abstract;

namespace TpFormation.Dto
{
    public class ClassRoom : IClassRoom
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public List<Student> Students { get; set; }

        public string GetFullName()
        {
            return string.Format("Class room : {0}-{1}", this.Name, this.Code);
        }
    }
}
