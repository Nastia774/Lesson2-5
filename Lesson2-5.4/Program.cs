using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Article[] article = new Article[3];

            article[0] = new Article() { NameProduct = "Яблоко", NameShop = "Яблочко ТМ", Price = 25.65 };
            article[1] = new Article() { NameProduct = "Хлеб", NameShop = "Хлебушек круглосуточно", Price = 13.24 };
            article[2] = new Article() { NameProduct = "Молоко", NameShop = "Молочные продукты", Price = 35 };

        Store store = new Store(article);
            store.OutProduct("Яблоко");

            Console.ReadKey();
        }
    }
}
