using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoClases.Clases;
class Masajista : Persona {
    public int añosDeExp { get; set; }
    public string titulacion { get; set; }

    public Masajista (string nombre, int id, int edad, string ciudadOrigen, int añosDeExp,string titulacion): base (nombre,id,edad,ciudadOrigen){
        this.aañosDeExp = añosDeExp;
        this.titulacion = titulacion;
    }
}