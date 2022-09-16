using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Punto2.Class;
using Punto2.Interfaces;


public class Pastel : IPastelInterface
    {
        public void DatosPastel(){
        
        Console.WriteLine("Ingresa Nombre Pastel");
        var pas=Console.ReadLine();

        Console.WriteLine("Ingresa tamaño pastel");
        var tam=Console.ReadLine();
    }

        List<Ingrediente> ListaIngredientes = new List<Ingrediente>();

        public void AddI(Ingrediente ingrediente){
            if(ingrediente != null)
            {
                ListaIngredientes.Add(ingrediente);
            }

        }

        public string ListIngredientes()
        {
            string text = "Lista de Ingredientes:\n";
            foreach(Ingrediente ingrediente in ListaIngredientes){
                text += "nombre: " + ingrediente.Nombre+ "\n";
                //text += "cantidad: " + ingrediente.Cantidad+ "\n";
                //text += "precio: " + ingrediente.Precio+ "\n";
        }
        return text;
        }


        public int CantIngredientes(){
             Console.WriteLine("Cantidad de ingredientes:");
            int count = ListaIngredientes.Count;

            return count;
        }

        public int CalcularCosto(){
            Console.WriteLine("Costo del pastel:");
            int count = ListaIngredientes.Count;
            int prec = ListaIngredientes.Sum(x=>x.Precio);
            int toot=count*prec;
            
            return toot;
        }


    public void AggIngrediente(){
        
        int opcion = 0;
        do{
        Console.WriteLine("1.Agregar ingrediente"+
        "\n 2.Mostrar lista"+
        "\n 3.Salir");
        var data=Console.ReadLine();
        if(data != null )
        {
            opcion = int.Parse(data);
        }
        switch(opcion)
        {
            case 1:
            Console.WriteLine("Ingresa ingrediente");
            var inputNombre = Console.ReadLine();
            Console.WriteLine("Ingresa cantidad");
            var inputCantidad = Console.ReadLine();
            Console.WriteLine("Ingresa precio");
            var inputPrecio = Console.ReadLine();

            if(inputNombre != null && inputCantidad != null && inputPrecio != null)
            {
                AddI(new Ingrediente(
                    inputNombre.ToString(),
                    int.Parse(inputCantidad),
                    int.Parse(inputPrecio)

                ));
            }
            break;

            case 2:
            Console.WriteLine(ListIngredientes());
            Console.WriteLine(CantIngredientes());
            Console.WriteLine(CalcularCosto());
            break;

            case 3:
            opcion = 3;
            break;
            default:
            Console.WriteLine("Elije una opción");
            break;

        }
       }
        while(opcion != 3);
    }



    
    

    
    }
