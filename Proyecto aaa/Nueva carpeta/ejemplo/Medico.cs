using System;
public class Medico: PTecnico, PSalud
{
    private string especialidad;

    public Medico(): base(){especialidad="Fisioterapia";}

    public string Especialidad{get{return especialidad;}set{especialidad=value;}}

    public void leer(){
        Console.WriteLine("\nLECTURA DATOS MEDICO");
        base.leer();
        Console.WriteLine("Inserte Especialidad: ");
        especialidad=Leer.Cadena();
    }
    public void mostrar(){
        Console.WriteLine("\nDATOS MEDICO");
        base.mostrar();
        Console.WriteLine("Especialidad: "+especialidad);
    }    



}