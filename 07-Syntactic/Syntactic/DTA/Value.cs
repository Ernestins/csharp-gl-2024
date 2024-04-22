using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Syntactic.DTA
{
  class Value
  {
    private static string id; // Class Var

    public  static string Key { get; private set; }  // autono. write protected Class Property

    static Value()  // Class Loader
    {
      var id = "XYZ";

      Value.id = id;
    }

    private string name;  // Member Data
    public string  getName()            { return name; }       // getter setter pattern
    public void    setName(string name) { this.name = name; }

    private int    number;
    public  int    getNumber()           { return number; }
    public  void   setNumber(int number) { this.number = number; }


    private int    value;
    public  int    Value_ { get { return value; } set { this.value = value; } }  // non auton. Member Property



#if DEBUG
    // Constructor (nondefault)
    public Value(string name) => this.name = name;
    // Constructor (default)
    public Value()  : this("noname") { }
#else
    // Constructor (default and nondefault)
    public Value(string name="noname") => this.name = name;
#endif

  }
}
