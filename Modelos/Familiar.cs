namespace Modelos {

class Familiar : Pessoa {

public string Parentesco {
  get; set;
}

  public override bool Validar() {

      return this.Parentesco != null &&
        this.Parentesco.Length > 0;
    }
  public string Informar() {
    return "Parentesco: " + this.Parentesco;
  }
  
}
  
}