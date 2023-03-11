using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_ClassWork.Models
{
    public abstract class ItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Raiting { get; set; }

        public abstract ItemModel GetItem();

    }


}
