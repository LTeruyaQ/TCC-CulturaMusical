using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultura_Musical.Database.Model
{
    class FluxoDeCaixa
    {
        public string tipo_operacao { get; set; }
        public DateTime data_pagamento { get; set; }
        public decimal valor_pago { get; set; }
    }
}
