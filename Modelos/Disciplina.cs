namespace Modelos {

  class Disciplina {
    
    public string nome;
    public int semestre;

    public Disciplina() : this(0){
      

    }
    public Disciplina(int semestre){
      if(semestre > 0){
        if(semestre <= 10){
        this.semestre = semestre;
        }
      } else {
        this.semestre = 1;
      }
    
    }
    
  }
  
}