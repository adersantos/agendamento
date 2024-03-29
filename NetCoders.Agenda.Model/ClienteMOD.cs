﻿using System.ComponentModel.DataAnnotations;

namespace NetCoders.Agenda.Model
{
    public class ClienteMOD
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome.")]
        [DataType(DataType.Text, ErrorMessage = "Informe somente texto.")]
        public string Nome { get; set; }

        [DataType(DataType.Text, ErrorMessage = "Informe somente texto.")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Informe o número do celular.")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Informe formato de número de telefone.")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Informe o número do documento.")]
        public int Documento { get; set; }

<<<<<<< HEAD
=======

>>>>>>> 199b448c761e984def3565897bfc271d2d9a1f5a
        public string Endereco { get; set; }
    }
}
