import { Aluno } from "./Aluno";
export interface Imc {
    
    altura: string;
    peso: string;
    criadoEm?: string;
    aluno?: Aluno;
    alunoId?: string;
}