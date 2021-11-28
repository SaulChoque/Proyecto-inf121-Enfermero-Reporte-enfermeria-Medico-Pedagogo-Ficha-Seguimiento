using System;
using System.Collections.Generic;
public class ReporteEnfermeria
{
    private Refugiado refugiado;
    private Enfermero enfermero;
    private string fecha;
    private string hora;
    private string procedimiento;    
    private string descripcionSintomas;

    //constructor por defecto
    public ReporteEnfermeria(){
        this.refugiado=new Refugiado();
        this.enfermero=new Enfermero();
        this.fecha="28/11/2020";
        this.hora="20:00";
        this.procedimiento= "Administracion de ibuprofeno";
        this.descripcionSintomas= "Fiebre y malestares gastricos por parte del paciente";
    }
        public Refugiado Refugiado{get{return refugiado;}set{refugiado=value;}}
        public Enfermero Enfermero{get{return enfermero;}set{enfermero=value;}}    
        public string Fecha{get{return fecha;}set{fecha=value;}}
        public string Hora{get{return hora;}set{hora=value;}}
        public string Procedimiento{get{return procedimiento;}set{procedimiento=value;}}
        public string DescripcionSintomas{get{return descripcionSintomas;}set{descripcionSintomas=value;}} 

        public void leer(){
            Console.WriteLine("\nLECTURA REPORTE ENFERMERIA");
            Console.WriteLine("Inserte datos refugiado");
            refugiado.leer();
            Console.WriteLine("Inserte datos enfermer@");
            enfermero.leer();
            Console.Write("Inserte Fecha => ");
            this.fecha=Leer.Cadena();
            Console.Write("\nInserte Hora => ");
            this.hora=Leer.Cadena();
            Console.WriteLine("\nEscriba el procedimiento");
            this.procedimiento=Leer.Cadena();
            Console.WriteLine("\nDescriba los sintomas");
            this.descripcionSintomas=Leer.Cadena();
        }
        public void mostrar(){
            Console.WriteLine(refugiado.Nombre+"\t"+enfermero.Nombre+"\t"+fecha+"\t"+hora);
            Console.WriteLine("Procedimiento: "+procedimiento);
            Console.WriteLine("Descripcion de los sintomas: "+descripcionSintomas);
        }       

}
