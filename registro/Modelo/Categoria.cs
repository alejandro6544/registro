using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registro.Modelo
{
    class Categoria
    {
        private String categoria;

        public Categoria()
        {

        }
        public Categoria(String categoria)
        {
            this.categoria = categoria;
        }

        public String getCategoria()
        {
            return categoria;
        }
        public void setCategoria(String categoria)
        {
            this.categoria = categoria;
        }

        public String toString()
        {
            return "Categoría " + categoria;
        }

    }
}
