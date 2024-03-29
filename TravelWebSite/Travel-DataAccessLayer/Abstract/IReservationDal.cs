﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travels_EntityLayer.Concrete;

namespace Travel_DataAccessLayer.Abstract
{
    public interface IReservationDal:IGenericDal<Rezervation>
    {
        List<Rezervation> GetListWithReservationByWaitApproval(int Id);
        List<Rezervation> GetListWithReservationByAccepted(int Id);
        List<Rezervation> GetListWithReservationByPrevious(int Id);


    }
} 
