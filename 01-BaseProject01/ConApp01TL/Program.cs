// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var i = 12;

ulong ul = (ulong)(i);

ul = System.Convert.ToUInt64(i);


Console.WriteLine(i >> 2);

var m = 222UL;
dynamic n = "222UL"; 

n = i;

Console.WriteLine("12.Type = " +  12.GetType().ToString());

Console.WriteLine("12.12.Type = " + 12.12.GetType().ToString() );

var o = 7.0 / 2.0;

Single k = 1000000.12F;

var d = 100000.1212M;



long j = i = (90 + (2 * i));
//assign(j, assign(i, add(90, times(2, i))));

for(int x=0, y=100; x < 20; ++x, y-=5)
    Console.WriteLine($"x:{x}, y:{y}");



void DoIt() =>   Console.WriteLine("Huch!");


DoIt();
