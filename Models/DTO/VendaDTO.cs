using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class VendaDTO
    {
        public int Id { get; set; }
        public string CarroPlaca { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorVenda { get; set; }
        public string ClienteDocumento { get; set; }
        public string FuncionarioDocumento { get; set; }
        public Pagamento Pagamento { get; set; }
    }
}