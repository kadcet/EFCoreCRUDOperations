﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormUI.Data
{
	public class Product
	{
        public int? ProductID { get; set; }

        public string ProductName { get; set; }

        public string? QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }

        public int? CategoryID { get; set; }

        public Category Category { get; set; }
        //p.Category.Name
    }
}
