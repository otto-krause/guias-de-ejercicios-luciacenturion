usign System;
using System.Collections.Generic;

namespace E2
{
public calss Empresa
{
List(Mounstruos) mounstruos = new List(Mounstruos();
public Empresa()
{
 Mounstruos mounstruos1 = new Peligrosos(40 ,"mounstruo 1");
 Mounstruos mounstruos2 = new Amigables(45 ,"mounstruo 2");
 Mounstruos mounstruos3 = new Peligrosos(25 ,"mounstruo 3");
 Mounstruos mounstruos4 = new Amigables(30 ,"mounstruo 4");

mounstruos.Add(mounstruos1);
mounstruos.Add(mounstruos2);
mounstruos.Add(mounstruos3);
mounstruos.Add(mounstruos4);

}
public void NocheDeSustos()
{
foreach (Mounstruos aux un mounstruos)
 {
 aux.asustar();
 }
}
public void NocheDeRisas()
{
forearch (Mounstruos aux in mounstruos)
 {
 aux.reir();
 }
}
public List <Mounstruos> respetados()
{
 List<Mounstruos> respeto = new List<Mounstruos>();
 foreach (Mousntruos aux in mounstruos)
{
 if(aux.respeto>70)
 {
 respeto.Add(aux);
 }
}
return respetos;
}
public int EnergiaTotal()
{
int total=0;
foreach (Mounstruos aux in mounstruos)
 {
   total+=aux.Respetos;
 }
return total;
  }
 }
}