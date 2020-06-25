using System;
using System.Collections.Generic;

namespace E4
{
 class Program
 {
  static void Main(string[] args)
  {
   int op=1;
   Empleado empleados = new Empleado();
   
   while (op!=0)
   {
     foreach (Empleado aux in )
     {
     Console.WriteLine(aux);
     Console.WriteLine("1: Para extraer el dinero \n2 :Para depositar el dinero");
     op = Int32.Parse(Console.ReadLine());
     switch (op)
     {
      case 1:
       aux;
       break;
      case 2:
       aux;
       break;
      }
    }
  }
}

PROGRAMADOR 
using System;
using System.Collections.Generic;

namespce E4
{
  public class Programador = CajaBancaria
  {
   private string nivel;
   public Programador (int saldo,string nivel) : base (saldo)
   {
   public override void extraer (int sacar)
   {
    saldo= saldo - sacar;
   }
   public override void depositar()
   {
    saldo= 20000+level(nivel)
   }
   public int level(string nivel)
   {
    if(nivel = "junior")
    {
      return 10000
    }
    else 
    {
     if (nivel == "semisenior")
      {
        return 20000;
      }
    else 
     {
      if(nivel == "senior")
       { 
        return 30000;
       }
      }
     }
    return 0;
   }
  }
}