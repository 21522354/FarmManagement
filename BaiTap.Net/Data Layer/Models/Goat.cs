using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagement.Data_Layer.Models
{
    public class Goat : Animal
    {
        Random random;
        public Goat()
        {
            random = new Random();  
        }
        public override int GiveBirth()
        {
            return random.Next(0, 6);
        }
        public override int Milk()
        {
            return random.Next(0, 11);
        }
        public override string Sound()
        {
            return "Goat sound";
        }
    }
}
