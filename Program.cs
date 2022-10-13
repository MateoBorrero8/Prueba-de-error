using System;
using System.Collections.Generic;

List<Cliente> listCliente = new List<Cliente>();
listCliente.Add(new Cliente { Id = 1, Nombre = "Mauro", Sexo = "Masculino", Telefono = 4535345, Edad = 19, });
listCliente.Add(new Cliente { Id = 2, Nombre = "Sofia", Sexo = "Femenino", Telefono = 534536, Edad = 24, });
listCliente.Add(new Cliente { Id = 3, Nombre = "Lucas", Sexo = "Masculino", Telefono = 365463, Edad = 16, });
listCliente.Add(new Cliente { Id = 4, Nombre = "Maria", Sexo = "Femenino", Telefono = 57555, Edad = 43 });
listCliente.Add(new Cliente { Id = 5, Nombre = "Hernan", Sexo = "Masculino", Telefono = 867868, Edad = 62 });


foreach (Cliente c in listCliente)
{
    Console.WriteLine("Cliente: ");
    Console.WriteLine(" Nombre: " + c.Nombre + " Edad: " + c.Edad + " Sexo: " + c.Sexo + " Telefono: " + c.Telefono);
    Console.ReadLine();
}



