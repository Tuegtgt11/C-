﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Tark2
{
    class vd1
    {
        public void DisplayDetails(object emp)
        {
            String fName = "";
            String lName = "";
            int age = 0;
            PropertyInfo[] attrs = emp.GetType().GetProperties();
            foreach(PropertyInfo attr in attrs)
            {
                switch (attr.Name)
                {
                    case "FirstName":
                        fName = attr.GetValue(emp, null).ToString();
                        break;
                    case "Last Name":
                        lName = attr.GetValue(emp, null).ToString();
                        break;
                    case "Age":
                        age = (int)attr.GetValue(emp, null);
                        break;
                }
            }
            Console.WriteLine("Name: {0} {1},Age: {2}", fName, lName, age);
        }
    }
}
