using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {

            int copiaValor = originalValue;

            copiaValor++;

            Product copiaProducto = product;

            copiaProducto.CambiarDescripcion("Descripción Modificada");

            return $"{originalValue}-{copiaValor}-{product.Description}";
        }
    }

}
