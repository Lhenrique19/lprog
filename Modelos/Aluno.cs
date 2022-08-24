namespace Modelos {

  class Aluno {
    public string matricula;
    public string nome;
    public int periodo;

    public Aluno() : this(0) {
            
    }
    public Aluno(int periodo) {
      if (periodo > 0) {
        this.periodo = periodo;
      } else {
        this.periodo = 1;
      }
    }

    public Aluno (string matricula, string nome) : this(){
      this.matricula = matricula;
      this.nome = nome;
      
    }

    public Aluno (string matricula, string nome, int periodo) : this(periodo){
      this.matricula = matricula;
      this.nome = nome;
      
      
    }
    
    public bool Matricular( Disciplina disciplina) {
    
      return this.periodo == disciplina.semestre;
    }
    
  }
  
}