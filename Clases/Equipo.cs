using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoClases.Clases;
class Equipo {
    public string nombre { get; set; }
    public List <string> propietarios { get; set; }
    public List<Jugador> jugadores { get; set; }
    public List<Masajista> masajistas { get; set; }
    public List<Entrenador> entrenadores { get; set; }

    public Equipo (string nombre){
        this.nombre = nombre;
        this.propietarios = new List<string>();
        this.jugadores = new List<Jugador>();
        this.masajistas = new List<Masajista>();
        this.entrenadores = new List<Entrenador>();
    }
    public Equipo(){
        this.propietarios = new List<string>();
        this.jugadores = new List<Jugador>();
        this.masajistas = new List<Masajista>();
        this.entrenadores = new List<Entrenador>();
    }

    public Equipo agregarEquipo(){

        Equipo equipo = new Equipo();

        Console.Write("Ingrese el nombre del equipo :");
        equipo.nombre = Console.ReadLine();

        return equipo;


    }


}