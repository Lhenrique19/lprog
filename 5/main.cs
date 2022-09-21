using Modelos;

class Aula5 {

  public static void Main (string[] args) {
    Aluno aluno1 = new Aluno(0);
    aluno1.Cpf = "206.523.670-11";
    Impressora.print(aluno1);
    
    Aluno aluno2 = new Aluno(1);
    aluno2.Cpf = "759.187.350-46";
    Impressora.print(aluno2);
    
    Pessoa pessoa1 = new Professor();
    pessoa1.Cpf = "750.029.400-05";
    Impressora.print(pessoa1);
    
    Pessoa pessoa2 = (Pessoa) aluno2;
    Impressora.print(pessoa2);
    
    Aluno aluno3 = (Aluno) pessoa2;
    Impressora.print(aluno3);
    
    Professor professor1 = new Professor();
    professor1.Cpf = "869.766.640-68";
    Impressora.print(professor1);

    Familiar familiar1 =  new Familiar();
    familiar1.Nome = "Roberto Cristovão";
    familiar1.Cpf = "230.097.040-62";
    familiar1.Parentesco = "Tio";
    Impressora.print(familiar1);
  }

}