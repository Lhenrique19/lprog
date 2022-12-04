using System;

namespace Modelos {

  class Impressora {

    
    public delegate string Linha();

    
    public static string LinhaComum() {
      return "===================================";
    }

    
    public static void print(Texto texto) {
      print(texto, LinhaComum, LinhaComum);
    }
    
    public static void print(Texto texto,
                                Linha cabecalho,
                                Linha rodape) {
      Console.WriteLine(cabecalho());
      Console.WriteLine(texto.Informar());
      Console.WriteLine(rodape());
    }
    
  }

}