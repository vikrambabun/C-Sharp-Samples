﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class XEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public bool IsExEmployee
        {
            get
            {
                return true;
            }
        }
    }
}