﻿using Northwind.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entites.Concrete
{
    //Burada Veritabanında Sutunlara Karşılık Gelen Property'leri ve Sınıfı Tanımladık.
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
        public Int16 UnitsInStock { get; set; }
    }
}
