using System;
using System.IO;
public class Enfermero : PTecnico, PSalud
{        
    public Enfermero():base(){}
public Enfermero(): base(){}


    public void leerEnfermero(){
        Console.WriteLine("\n------ Lectura de Datos Enfermero ------: ");
        base.leerTrabajador();
    }
    public void mostrar(){
        Console.WriteLine("\nDATOS ENFERMERO: ");
        base.mostrar();
    }
	public void escribirEnfermero(BinaryWriter escritor){
        base.escribir(escritor);
	}
	public void lectorEnfermero(BinaryReader lector){
		base.lector(lector);
	}		
}
