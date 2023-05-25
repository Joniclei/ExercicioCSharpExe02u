namespace ExercicioB
{
  public class DadosEmp
  {
    public static string Nomee()
    {

      string name;

      Console.WriteLine("Escreva seu nome : ");
      name = Console.ReadLine();
      return name;
    }

    public static int Salario()
    {
      int sal = 0;
      Console.WriteLine("Qual seu salario");
      sal = Convert.ToInt32(Console.ReadLine());

      return sal;

    }

  }

}
