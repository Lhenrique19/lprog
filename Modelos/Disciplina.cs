namespace Modelos {

  class Disciplina {
    
    public string Nome;
    public int semestre;

    public Disciplina() : this(1){
      

    }
    public Disciplina(int semestre){
      if(semestre < 1){
        this.semestre = 1;
        }else if(semestre>10){
        this.semestre = 10;
      } else {
        this.semestre = semestre;
      }
    } 
    
    }
    
  }
  
