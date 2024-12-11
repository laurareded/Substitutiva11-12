import { useEffect, useState } from "react";
import { Imc } from "../interfaces/Imc";
import axios from "axios";

function ListarImc() {
  const [imcs, setImcs] = useState<Imc[]>([]);

  useEffect(() => {
    carregarImc();
  }, []);

  function carregarImc() {
    fetch("http://localhost:5000/pages/imc/listar")
      .then((resposta) => resposta.json())
      .then((tarefas: Imc[]) => {
        console.table(imcs);
        setImcs(imcs);
      });
  }

  return (
    <div>
      <h1>Listar Imcs</h1>
      <table border={1}>
        <thead>
          <tr>
            <th>#</th>
            <th>Altura</th>
            <th>Peso</th>
            <th>Aluno id</th>
            <th>Criado Em</th>
            <th>Alterar Imc</th>
          </tr>
        </thead>
      </table>
    </div>
  );
}

export default ListarImc;
