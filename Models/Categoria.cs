﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMV.Models
{
    public class Categoria
    {

        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage ="Preencha o campo descrição!")]
        public string Descricao { get; set; }

        public List<Produto> Produtos { get; set; }    

    }
}
