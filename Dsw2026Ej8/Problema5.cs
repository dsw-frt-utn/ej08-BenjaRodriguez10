using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        public decimal ImporteBase { get; set; }

        public Sale(decimal importeBase)
        {
            ImporteBase = importeBase;
        }
        public virtual decimal CalculateTotal()
        {
            return ImporteBase;
        }
    }

    public class RetailSale : Sale
    {
        public RetailSale(decimal importeBase) : base(importeBase) { }

        public override decimal CalculateTotal()
        {
            return ImporteBase;
        }
    }

    public class WholesaleSale : Sale
    {
        public WholesaleSale(decimal importeBase) : base(importeBase) { }

        public override decimal CalculateTotal()
        {
            return ImporteBase * 0.90m;
        }
    }

    public class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            return sale.CalculateTotal();
        }
    }
}
