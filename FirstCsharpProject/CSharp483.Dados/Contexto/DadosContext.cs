using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp483.Dados.Contexto
{
    public class DadosContext: DbContext
    {
        public DbSet <Pessoa> Pessoa { get; set; }
        public DbSet <Produto> Produto { get; set; }
        public DadosContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\320045758\Documents\GbarielhsProway\Csharp483\FirstCsharpProject\CSharp483.Dados\Banco\DadosDB.mdf;Integrated Security=True")
        {
                    
        }
    }
}
