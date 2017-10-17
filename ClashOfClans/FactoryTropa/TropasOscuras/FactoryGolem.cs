﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class FactoryGolem : IFactoryTropaOscura
    {
    
        public ITropa Instanciar(Aldea aldea)
        {
            return new Golem(aldea);
        }
    }
}
