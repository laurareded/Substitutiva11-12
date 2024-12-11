import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { Aluno } from "../interfaces/Aluno";
import { Imc } from "../interfaces/Imc";

function CadastrarAluno() {
  const navigate = useNavigate();
  const [nome, setNome] = useState("");
  const [sobrenome, setSobrenome] = useState("");
  const [imcId, setImcId] = useState("");
  const [imcs, setImcs] = useState<Imc[]>([]);

  function CadastrarAluno(e: any) {
    const aluno: Aluno = {
        nome: nome,
        sobrenome: sobrenome,
        alunoId: ""
    };


    fetch("http://localhost:5000//pages/aluno/cadastrar", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(aluno),
    })
      .then((resposta) => resposta.json())
      .then((tarefa: Aluno) => {
        navigate("/pages/aluno/listar");
      });
    e.preventDefault();
  }

  return (
    <div>
      <h1>Cadastrar Aluno</h1>
      <form onSubmit={CadastrarAluno}>
        <label>Nome:</label>
        <input
          type="text"
          placeholder="Digite o nome"
          onChange={(e: any) => setNome(e.target.value)}
          required
        />
        <label>Sobrenome:</label>
        <input
          type="text"
          placeholder="Digite o sobrenome"
          onChange={(e: any) => setSobrenome(e.target.value)}
          required
        />
        <br />
        <button type="submit">Cadastrar</button>
      </form>
    </div>
  );
}

export default CadastrarAluno;