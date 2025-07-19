using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    public class Carrot : Product
    {
        public Carrot(double price, int amount = 1) : base("Carrot", price, amount) { }
    }
}