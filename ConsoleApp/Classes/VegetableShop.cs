using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.Classes
{
    sealed class VegetableShop
    {
        private List<Product> products = new List<Product>();

        public void AddProducts(List<Product> newProducts) // для першої ініціалізації
        {
            products.AddRange(newProducts);
        }

        public void AddAmount(string name, int amount)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].BaseName == name)
                {
                    products[i].BaseAmount += amount;
                    Console.WriteLine("Додано " + amount + " до " + name + ". Тепер: " + products[i].BaseAmount + "\n");
                    return;
                }
            }

            Console.WriteLine("Товар \"" + name + "\" не знайдено.\n");
        }

        public void RemoveAmount(string name, int amount)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].BaseName == name)
                {
                    if (products[i].BaseAmount <= amount)
                    {
                        products.RemoveAt(i);
                        Console.WriteLine("Видалено весь товар: " + name + "\n");
                    }
                    else
                    {
                        products[i].BaseAmount -= amount;
                        Console.WriteLine("Зменшено кількість " + name + " на " + amount + ". Залишилось: " + products[i].BaseAmount + "\n");
                    }
                    return;
                }
            }
            Console.WriteLine("Товар \"" + name + "\" не знайдено.\n");
        }

        public void RemoveProductByName(string name)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].BaseName == name)
                {
                    products.RemoveAt(i);
                    i--; // бо після видалення індекси зсуваються
                }
            }

            Console.WriteLine("Видалено товари з назвою: " + name + "\n");
        }

        public void PrintProductsInfo()
        {
            double total = 0;
            Console.WriteLine("Продукти в магазині:");

            foreach (var product in products)
            {
                Console.WriteLine($"≻{product.GetInfo()}");
                total += product.TotalSum();
            }

            Console.WriteLine($"Загальна вартість: {total} грн");
        }
    }
}