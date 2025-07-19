using System.Text;
using ConsoleApp.Classes;

Console.OutputEncoding = Encoding.UTF8;

VegetableShop shop = new VegetableShop();

const string SECRETWORD = "Invalid_password";
bool IsWhile = true;
bool IsAdminSession = false;

var products = new List<Product>()
{
    new Carrot(15),
    new Potato(20, 4),
    new Cucumber(14, 2),
    new Tomato(18, 6)
};

shop.AddProducts(products);

Console.WriteLine("Вітаю в магазинчику 'Ходячі Овочі', ні, це не офіс бухгалтерів... ");
while (IsWhile)
{
    Console.WriteLine("\nЩо хочете зробити?");
    Console.WriteLine("1. Купити товар\n2. Проглянути список товарів");
    if (IsAdminSession)
    {
        Console.WriteLine("3. Видалити кількість товару\n4. Видалити повністю товар\n5. Добавити товар\n6. Вийти з Адмін Панелі");
    }
    else Console.WriteLine("7. Адмін Панель");

    int choice = Convert.ToInt16(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Який товар збираєтесь купляти?\n1. Помідор\n2. Морква\n3. Огірок\n4. Картопля");
            int choiceBuyProduct = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Кількість товару?");
            int amountBuyProduct = Convert.ToInt16(Console.ReadLine());
            switch (choiceBuyProduct)
            {
                case 1:
                    shop.RemoveAmount("Tomato", amountBuyProduct);
                    break;
                case 2:
                    shop.RemoveAmount("Carrot", amountBuyProduct);
                    break;
                case 3:
                    shop.RemoveAmount("Cucumber", amountBuyProduct);
                    break;
                case 4:
                    shop.RemoveAmount("Potato", amountBuyProduct);
                    break;
                default:
                    Console.WriteLine("Такого товару немає!");
                    break;
            }
            break;

        case 2:
            shop.PrintProductsInfo();
            break;

        case 3:
            if (IsAdminSession)
            {
                Console.Write("Введіть назву товару для зменшення кількості: ");
                string nameRemove = Console.ReadLine();
                Console.Write("Кількість для зменшення: ");
                int amountRemove = Convert.ToInt16(Console.ReadLine());
                shop.RemoveAmount(nameRemove, amountRemove);
            }
            else Console.WriteLine("У вас немає відповідного доступу.");
            break;

        case 4:
            if (IsAdminSession)
            {
                Console.Write("Введіть назву товару для повного видалення: ");
                string nameFullRemove = Console.ReadLine();
                shop.RemoveProductByName(nameFullRemove);
            }
            else Console.WriteLine("У вас немає відповідного доступу.");
            break;

        case 5:
            if (IsAdminSession)
            {
                Console.Write("Введіть назву товару для додавання кількості: ");
                string nameAdd = Console.ReadLine();
                Console.Write("Скільки додати: ");
                int amountAdd = Convert.ToInt16(Console.ReadLine());
                shop.AddAmount(nameAdd, amountAdd);
            }
            else Console.WriteLine("У вас немає відповідного доступу.");
            break;

        case 6:
            if (IsAdminSession)
            {
                Console.WriteLine("Ви впевнені, що хочете вийти з Адмін панелі?\n1. Так\n0. Ні");
                int confirmExitAdmin = Convert.ToInt16(Console.ReadLine());
                if (confirmExitAdmin == 1)
                {
                    IsAdminSession = false;
                    Console.WriteLine("Ви вийшли з Адмін панелі.");
                }
            }
            else Console.WriteLine("У вас немає відповідного доступу.");
            break;

        case 7:
            Console.Write("Введіть пароль: ");
            string input = Console.ReadLine();
            if (input == SECRETWORD)
            {
                IsAdminSession = true;
                Console.WriteLine("Ви ввійшли в Адмін панель.");
            }
            else Console.WriteLine("Неправильно введений пароль!");
            break;

        default:
            Console.WriteLine("Невірна опція.");
            break;
    }
}
