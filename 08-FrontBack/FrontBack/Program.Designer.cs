using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontBack
{
    partial class Program
    {
        public static Program Ref()
        {
            return new Program();
        }

        public override string ToString()
        {
            return "partial class Program(.Designer).cs : BaseProgram";
        }

    }
}
