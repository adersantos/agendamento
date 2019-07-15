using System;
using System.ComponentModel.DataAnnotations;

namespace NetCoders.Agenda.Model
{
    public sealed class AgendaMOD
    {
        public int Codigo { get; set; }

        public int Cliente { get; set; }

        [Display(Name = "Título: ")]
        [Required(ErrorMessage = "Ops!, Informe o título.")]
        [DataType(DataType.Text, ErrorMessage = "Ops!, Informe somente texto.")]
        public String Titulo { get; set; }

        [Display(Name = "Descrição Simples: ")]
        [Required(ErrorMessage = "Ops!, Informe a descrição simples.")]
        [DataType(DataType.Text, ErrorMessage = "Ops!, Informe somente texto.")]
        public string DescricaoSimples { get; set; }

        [Display(Name = "Descrição Completa: ")]
        [Required(ErrorMessage = "Ops!, Informe a descrição completa.")]
        [DataType(DataType.Text, ErrorMessage = "Ops!, Informe somente texto.")]
        public string DescricaoCompleta { get; set; }

        [Display(Name = "Data: ")]
        [Required(ErrorMessage = "Ops!, Informe a data.")]
        [DataType(DataType.Date, ErrorMessage = "Ops!, Informe somente data válida.")]
        public DateTime Data { get; set; }

        public DateTime Gravado { get; set; }

        public string Status { get; set; }
    }
}
