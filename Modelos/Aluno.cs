namespace Modelos {

  class Aluno {
    private string matricula;
    //private string nome;
    private int periodo;

    public string Matricula {
      get => matricula;
      set => matricula = value;
    }
    public string Nome {
      get; set;
    }
    
    public int Periodo {
      get => this.periodo;
      set{ if (value > 0) {
        this.periodo =value;
        } else {
        this.periodo = 1;
        
        }
        
      }
    }

    public Aluno() : this(0) {
            
    }
    public Aluno(int periodo) {
      this.Periodo = periodo;
      
    }
    

    public Aluno (string matricula, string nome) : this(){
      this.Matricula = matricula;
      this.Nome = nome;
      
    }

    public Aluno (string matricula, string nome, int periodo) : this(periodo){
      this.Matricula = matricula;
      this.Nome = nome;
      
      
    }
    
    public bool Matricular( Disciplina disciplina) {
    
      return this.periodo == disciplina.Semestre;
    }
    
  }
  
}