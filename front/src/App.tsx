import React from "react";
import ListarAluno from "./components/ListarAluno";
import { BrowserRouter, Link, Route, Routes } from "react-router-dom";
import ListarImc from "./components/ListarImc";
import CadastrarAluno from "./components/CadastrarAluno";
import CadastrarImc from "./components/CadastrarImc";

function App() {
  return (
    <div>
      <div>
        <BrowserRouter>
          <nav>
            <ul>
              <li>
                <Link to={"/"}>Home</Link>
              </li>
              <li>
                <Link to={"/pages/imc/listar"}>
                  Listar Imcs{" "}
                </Link>
              </li>
              <li>
                <Link to={"/pages/aluno/listar"}>
                  Listar Alunos{" "}
                </Link>
              </li>
              <li>
                <Link to={"/pages/aluno/cadastrar"}>
                  Cadastrar Alunos{" "}
                </Link>
              </li>
              <li>
                <Link to={"/pages/imc/cadastrar"}>
                  Cadastrar Imc{" "}
                </Link>
              </li>
            </ul>
          </nav>
          <Routes>
            <Route path="/" element={<ListarAluno />} />
            <Route
              path="/pages/aluno/listar"
              element={<ListarAluno />}
            />
            <Route
              path="/pages/imc/listar"
              element={<ListarImc />}
            />
            <Route
              path="/pages/aluno/cadastrar"
              element={<CadastrarAluno />}
            />
            <Route
              path="/pages/imc/cadastrar"
              element={<CadastrarImc />}
            />
          </Routes>
        </BrowserRouter>
      </div>
    </div>
  );
}

export default App;

