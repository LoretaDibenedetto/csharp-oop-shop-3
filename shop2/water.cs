﻿using shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace shop2
{
    public class water:Product 
    {
        private int liters;
        private int baleOfWater;
        private bool isSparklingWater;

     //costruttore

     public water( int liters, bool isSparklingWater, string nameProduct, string descriptionProduct, bool onSale, float price, int v) : base(nameProduct, descriptionProduct, onSale, price ) 
     { 
        
        this.liters = liters;
        baleOfWater = baleOfWater; 
        this.isSparklingWater = isSparklingWater;

      }

     //get set
     public int Liters
        {
            get { return liters; }set { liters = value; }
        }
     public int BaleOfWater
        {
            get { return baleOfWater; }set { baleOfWater = 6; }
        }

        //getters
        public bool Getsparkling()
        {
            return this.isSparklingWater;
        }

        //setters
        public bool Setsparkiling()
        {
            
            return isSparklingWater = false;
        }

        public string strrappresentation()
        {
         string strrappresentation = "Nome del prodotto:"+"  " + this.NameProduct + ", ";
            strrappresentation += "Descrizione:" +"  " + this.DescriptionProduct + ", ";
            strrappresentation += "Litri della bottiglia" + "  " + this.liters + ", ";
            strrappresentation += "E' frizzante?" + "  " +  this.isSparklingWater + ", ";
            strrappresentation += "Prezzo"+"  " + this.Price + ", "; 
            strrappresentation += "E' in sconto?" + "  " + this.GetOnSale() + ". ";
            return strrappresentation;
        }
        








    }
}
