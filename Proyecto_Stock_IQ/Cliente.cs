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

    private List<Cliente> listaClientes = new List<Cliente>();

    public List<Cliente> ObtenerClientes()
    {
        return listaClientes;
    }

}

