using System;
using System.Collections.Generic;

namespace E2
{ 
 public class Amigables : Mounstruos
{
public Amigables (int respeto, string nombre ) : base (respeto,nombre)
{
public override void asustar()
{
 respeto=7;
}
public override void reir()
  {
 respeto:=1;
  }
 }
}