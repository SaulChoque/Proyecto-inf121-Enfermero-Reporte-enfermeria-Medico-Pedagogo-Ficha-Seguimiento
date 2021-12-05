using System;
using System.IO;
public class Medico: PTecnico, PSalud
{
    private string especialidad;
    public Medico():base(){this.especialidad="Pediatra";}

   
    public void leerMedico(){
        Console.WriteLine("\n------ Lectura de Datos Medico ------: ");
        especialidad=Console.ReadLine();
        base.leerTrabajador();

    }
    public void mostrarMedico(){
        base.mostrarTrabajador();
    }
	public void escribirMedico(BinaryWriter escritor){
        base.escribir(escritor);
	}
	public void lectorMedico(BinaryReader lector){
		base.lector(lector);
	}		    
        
}
