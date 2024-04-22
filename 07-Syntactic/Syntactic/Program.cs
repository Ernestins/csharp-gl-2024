namespace Syntactic
{
  class Program
  {
    [STAThread]
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");

      DTA.Value v1 = new DTA.Value();

      v1.setNumber(5);

      v1.setNumber(v1.getNumber() + 1);

      v1.Value_ = 5;
      v1.Value_++;




    }
  }
}
