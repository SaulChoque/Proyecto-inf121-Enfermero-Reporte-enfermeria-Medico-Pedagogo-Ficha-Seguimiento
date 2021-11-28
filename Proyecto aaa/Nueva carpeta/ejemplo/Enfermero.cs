using System;
public class Enfermero : PTecnico, PSalud
{        
    public Enfermero():base(){}
    public void leer(){
        Console.WriteLine("\nLECTURA DATOS ENFERMERO: ");
        base.leer();
    }
    public void mostrar(){
        Console.WriteLine("\nDATOS ENFERMERO: ");
        base.mostrar();
    }
}
