import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { Imc } from "../interfaces/Imc";
import { Aluno } from "../interfaces/Aluno";

function CadastrarImc() {
  const navigate = useNavigate();
  const [altura, setAltura] = useState("");
  const [peso, setPeso] = useState("");
  const [alunoId, setAlunoId] = useState("");
  const [alunos, setAlunos] = useState<Aluno[]>([]);

  useEffect(() => {
    carregarAlunos();
  }, []);

  function carregarAlunos() {
    fetch("http://localhost:5000/pages/aluno/listar")
      .then((resposta) => resposta.json())
      .then((alunos: Aluno[]) => {
        setAlunos(alunos);
      });
  }

  function CadastrarImc(e: any) {
    const imc: Imc = {
        altura: altura,
        peso: peso,
        alunoId: alunoId,
    };

    fetch("http://localhost:5000/pages/imc/cadastrar", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(imc),
    })
      .then((resposta) => resposta.json())
      .then((imc: Imc) => {
        navigate("/pages/imc/listar");
      });
    e.preventDefault();
  }

  return (
    <div>
      <h1>Cadastrar Imc</h1>
      <form onSubmit={CadastrarImc}>
        <label>Altura:</label>
        <input
          type="text"
          placeholder="Digite a altura"
          onChange={(e: any) => setAltura(e.target.value)}
          required
        />
        <br />
        <label>Peso:</label>
        <input
          type="text"
          placeholder="Digite o peso"
          onChange={(e: any) => setPeso(e.target.value)}
        />
        <br />
        <label>Aluno:</label>
        <select onChange={(e: any) => setAlunoId(e.target.value)}>
          {alunos.map((aluno) => (
            <option
              value={aluno.alunoId}
              key={aluno.alunoId}
            >
              {aluno.nome}
            </option>
          ))}
        </select>
        <br />
        <button type="submit">Cadastrar</button>
      </form>
    </div>
  );
}

export default CadastrarImc;
