﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin.Model
{
    public class StatusPagamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public StatusPagamento()
        {
            Id = 0;
        }
    }
}
