using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zextdevapp1
{
    public abstract class baseClass
    {
        public int id;
        public string firm;
        public string model;
        public decimal price;

        public abstract string zextprint();
    }
}