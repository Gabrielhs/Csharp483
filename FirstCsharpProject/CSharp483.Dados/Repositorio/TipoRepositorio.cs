using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp483.Dados.Contexto;

namespace CSharp483.Dados.Repositorio
{
    public class TipoRepositorio
    {
        public List<Tipo> ListarDados()
        {
            List<Tipo>  lista = new List<Tipo>();
            using (DadosContext contexto = new DadosContext())
            {
                lista = contexto.Tipos.ToList();
            }

            return lista;
        }

        public Tipo BsucarPorId(int id)
        {
            Tipo p = new Tipo();
            using (DadosContext contexto = new DadosContext())
            {
                p = contexto.Tipos.Find(id);
            }

            return p;
        }

        public void Iserir(Tipo model)
        {
            using (DadosContext contexto = new DadosContext())
            {
                contexto.Tipos.Add(model);
                contexto.SaveChanges();
            }
        }

        public void Editar(Tipo tipo)
        {
            using (DadosContext ctxt = new DadosContext())
            {
                Tipo tipodb = BsucarPorId(tipo.Id);
                if (tipodb != null)
                {
                    tipodb = tipo;

                    ctxt.SaveChanges();
                }

            }

        }
    }
}
