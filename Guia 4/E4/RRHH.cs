using System;
using System.Collections.Generic;

namespae E4
{
 public class RRHH : CajaBancaria
 {
  private int personasReferidas;
  public RRHH(int saldo, int personasReferidas) : base(saldo)
  {
  public override void extraer(int sacar)
  {
   saldo = saldo -sacar;
  }
  public override void depositar()
  {
    saldo+= 35000 + (5000*personasReferidas);
  }
 }
}
