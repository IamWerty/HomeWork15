using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    public class Product
    {
        public string BaseName;
        public double BasePrice;
        public int BaseAmount;

        public Product(string name, double price, int amount)
        {
            BaseName = name;
            BasePrice = price;
            BaseAmount = amount;
        }

        public int TotalSum()
        {
            return (int)BasePrice * BaseAmount;
        }

        public virtual string GetInfo()
        {
            return $"{BaseName}: {BaseAmount} x {BasePrice} = {TotalSum()} грн";
        }
        public void DecreaseAmount(int amount)
        {
            BaseAmount -= amount;
            if (BaseAmount < 0) BaseAmount = 0;
        }
    }
    
}