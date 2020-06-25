using System:
using System.Collections.Generic;

 namespace E2
 {
  class Program
{
static void Main (string[] arrgs)
{
int op=1;
Empresa empresa = new Empresa();

while (op!=0) 
{
Console.WriteLine("1: Para mostrar noche de sustos \n2 : Para mostrar noche de risas");
Console.WriteLine("2: Para ver los mas respetados");
Console.WriteLine("3: Para ver la energia que genera la empresa");

op = Int32.Parse(Console.ReadLine());

switch (op)

{
 Case 1:
empresa.NocheDeSustos();
break;
case 2;
Empresa.NocheDeRisas();
break;
case 3:
foreach (Mounstruos aux in empresa.respetados())
 {
  Console.WriteLine(aux.Nombre + " " + aux.Respeto);
 }
break;
case 4:
 Console.WrtiteLine("La energia total recaudada es : "+empresa.EnergiaTotal());
break;
    }
   }
  }
 }
}