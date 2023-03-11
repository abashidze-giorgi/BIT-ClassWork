using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_ClassWork.Models
{
    public class PhoneModel: ItemModel
    {
        public string Display { get; set; }
        public string Battery { get; set; }
        public string Model { get; set; }

        public override ItemModel GetItem()
        {
            return this;
        }
    }

}
