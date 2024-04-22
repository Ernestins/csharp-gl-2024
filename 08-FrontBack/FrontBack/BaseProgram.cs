namespace FrontBack
{
  abstract class BaseProgram
  {

    public abstract void Run(string[] args);

    protected static BaseProgram PROG = Program.Ref();

    static void Main(string[] args)
    {
      {
        var temp = Console.ForegroundColor;
        try {
          Console.ForegroundColor = ConsoleColor.Yellow;

          PROG.Run(args);

        } finally {
          Console.ForegroundColor = temp;
        }
      }
    }
  }
}
