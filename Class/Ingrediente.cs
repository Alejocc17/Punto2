using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Punto2.Class;
using Punto2.Interfaces;

public class Ingrediente : Pastel, IPastelInterface
    {
        protected string nombre="0";
    protected int cantidad;
    protected int precio;

    

    public Ingrediente(string nombre, int cantidad, int precio)
    {
        this.Nombre = nombre;
        this.Cantidad = cantidad;
        this.Precio = precio;
    }

    


    

    public string Nombre{get;set;}
    public int Cantidad{get;set;}
    public int Precio{get;set;}

    }
    


