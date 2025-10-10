using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Obrigarório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigarório informar a Placa")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigarório informar o Ano de Fabricação")]
        [Display(Name = "Ano de Fabricação")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigarório informar o Ano do Modelo")]
        [Display(Name = "Ano do Modelo")]
        public int AnoModelo { get; set; }

        public ICollection<Consumo> Consumos { get; set; }

    }
}