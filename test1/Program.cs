﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pzas32driver;
namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileConnection fcon = new FileConnection(@"E:\1.csv");
            FileCommand fcom = new FileCommand(fcon);
            List<String> list = new List<String>();
        }
    }
}
