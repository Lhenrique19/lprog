using Modelos;

class Aula9 {

   public static string LinhaAluno() { 
     return "===============****=====================";
  }
  
  public static void Main (string[] args){

    Aluno aluno1 = new Aluno(1);
    aluno1.Cpf = " 660.036.460-20";
    Aluno aluno2 = new Aluno(1);
    aluno2.Cpf = " 526.543.707-04";
    PaginaAluno paginaAluno = new PaginaAluno();
    Impressora.print(paginaAluno.Formatar(aluno1));
    Impressora.print(paginaAluno.Formatar(aluno2), LinhaAluno, LinhaAluno);
  }
}