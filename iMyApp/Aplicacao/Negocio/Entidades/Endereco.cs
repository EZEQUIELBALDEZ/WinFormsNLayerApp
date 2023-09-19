using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Services;

namespace Negocio.Entidades
{
    public class Endereco
    {
        public Endereco()
        {
            var cep = new ViacepService();
            cep.ObterEnderecoPorCep("");
        }
    }
}
