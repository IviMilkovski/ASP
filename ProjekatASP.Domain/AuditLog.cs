﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.Domain
{
    public class AuditLog
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Actor { get; set; }
        public string UseCaseName { get; set; }
       
        public string Data { get; set; }
    }
}
