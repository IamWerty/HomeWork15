using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    public class Cucumber : Product
    {
        public Cucumber(double price, int amount = 1) : base("Cucumber", price, amount) { }
    }
}