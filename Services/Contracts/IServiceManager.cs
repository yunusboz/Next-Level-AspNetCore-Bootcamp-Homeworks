﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IServiceManager
    {
        public IEmployeeService EmployeeService { get;}
        public IOrderService OrderService { get;}
    }
}
