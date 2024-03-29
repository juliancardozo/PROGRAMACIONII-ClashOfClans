﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans
{

    /// <summary>
    /// Si en el metodo almacenar se supera la capacidad maxima, se iguala y el metodo devuelve un Int32 indicando cuanto se almaceno.
    /// </summary>
    /// 

    public class AlmacenOro :IAlmacen
    {

        public String nombre { get; }
        public Int32 vida { get; }
        public Int32 nivel { get; }
        public Int32 dano { get; }
        public Aldea aldea { get; set; }
        public Int32 capacidadMaxima { get;set; }
        public Int32 disponible { get;set; }
        public Int32 cantidadMaxima { get; set; }


        public AlmacenOro(Aldea aldea)
        {
            this.aldea = aldea;
            nombre = "Almacen Oro";
            vida = 1000;
            nivel = 1;
            capacidadMaxima = 2500;
            disponible = 0;
            cantidadMaxima = 4;
        }

        public Int32 AlmacenarOro(Int32 oro)
        {
            Int32 cantidadAntes = disponible;
            disponible += oro;
            if(disponible > capacidadMaxima)
            {
                disponible = capacidadMaxima;
            }

            return (disponible - cantidadAntes);
        }

        public void ExtraerOro(Int32 oro)
        {
            disponible -= oro;
        }
    }
}
