using System;
using System.Collections.Generic;
using System.IO;
public class ReporteEnfermeria
{
    private Refugiado refugiado;
    private Enfermero enfermero;
    private string fecha;
    List<(string, string, string)> reporte;
    private string[] repor=new string[30];
    private int nr;

    //constructor por defecto
    public ReporteEnfermeria(){
        this.refugiado=new Refugiado();
        this.enfermero=new Enfermero();
        this.fecha="";
        this.reporte=new List<(string, string, string)>();
        this.repor=new string[30];
        this.nr=0;
    }
        public Refugiado Refugiado{get{return refugiado;}set{refugiado=value;}}
        public Enfermero Enfermero{get{return enfermero;}set{enfermero=value;}}    
        public string Fecha{get{return fecha;}set{fecha=value;}}

        public void leer(){

            refugiado.leer();
            enfermero.leerEnfermero();
            Console.Write("Inserte Fecha => ");
            this.fecha=Leer.Cadena();
            do{
                string hora="";
                string procedimiento="";    
                string descripcionSintomas="";
                Console.Write("\nInserte Hora => ");
                hora=Leer.Cadena();
                Console.WriteLine("\nEscriba el procedimiento");
                procedimiento=Leer.Cadena();
                Console.WriteLine("\nDescriba los sintomas");
                descripcionSintomas=Leer.Cadena();
                reporte.Add((hora+"//",procedimiento+"//",descripcionSintomas));
                Console.WriteLine("Desea continuar añadiendo Reportes?. s/n: ");
		    }while(Console.ReadKey().KeyChar=='s');
            foreach (var lir in reporte)
            {
                repor[nr]=lir.ToString();
                nr=nr+1;
            }

        }
        public void mostrar(){
            Console.WriteLine("Nombre paciente"+"\tNombre enfermero(a)"+"\tfecha");
            Console.WriteLine(refugiado.Nombre+"\t"+refugiado.Nombre+"\t"+fecha+"\t");
            Console.WriteLine("Hora // "+"Procedimiento // "+"Sintomas");
            for (int i=0; i<nr; i++)
            {
                Console.WriteLine(repor[i]);
            }

        }     
	public void escribirReporteEnfermeria(BinaryWriter escritor){

        refugiado.escribir(escritor);
        enfermero.escribir(escritor);
        escritor.Write(fecha);
        escritor.Write(nr);
        for(int i=0; i<nr; i++)
        {
            escritor.Write(repor[i]);
        }
	}
	public void lectorReporteEnfermeria(BinaryReader lector){
        refugiado.lector(lector);
        enfermero.lectorEnfermero(lector);
        fecha=lector.ReadString();
        nr=lector.ReadInt32();
        for(int i=0; i<nr; i++)
        {
            repor[i]=lector.ReadString();
        }
	}	  
}
