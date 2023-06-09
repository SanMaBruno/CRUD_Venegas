using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgnacioVenegas_MVC.Controladores
{
    public class ClienteControlador
    {
        private ClienteDatos clienteDatos = new ClienteDatos();

        public List<Cliente> ObtenerClientes()
        {
            return clienteDatos.ObtenerClientes();
        }

        public void AgregarCliente(Cliente cliente)
        {
            clienteDatos.AgregarCliente(cliente);
        }

        public void EliminarCliente(int id)
        {
            clienteDatos.EliminarCliente(id);
        }
    }

}
