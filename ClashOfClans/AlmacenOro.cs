﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class AlmacenOro:IAlmacen
    {
        private String nom;
        public String nombre { get { return nom; } }
        private Int32 vid;
        public Int32 vida { get { return vid; } }
        private Int32 niv;
        public Int32 nivel { get { return niv; } }
        private Int32 capMax;
        public Int32 capacidadMaxima { get { return capMax; } set { value = capMax; } }
        private Int32 capDis;
        public Int32 capacidadDisponible { get { return capDis; } set {value= capDis; } }

        public void AlmacenarOro(Int32 oro)
        {
            capacidadDisponible -= oro;
        }

        public void ExtraerOro(Int32 oro)
        {
            capacidadDisponible += oro;
        }
    }
}
