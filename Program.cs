using System;
using System.Collections.Generic;

List<Cliente> listCliente = new List<Cliente>();
listCliente.Add(new Cliente { Id = 1, Nombre = "Mauro", Sexo = "Masculino", Telefono = 444, Edad = 19, });
listCliente.Add(new Cliente { Id = 2, Nombre = "Sofia", Sexo = "Femenino", Telefono = 999, Edad = 24, });
listCliente.Add(new Cliente { Id = 3, Nombre = "Lucas", Sexo = "Masculino", Telefono = 333, Edad = 16, });
listCliente.Add(new Cliente { Id = 4, Nombre = "Maria", Sexo = "Femenino", Telefono = 555, Edad = 43 });
listCliente.Add(new Cliente { Id = 5, Nombre = "Hernan", Sexo = "Masculino", Telefono = 777, Edad = 62 });


foreach (Cliente c in listCliente)
{
    Console.WriteLine("Cliente: ");
    Console.WriteLine(" Nombre: " + c.Nombre + " Edad: " + c.Edad + " Sexo: " + c.Sexo + " Telefono: " + c.Telefono);
    Console.ReadLine();
}

public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public int Telefono { get; set; }
        public int Edad { get; set; }
    }


