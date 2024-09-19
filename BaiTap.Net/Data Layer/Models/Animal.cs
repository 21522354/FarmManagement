using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagement.Data_Layer.Models
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }     
        public abstract int Milk();
        public abstract string Sound();
        public abstract int GiveBirth();
    }
}
