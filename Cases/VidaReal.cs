using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDI.Cases
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
    }

    public interface ICliente
    {
        public int ClienteId { get; set; }
        public string nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
    }

    public interface IClienteRepository
    {
        void AdcionarCliente(Cliente cliente);
    }

    public class ClienteRepository : IClienteRepository
    {
        public void AdcionarCliente(Cliente cliente)
        {
            //
        }
    }

    public interface IClienteServices
    {
        void AdcionarCliente(Cliente cliente);
    }

    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteServices(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void AdcionarCliente(Cliente cliente)
        {
            _clienteRepository.AdcionarCliente(cliente);
        }
    }

}
