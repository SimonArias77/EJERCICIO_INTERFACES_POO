using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio_interfaces_poo.Models;

public class Coder: Storage, ICoder
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }

    public Coder(string nombre, string apellido, string email, string telefono)
    {
        Id = Guid.NewGuid();
        Nombre = nombre;
        Apellido = apellido;
        Email = email;
        Telefono = telefono;
    }

    public void AddCoder(Coder coder)
    {  
        ListCoders.Add(coder);
    }

    public void DeleteCoder(Coder coder)
    {  
        ListCoders.Remove(coder);
    }

    public void ShowCoder(Coder coder)
    {
        Console.WriteLine(coder);
    }

    public void UpdateCoder(Coder coder)
    {

    }

    public override string ToString()
    {
        return base.ToString();
    }
}
