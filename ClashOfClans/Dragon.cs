﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Dragon:ITropaNormal
    {
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }

        public Dragon()
        {
            this.nombre = "Dragón";
            this.nivel = 1;
            this.velocidad = 40;
            this.dano = 35;
            this.espacio = 1;
        }
        public void Atacar()
        {
            Console.WriteLine("Ataca el dragón.");
        }
    }
}
