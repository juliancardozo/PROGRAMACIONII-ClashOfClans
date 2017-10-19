﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Barbaro:ITropaNormal
    {

        public Aldea aldea { get; }
        public String nombre { get; }
        public Int32 nivel { get; }
        public Int32 velocidad { get; }
        public Int32 dano { get; }
        public Int32 espacio { get; }
        public Int32 elixirRojo { get; }

        public Barbaro(Aldea aldea) {
            this.nombre = "Barbaro";
            this.nivel = 1;
            this.velocidad = 50;
            this.dano = 8;
            this.espacio = 1;
            this.elixirRojo = 5;
        }

        public void Atacar()
        {
            Console.WriteLine("Ataca el barbaro.");
        }
    }
}
