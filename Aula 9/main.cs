using Modelos;

class Aula9 {

  public static void Main (string[] args){

    Aluno aluno1 = new Aluno(1);
    aluno1.Cpf = " 660.036.460-20";
    PaginaAluno paginaAluno = new PaginaAluno();
    Impressora.print(paginaAluno.Formatar(aluno1));
  }
}