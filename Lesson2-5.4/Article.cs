using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_5._4
{
    class Article
    {
        string _nameProduct;
        string _nameShop;
        double _price;

        public Article(string nameProduct, string nameShop, double price)
        {
            _nameProduct = nameProduct;
            _nameShop = nameShop;
            _price = price;
        }
        public string NameProduct()
        {
            return _nameProduct;
        }
        public string NameShop()
        {
            return _nameShop;
        }
        public double Price()
        {
            return _price;
        }
    }
}
