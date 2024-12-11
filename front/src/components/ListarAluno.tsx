import { useEffect, useState } from "react";
import { Aluno } from "../interfaces/Aluno";


function ListarAluno() {
  const [tarefas, setAlunos] = useState<Aluno[]>([]);

  useEffect(() => {
    carregarAlunos();
  }, []);

  function carregarAlunos() {
    fetch("http://localhost:5000/pages/aluno/listar")
      .then((resposta) => resposta.json())
      .then((alunos: Aluno[]) => {
        console.table(alunos);
        setAlunos(alunos);
      });
  }



  return (
    <div>
      <h1>Listar Alunos</h1>
      <table border={1}>
        <thead>
          <tr>
            <th>#</th>
            <th>Nome</th>
            <th>Sobrenome</th>
            <th>Id</th>
            <th>Criado Em</th>
          </tr>
        </thead>
      </table>
    </div>
  );
}

export default ListarAluno;