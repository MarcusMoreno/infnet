using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Application.ViewModels
{
   public class ContaViewModel
    {
        public ContaViewModel()
        {
            ContaId = Guid.NewGuid();
        }

        [Key]
        public Guid ContaId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo senha")]
        [MaxLength(8, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha uma senha válida")]
        [DisplayName("Senha")]
        public string Senha { get; set; }

        //[Required(ErrorMessage = "Preencha o campo CPF")]
        //[MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        //[DisplayName("CPF")]
        //public string CPF { get; set; }

        //[Display(Name = "Data de Nascimento")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        //[DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        //public DateTime DataNascimento { get; set; }

        //[ScaffoldColumn(false)]
        //public DateTime DataCadastro { get; set; }

        //[ScaffoldColumn(false)]
        //public bool Ativo { get; set; }

        //public ICollection<EnderecoViewModel> Enderecos { get; set; }
    }
}
