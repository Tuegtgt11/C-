﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tark2
{
    class TestBook
    {
        static void Main(string[] args)
        {
            Book objBook = new Book();
            objBook.Input("C#-The Complete Reference");
            Console.WriteLine(objBook.Print());
        }
    }
}
