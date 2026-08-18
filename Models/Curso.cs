using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CRUDALNBCC.Models
{
    [Table("curso")]
    public class Curso
    {
        [Display(Name ="ID: ")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name ="Descrição: ")]
        [StringLength(25, ErrorMessage = "Tamanho campo inválido 35 caracteres")]
        [Required(ErrorMessage ="Campo não pode ser nulo...")]
        public string descricao { get; set; }
        
        [Display(Name ="Área: ")]
        [StringLength(12, ErrorMessage = "Tamanho campo inválido, máximo 12 caracteres")]
        [Required(ErrorMessage ="Campo não pode ser nulo...")]
        public string area { get; set; }    
        
        [Display(Name ="Sigla: ")]
        [StringLength(3, ErrorMessage = "Tamanho campo inválido")]
        [Required(ErrorMessage ="Campo não pode ser nulo...")]
        public string sigla { get; set; }
    }

}