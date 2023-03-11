using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_ClassWork.Models
{
    public class ComputerModel : ItemModel
    {
        public string GPU { get; set; }
        public string CPU { get; set; }
        public string Producer { get; set; }

        public override ItemModel GetItem()
        {
            return this;
        }
    }

}
