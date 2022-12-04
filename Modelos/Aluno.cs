namespace Modelos {
  class Aluno : Pessoa {
    private string matricula;
    private int periodo;
    
    public string Matricula {
      get => this.matricula;
      set => matricula = value;
    }
    
    public int Periodo {
      get => this.periodo;
      set {
        if (value > 0) {
        this.periodo = value;
      }
        else {
        this.periodo = 1;
      }
      }
    }
     

    public Aluno() : this(0) {
    }

    public Matricula Cursar(Curso curso) {
      Matricula matricula = new Matricula();
      matricula.Aluno = this;
      matricula.Curso = curso;
      return matricula;
    }
    
    public Aluno(int periodo) {
      this.Periodo = periodo;
    }
    
    public Aluno(string matricula, string nome) : 
    this() {
    this.Matricula  = matricula;
    this.Nome = nome;
  }

  public Matricula Curso(Curso curso) {
    Matricula matricula = new Matricula();
    matricula.Aluno = this;
    matricula.Curso = curso;
    return matricula;
  }
    
    public Aluno(string matricula, string nome, int periodo)
                : this(periodo) {
        this.Matricula = matricula;
        this.Nome = nome;
        }

    public override bool Validar() {
      return this.Matricula != null && this.Matricula.Length > 0;
    }
      
  }
}