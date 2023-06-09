﻿using shop2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace shop2
{
    public class Water:Product 
    {
       static private double litrersForGallons = 3.785;
        private float maxCapacity;
        private int numberBottle;
        private float liters;
        private int baleOfWater;
        private bool isSparklingWater;
        private float pH;

     //costruttore

     public Water(float maxCapacity, float initialLiters,int numberBottle, bool isSparklingWater,float pH, string nameProduct, string descriptionProduct, bool onSale, float price, string categoryName) : base(nameProduct, descriptionProduct, onSale, price, categoryName ) 
     {
        this.maxCapacity = maxCapacity;
        this.numberBottle = numberBottle;
            this.liters = initialLiters;
        
            if(pH == 0|| pH < 0)
            {
                throw new Exception("non va bene bro");
            }
            
                this.pH = pH;
           
            baleOfWater = baleOfWater = 6; 
        this.isSparklingWater = isSparklingWater;
          
            
      }

     //get set

     public int Numberbottle
        {
            get { return numberBottle; }
            set { this.numberBottle = value;}
        }
     public float Liters
        {
            get { return liters; }set { liters = value; }
        }
     public int BaleOfWater
        {
            get { return baleOfWater; }
        }

        //getters
        public static double GetConvertGallions()
        {
            return litrersForGallons;
        }
        public bool Getsparkling()
        {
            return this.isSparklingWater;
        }
        public float GetpH()
        {
            return this.pH;
        }
        public float GetMaxCapacity()
        {
            return this.maxCapacity;
        }
        //setters
        public bool Setsparkiling()
        {
            
            return isSparklingWater = false;
        }



        //methods
        public void drink(float litersToDrink)
        {
            if(litersToDrink < this.maxCapacity && litersToDrink < liters)
            { 
            
            this.liters = this.liters - litersToDrink;
            Console.WriteLine("hai bevuto: " +  litersToDrink +" litro" + " ora ne rimangono " + this.liters);

            }
            else
            {
               // liters = 0;
                throw new Exception("non puoi bere cosi tanto");
                
            }
        }

        public  double ConvertInGallons(double liters)
        {
            const double litrersForGallons = 3.785;
           
            return liters / litrersForGallons;
        }







        public void Fill(float litersToPutIntoBottle)
        {
            if ((litersToPutIntoBottle + liters) <= this.maxCapacity)
            {
                this.liters += litersToPutIntoBottle;
                Console.WriteLine("Hai aggiunto: " + litersToPutIntoBottle + "L" + " ora ci sono " + this.liters);

            }
            else if(litersToPutIntoBottle > this.maxCapacity)
            {
                
                liters = maxCapacity;
                throw new Exception("stai riempiendo troppo l'acqua fratello");
            }
        }

        public override string ToString()
        {
            string strrappresentation = "Nome del prodotto:"+"  " + this.NameProduct + "\n ";
            strrappresentation += "Descrizione:" +"  " + this.DescriptionProduct + "\n ";
            strrappresentation += "Litri della bottiglia" + "  " + this.liters + "\n ";
            strrappresentation += "E' frizzante?" + "  " +  this.isSparklingWater + "\n ";
            strrappresentation += "ph: " + "  " + this.pH + "\n ";
            strrappresentation += "Prezzo"+"  " + this.Price + "\n "; 
            strrappresentation += "E' in sconto?" + "  " + this.GetOnSale() + ". ";
            return strrappresentation;
        }
        
        
        
        








    }
}
