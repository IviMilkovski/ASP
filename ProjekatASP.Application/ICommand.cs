﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.Application
{
    public interface ICommand<TRequest> : IUseCase
    {
     void Execute(TRequest request);

    }
}
