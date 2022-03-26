using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CidadesInteligentes.MVC.Models
{
    public class EstacaoRecargaViewModel
    {
        public Guid Id { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "O campo Tipo é obrigatório.")]
        public int Tipo { get; set; }

        [Display(Name = "Latitude")]
        [Required(ErrorMessage = "O campo Latitude é obrigatório.")]

        public double Latitude { get; set; }

        [Display(Name = "Longitude")]
        [Required(ErrorMessage = "O campo Longitude é obrigatório.")]
        public double Longitude { get; set; }
    }
}
