using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CadastrodeClientes.Models
{
    public class Cliente
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage =" O nome é um campo obrigatório",AllowEmptyStrings =false)]
        [Display(Name = "Nome")]
        
        public String nome { get; set; }
        [Required(ErrorMessage = "A data de nascimento é um campo obrigatório",AllowEmptyStrings = false)]
        [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date)]
        public DateTime dataNascimento { get; set; }
        [Required(ErrorMessage = "O sexo  é um campo obrigatório", AllowEmptyStrings = false)]
        [Display(Name ="Sexo")]
        public Enumerador.sexo sexo { get; set; }
        [Display(Name ="CEP")]
        public String cep { get; set; }
        [Display(Name ="Endereço")]
        public String endereco { get; set; }
        [Display(Name ="Número")]
        public int numero { get; set; }
        [Display(Name = "Complemento")]
        public String complemento { get; set; }
        [Display(Name ="Bairro")]
        public String bairro { get; set; }
        [Display(Name = "Cidade")]
        public String cidade { get; set; }
        [Display(Name = "Estado")]
        public String estado { get; set; }

    }
}
