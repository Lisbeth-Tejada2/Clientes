using Clientes.Models;
using Clientes.DAL;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;

namespace Clientes.BLL
{
    public class ClientesBLL
    {
        private readonly ClientesContext _contexto;

        public ClientesBLL(ClientesContext contexto)
        {
            _contexto = contexto;
        }
        public bool Existe(int ClientesId)
        {
            return _contexto.clientes.Any(s => s.ClienteId == ClientesId);
        }
        private bool Insertar(Clientess Cliente)
        {
            _contexto.clientes.Add(Cliente);
            int cantidad = _contexto.SaveChanges();
            return cantidad > 0;
        }
        public bool Modificar(Clientess cliente)
        {
            _contexto.Update(cliente);
            int cantidad = _contexto.SaveChanges();
            return cantidad > 0; 
        }
        public bool Guardar(Clientess cliente)
        {
            if (!Existe(cliente.ClienteId))
                return Insertar(cliente);
            else
                return Modificar(cliente);
        }
        public bool Eliminar(Clientess clientes)
        {
            _contexto.clientes.Remove(clientes);
            int cantidad = _contexto.SaveChanges();
            return cantidad > 0;
        }
        public Clientess? Buscar(int ClientesId)
        {
            return _contexto.clientes
                .AsNoTracking()
                .FirstOrDefault(c => c.ClienteId == ClientesId);
        }
        public List<Clientess> GetList(Expression<Func<Clientess, bool>> Criterio)
        {
            return _contexto.clientes
                .Where(Criterio)
                .AsNoTracking()
                .ToList();
        }

    }
}
