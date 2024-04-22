namespace App
{
    using Lib.UTIL;

    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("<{0}>...</{0}>".fmt("xml"));


            var doc = "";
                doc += ("Felix".xml("name")
                      + "Willhelm Hase Str. 2".xml("strasse")
                      + "70771".xml("plz")
                      + "Leinfelden-Echterdingen".xml("ort")).xml("kunden", "id", 78.ToString());

            doc = doc.xml("kundenliste").prolog();
            Console.WriteLine(doc);
        }
    }
}
