using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_5._4
{
    class Store
    {
        Article[] _article;

        public Store(params Article[] article)
        {
            _article = article;
        }
        public object this[int index]
        {
            get
            {
                if (index >= 0 && index < _article.Length)
                    return _article[index];
                else
                    return "Такого товара нет. ";
            }
        }
        public void OutProduct(string nameProduct)
        {
            for (int i = 0; i < _article.Length; i++)
            {
                if (nameProduct == _article[i].NameProduct)
                {
                    Console.WriteLine($"Товар {_article[i].NameProduct}  {_article[i].NameShop}   {_article[i].Price}");
                    break;
                }
                else
                    Console.WriteLine("Такого товара нет.");
            }
        }
    }
}
