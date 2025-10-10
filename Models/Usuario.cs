using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    [Table("Usuários")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="É obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É obrigatório informar a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o perfil")]
        public Perfil Perfil { get; set; }

    }

    public enum Perfil
    {
        Admin, 
        User
    }
}
