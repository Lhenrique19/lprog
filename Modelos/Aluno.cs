//Uma class pode ter métodos

namespace Modelos {
  class Aluno : Pessoa {
    //Nunca declarar um atributo público
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

    public bool Matricular(Disciplina disciplina) {
      return this.Periodo == disciplina.Semestre;
    }
    
    public Aluno(int periodo) {
      this.Periodo = periodo;
    }
    
    public Aluno(string matricula, string nome) : 
    this() {
    this.Matricula  = matricula;
    this.Nome = nome;
  }
    
    public Aluno(string matricula, string nome, int periodo)
                : this(periodo) {
        this.Matricula = matricula;
        this.Nome = nome;
        }

    public override bool Validar() {

      return this.Matricula != null &&
        this.Matricula.Length > 0;
    }
  }
}