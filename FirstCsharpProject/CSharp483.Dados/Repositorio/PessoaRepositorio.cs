using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp483.Dados.Contexto;

namespace CSharp483.Dados.Repositorio
{
    public class PessoaRepositorio
    {
        public List<Pessoa> ListarTodos()
        {
            List<Pessoa> lista = new List<Pessoa>();
            DadosContext contexto = new DadosContext();

            lista = contexto.Pessoa.ToList();

            return lista;
        }
    }
}
