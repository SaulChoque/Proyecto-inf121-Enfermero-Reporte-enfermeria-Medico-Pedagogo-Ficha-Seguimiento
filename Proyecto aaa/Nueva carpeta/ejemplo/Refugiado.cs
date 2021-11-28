using System;
using System.Collections.Generic;
using System.Text;


public class Refugiado:Persona
    {
        private int edad;
        //Constructor sin argumentos
        public Refugiado():base() 
        {
            this.edad = 15;
        }
        //Getters Setters
        public int Edad { get => edad; set => edad = value; }
        //Leer Mostrar
        public void leer() 
        {
            Console.WriteLine("LEER-REFUGIADO");
            base.leer();
            Console.Write("Ingrese edad: ");
            this.edad = int.Parse(Console.ReadLine());
        }
        public void mostrar() 
        {
            Console.WriteLine("MOSTRAR-REFUGIADO");
            base.mostrar();
            Console.WriteLine("Edad: "+this.edad);
        }
    }
