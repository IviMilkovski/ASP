﻿using ProjekatASP.Application.DataTransfer.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.Application.Email
{
    public interface IEmailSender
    {
        void SendEmail(SendEmailDto dto);
    }
}
