using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Task
{
    internal class Product
    {

        public  int _no;
        public string Name;
        public double Price;
        private static int  _totalcount;

        public Product()
        {
            _totalcount++;
            _no = _totalcount;



        }



    }
}
