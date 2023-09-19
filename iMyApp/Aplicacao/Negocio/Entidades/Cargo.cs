using System.ComponentModel.DataAnnotations;
using Negocio.Entidades.Comum;
using Negocio.Validators;

namespace Negocio.Entidades
{
    public class Cargo : EntidadeBase
    {
        [Required(ErrorMessage = "Nome é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        public bool Status { get; set; }

        public Cargo(string nome, bool status)
        {
            Nome = nome;
            Status = status;
            
            CriadoPor = "Welton";
            CriadoEm = DateTime.Now;
            Validacoes.ValidarDataAnotattions(new object());

            AlteradoPor = "Welton";
            AlteradoEm = DateTime.Now;
        }
    }
}
