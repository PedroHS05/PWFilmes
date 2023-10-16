using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWFilmes.Domain
{
    [Table("Categoria")]
    public class Categoria
    {

        //DateAnnotations = configurar a estrutura de banco de dados
        [Key]
        [Required(ErrorMessage = "O Código deve ser informado.")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "A Descrição deve ser informada.")]
        [MaxLength(100, ErrorMessage = "A Descrição deve conter no máximo 100 caracteres.")]
        public string Descricao { get; set; }
        
        [Required(ErrorMessage = "A Cir deve ser informada.")]
        [MaxLength(50, ErrorMessage = "A Cor deve conter no máximo 50 caracteres.")]
        public string Cor { get; set; }
    }
}
