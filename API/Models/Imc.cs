using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API.models {

public class Imc {

    public string? Altura { get; set;} 
    public string? Peso { get; set;} 
    public DateTime CriadoEm { get; set; } = DateTime.Now;
    public Aluno? Aluno { get; set;}
    public string? AlunoId { get; set;}
  
}

}