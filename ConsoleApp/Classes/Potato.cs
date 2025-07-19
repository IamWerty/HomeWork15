using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    public class Potato : Product
    {
        public Potato(double price, int amount = 1) : base("Potato", price, amount) { }
    }
}