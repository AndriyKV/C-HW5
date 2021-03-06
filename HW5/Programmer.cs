﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Programmer : IDeveloper
    {
        public Programmer() { }
        public Programmer(string _language)
        {
            language = _language;
        }
        string language;
        public string Tool
        {
            get
            {
                return language;
            }
            set
            {
                Tool = language;
            }
        }

        public void Create()
        {
            Console.WriteLine("Programmer use {0} language", Tool);
        }

        public void Destroy()
        {
            Console.WriteLine("The programmer uses {0} language to break the code \n", Tool);
        }
    }
}
