﻿using System;

namespace CircConCentroFer2023.Entidades
{
    public class Punto
    {
        public int CoordX { get; set; }
        public int CoordY { get; set; }
        public Punto(int x, int y)
        {
            CoordX = x;
            CoordY = y;
        }
        public override string ToString()
        {
            return $"({CoordX},{CoordY})";//(1,1)
        }

        public double GetDistanciaOtroPunto(Punto otroPunto)
        {
            return Math.Sqrt(Math.Pow(this.CoordX-otroPunto.CoordX,2)+
                Math.Pow(this.CoordY-otroPunto.CoordY,2));
           
        }
    }
}
