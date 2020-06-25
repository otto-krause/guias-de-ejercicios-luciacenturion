using System;
usign System.Collections.Generic;

namespace E1
{
 class Program
 {
 static void Main(string[] args)
 {
  int op=1;
  
  Perro perro = new Perro(40)
  Pajaro pajaro = new Pajaro(52)
 
while (op!=0)
{
 Console.WriteLine("1: Para darle de comer al perro \n2 :Para dar de comer al pajaro");
 Console.WriteLine("2: Para jugar con el perro \n2 : Para jugar con el pajaro");
 Console.WriteLine("3: Para hacer dormir al perro \n2 : Para hacer dormir al pajaro");
 op = Int32.Parse(Console.ReadLine());
switch (op)
{
 case 1 :
perro.come();
Console.WriteLine("Energia del perro : " + perro.energy());
break;

case 2 :
perro.juega();
Console.WriteLine("Energia del perro : " + perro.energy());
break;
     }
    }
   }
  }
}