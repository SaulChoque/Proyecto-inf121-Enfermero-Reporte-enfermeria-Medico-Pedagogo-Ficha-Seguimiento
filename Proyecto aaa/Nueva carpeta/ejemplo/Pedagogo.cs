using System;
public class Pedagogo: PTecnico
{
    private string especialidad;

    public Pedagogo(): base(){}

    public string Especialidad{get{return especialidad;}set{especialidad=value;}}
    
    public void leer(){
        Console.WriteLine("\nLECTURA DATOS PEDAGOGO");
        this.especialidad=Leer.Cadena();
        base.leer();
    }
    public void mostrar(){
        Console.WriteLine("\nDATOS PEDAGOGO");
        Console.WriteLine("Especialidad: "+especialidad);
        base.mostrar();
    }
}
