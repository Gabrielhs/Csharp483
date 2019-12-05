using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstCsharpProject.SolutionWebApppliication.Models
{
    public class Tipo
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        [Required] // Validação
        [Display(Name ="Descrição :")]
        public string Descricao { get; set; }   

    }
}