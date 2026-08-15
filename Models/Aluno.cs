using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CRUDALNBCC.Models
{
   public class Aluno
   {
      public int id { get; set; }
      public string nome { get; set; }
      public int idade { get; set; }
      //public string curso { get; set; }

      public float nota { get; set; }

   }
}