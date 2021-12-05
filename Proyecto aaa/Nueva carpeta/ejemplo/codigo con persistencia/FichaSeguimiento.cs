using System;
using System.Collections.Generic;
using System.IO;
public class FichaSeguimiento
{
    private Refugiado refugiado;
    private Pedagogo pedagogo;
    private string fecha;
    List<(string, string, string)> areasAprendizajeL;
    private string[] areasAprendizaje=new string[30];
    private int nr;

    public FichaSeguimiento(){}
    public Refugiado Refugiado{get{return refugiado;}set{refugiado=value;}}
    public Pedagogo Pedagogo{get{return cuipedagogodador;}set{pedagogo=value;}}    
    public string Fecha{get{return fecha;}set{fecha=value;}}

    public void mostrar(){
        Console.WriteLine("\n------ Ficha Seguimiento ------");
        Console.WriteLine("Datos Refugiado: ");
        anciano.mostrarAnciano();
        Console.WriteLine("Datos pedagogo: ");
        anciano.mostrarAnciano();
        Console.WriteLine("Fecha: "+fecha);
        Console.WriteLine("--Areas aprendizaje");
        for (int i=0; i<nr; i++)
        {
            Console.WriteLine(areasAprendizaje[i]);
        }        

    }

    public void leer(){
        refugiado.leer();
        pedagogo.leer();
        Console.Write("Inserte Fecha => ");
        this.fecha=Leer.Cadena();
        do{
            string s1, s2, s3;
            Console.Write("\nInserte Area aprendizaje 1 => ");
            s1=Leer.Cadena();
            Console.WriteLine("\nInserte Area aprendizaje 2 => ");
            s2=Leer.Cadena();
            Console.WriteLine("\nInserte Area aprendizaje 3 => ");
            s3=Leer.Cadena();
            areasAprendizajeL.Add((s1+"//",s2+"//",s3));
            Console.WriteLine("Desea continuar añadiendo Areas?. s/n: ");
		}while(Console.ReadKey().KeyChar=='s');
        foreach (var lir in areasAprendizajeL)
        {
            areasAprendizaje[nr]=lir.ToString();
            nr=nr+1;
        }
    }
	public void escribir(BinaryWriter escritor){
        refugiado.escribir(escritor);
        pedagogo.escribir(escritor);
        escritor.Write(fecha);
        escritor.Write(nr);
        for(int i=0; i<nr; i++)
        {
            escritor.Write(areasAprendizaje[i]);
        }
	}
	public void lector(BinaryReader lector){
        refugiado.lector(lector);
        pedagogo.lector(lector);
        fecha=lector.ReadString();
        nr=lector.ReadInt32();
        for(int i=0; i<nr; i++)
        {
            areasAprendizaje[i]=lector.ReadString();
        }
	}	      
}
