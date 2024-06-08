using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Venda
    {
        public int Id { get; set; }
        public Carro Carro { get; set; }
        public DateTime DataVenda { get; set; }
        public Decimal ValorVenda { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public Pagamento Pagamento { get; set; }

        public Venda()
        {

        }
        public Venda(VendaDTO DTO)
        {
            Carro = new Carro { Placa = DTO.CarroPlaca };
            DataVenda = DTO.DataVenda;
            ValorVenda = DTO.ValorVenda;
            Cliente = new Cliente { Documento = DTO.ClienteDocumento };
            Funcionario = new Funcionario { Documento = DTO.FuncionarioDocumento };
            Pagamento = DTO.Pagamento;
        }
    }
}
