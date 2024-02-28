﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travels_EntityLayer.Concrete;

namespace Travel_DataAccessLayer.Abstract
{
    public interface IGuideDal:IGenericDal<Guide>
    {
        void ChangeToTrueByGuide(int Id);
        void ChangeToFalseByGuide(int Id);
    }
}
