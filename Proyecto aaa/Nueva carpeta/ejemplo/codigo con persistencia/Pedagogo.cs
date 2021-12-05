using System;
using System.IO;
public class Pedagogo: PTecnico
{
    private string especialidad;

    public Pedagogo(): base(){}

    public string Especialidad{get{return especialidad;}set{especialidad=value;}}
    
    public void leer(){
        Console.WriteLine("\n------ Lectura de Datos Pedagogo ------");
        Console.WriteLine("Inserte la especialidad del Pedagogo: ");
        this.especialidad=Leer.Cadena();
        base.leer();
    }
    public void mostrar(){
        base.mostrar();
        Console.Write("\t"+especialidad);
    }

	public void escribir(BinaryWriter escritor){
        base.escribir(escritor);
		escritor.Write(especialidad);
	}
	public void lector(BinaryReader lector){
		base.lector(lector);
        especialidad=lector.ReadString();
	}	
}
