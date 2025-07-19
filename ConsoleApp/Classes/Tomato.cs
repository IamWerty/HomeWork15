using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    public class Tomato : Product
    {
        public Tomato(double price, int amount = 1) : base("Tomato", price, amount) { }
    }
}