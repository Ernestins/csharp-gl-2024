#define MULTI // DELEG // CHAIN
using System.ComponentModel;
using System.Xml.Linq;

namespace structure
{
    class Alias { static void Main(string[] args) => new Struct().Program(args); }

    struct Struct
    {
        public string? Id   { get; set; }
        public string  Name { get; set; }
        public int     Age  { get; set; }

#if CHAIN
        /* Constructor Chaining */
        public Struct()
        {
            Id   = null;
            Name = "";
            Age  = 0;
        }
        public Struct(string name)
            : this()
        {
            Name = name;
        }
        public Struct(string name, int age)
            : this(name)
        {
            Age = age;
        }
        public Struct(string id, string name, int age)
            : this(name, age)
        {
            Id = id;
        }
#endif

#if DELEG
        /* Constructor delegation */
        public Struct()                                : this(null, ""  , 0)      { }
        public Struct(string name)                     : this(null, name, 0)    { }
        public Struct(string name, int age)            : this(null, name, age)  { }
        public Struct(string id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
#endif

#if MULTI
        /* Constructor Defaults Parameters (Multi Signature) */
        //Struct();
        //Struct("XKJS76A");
        //Struct("Felix"); // Vorsicht !!! geht schreibt aber Felix in die Id !!!
        //Struct(null, "Felix");
        //Struct(18) // geht nicht !!!
        //Struct(null, "Felix", 18);
        public Struct(string? id = null, string name = "", int age = 0) 
          { Id=id; Name=name; Age=age; }
        //public Struct(int age) : this(null, "", age) { }
#endif


        /*
        static void Main(string[] args)
        {
            Console.WriteLine("<Main>Hello Folks");
            Struct s1 = new Struct();

            s1.Name = "Fleix";
            s1.callMe();
        }
        */

        static void Main(string[] args)
        {
            //Struct s0 = new Struct(null, null, 18); // Naja !!
            //Struct s00 = new Struct(17);
            //Struct s000 = new Struct(age: 18, id: "REF00AKB17");

            Struct s1 = new Struct(age: 18).Program(args);
        }

        public Struct Program(/* Struct this, */ string[] args)
        {
            Console.WriteLine("<Program>Hallo Leute");
            this.callMe();
            return this;
        }

        public void callMe() => Console.WriteLine("doit");
    }
}
