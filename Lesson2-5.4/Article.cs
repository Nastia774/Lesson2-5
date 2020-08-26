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

        public string NameProduct
        {
            get { return _nameProduct; }
            set { _nameProduct = value; }

        }
        public string NameShop
        {
            get { return _nameShop; }
            set { _nameShop = value; }

        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }

        }
    }
}
