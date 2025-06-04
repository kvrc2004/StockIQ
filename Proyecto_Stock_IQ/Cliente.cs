using System.Collections.Generic;

public class Cliente
{
    public string Nombre { get; set; }
    public string CorreoElectronico { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }

    public Cliente(string nombre, string correo, string telefono, string direccion)
    {
        Nombre = nombre;
        CorreoElectronico = correo;
        Telefono = telefono;
        Direccion = direccion;
    }

    public static List<Cliente> listaClientes = new List<Cliente>();

    public List<Cliente> ObtenerClientes()
    {
        return listaClientes;
    }

    public static void CargarClientesPorDefecto()
    {
        if (listaClientes.Count == 0)
        {
            listaClientes.Add(new Cliente("Ana Gómez", "ana@gmail.com", "123456789", "Calle 1 #23-45"));
            listaClientes.Add(new Cliente("Carlos Ruiz", "carlos@gmail.com", "987654321", "Carrera 7 #56-78"));
            listaClientes.Add(new Cliente("María López", "maria@gmail.com", "555123456", "Avenida 3 #12-34"));
        }
    }

}

