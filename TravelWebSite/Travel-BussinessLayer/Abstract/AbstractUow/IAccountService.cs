﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travels_EntityLayer.Concrete;

namespace Travel_BussinessLayer.Abstract.AbstractUow
{
    public interface IAccountService:IGenericUowService<Account>
    {

    }
}