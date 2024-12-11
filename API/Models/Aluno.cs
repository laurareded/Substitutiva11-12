namespace API.models{ 

public class Aluno {

    public string? Nome { get; set;}
    public string? Sobrenome { get; set;}
    public string AlunoId { get; set;} = Guid.NewGuid().ToString();
    public DateTime CriadoEm { get; set; } = DateTime.Now;

}

}