using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class ProductNotFoundException:Exception
    {

       ProductNotFoundException(string message) : base(message)
       {
            Console.WriteLine("Product Not Found ");


       }


    }
}
