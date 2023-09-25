using System.ComponentModel.DataAnnotations;
using WebAPI.Enums;

namespace WebAPI.Models
{
    public class FuncionarioModel
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Sobrenome { get; set; }
        public DepartamentoEnum Departamento { get; set; }
        public bool Ativo { get; set; }
        public TurnoEnum Turno { get; set; }
        public DateTime DataDaCriacao { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime DataDaAlteracao { get; set; } = DateTime.Now.ToLocalTime();
    }
}
