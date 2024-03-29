﻿using Produtos_Sitio.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Produtos_Sitio.Models
{
    public enum Conclusao { Sim, Não }

    [Table("Entregas")]
    public class Entrega
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Cod. Entrega")]
        public int id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data da Entrega")]
        public DateTime data_entrega { get; set; }

        [Required(ErrorMessage = "Campo 'Entregue' é obrigatório.")]
        public Conclusao entregue { get; set; }

        public Venda venda { get; set; }


    }



}
