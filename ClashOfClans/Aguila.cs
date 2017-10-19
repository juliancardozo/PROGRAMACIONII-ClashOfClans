﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class Aguila:IDefensivo
    {
        public String nombre { get; }

        public Int32 vida { get; }

        public Int32 nivel { get; }

        public Int32 dano { get; }

        public Aldea aldea { get; set; }
        public Int32 cantidadMaxima { get; set; }
        public Aguila(Aldea aldea)
        {
            this.aldea = aldea;
            nombre = "Äguila";
            vida = 1000;
            nivel = 1;
            dano = 150;
            cantidadMaxima = 0;
        }

        public void AtacarTerrestre()
        {
            Console.WriteLine("Estoy atacando");
        }
    }

}
