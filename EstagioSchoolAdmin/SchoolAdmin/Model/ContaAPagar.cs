using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Model
{
    public class ContaAPagar
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime Vencimento { get; set; }
        public Decimal Valor { get; set; }
        public Decimal ValorPago { get; set; }
        public OrigemContaAPagar Origem { get; set; }

        public ContaAPagar()
        {
            Id = 0;
            DataLancamento = DateTime.Now;
            ValorPago = 0;
        }
    }
}
