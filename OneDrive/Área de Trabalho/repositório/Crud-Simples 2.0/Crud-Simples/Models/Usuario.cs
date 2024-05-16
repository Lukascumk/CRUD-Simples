﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud_Simples.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Name="Código")]
        [Column("Id")]
        public  int Id { get; set; }


        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }
    }
}
