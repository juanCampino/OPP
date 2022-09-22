namespace OOP.Class;
using OOP.Interfaces;// en este lugar voy a utilizar lo que este en esta interface

public abstract class Dado : IDadoInterface{// aqui estamos obligando a que la clase tenga los metodos de la interface, o de donde las este heredando

    protected int valor;
    protected Random random;

    public Dado(){
        random = new Random();
    }

    public void Lanzar(){
        valor = random.Next(1, 7); // los limites el primero lo toma y el segundo no por lo que se debe colocar 1 mas

    }
    public int MostrarNumero(){

        return 1;

    }

}