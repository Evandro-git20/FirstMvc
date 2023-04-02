using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace FirstMvc.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Código")]
        public string? Codigo { get; set; }

        [DisplayName("Valor")]
        public double? Valor { get; set; }

        [DisplayName("Criado em")]
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        [DisplayName("Vencido em")]
        public DateTime? DataVencimento { get; set; }

        [DisplayName("Cliente")]
        public string? Cliente { get; set; }

    }
}