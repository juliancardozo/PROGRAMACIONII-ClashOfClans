﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class FactoryTesla: IFactoryDefensivo
    {
    
        public IDefensivo Instanciar(Aldea aldea)
        {
            return new Tesla(aldea);
        }
    }
}
