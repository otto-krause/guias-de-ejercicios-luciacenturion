
using System;
using System.Collections.Generic;

namespace E4
{
 public class Empleado
 {
  List<CajaBancaria>empleados = new List<CajaBancaria>();
  public Empleado()
  {
 CajaBancaria empleado1 = new RRHH(1000 , 2);
 CajaBancaria empleado2 = new RRHH(500 , 1);
 CajaBancaria empleado3 = new Programador(2000, "junior");
 CajaBancaria empleado4 = new Programador(2500, "senior");
 CajaBancaria empleado5 = new Administrador(1500);
 empleados.Add(empleados1);
 empleados.Add(empleados2);
 empleados.Add(empleados3);
 empleados.Add(empleados4);
 empleados.Add(empleados5);
  }
 }
}

ADMINISTRADOR
using System;
using System.Collections.Generic;

namespace E4
{
 public class Administrador : CajaBancaria
 {
 public Administrador (int saldo) : base (saldo)
{
public override void extraer(int sacar)
{
 saldo = saldo - sacar;
}
public override void depositar()
  {
 saldo = 35000;
  }
 }
}
