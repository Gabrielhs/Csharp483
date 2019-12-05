using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CSharp483.Dados
{
    public class Produto : Base
    {
        public string Descricao { get; set; }
        public string Modelo { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public string Marca { get; set; }

        public Tipo Tipo { get; set; }

    }
}
