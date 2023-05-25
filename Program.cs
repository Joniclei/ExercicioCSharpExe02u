using System;

namespace ExercicioB
{
  public class Program
  {
    public static void Main(string[] args)
    {
      string nameA, nameB;
      int salA = 0, salB = 0;
      int resultado = 0;

      nameA = DadosEmp.Nomee();
      salA = DadosEmp.Salario();

      nameB = DadosEmp.Nomee();
      salB = DadosEmp.Salario();

      resultado = (salA + salB) / 2;



      Console.WriteLine(resultado.ToString("C"));
    }
  }
}
