namespace OOP.Class;
using OOP.Interfaces;

public class JuegoDados{

    private IDadoInterface Dado1, Dado2;// nos dice que estos dados nuevos deben tener lo que nos pide la interface

    public JuegoDados(IDadoInterface D1, IDadoInterface D2){

        Dado1 = D1;
        Dado2 = D2;

    }

    public void Iniciar (){

        Dado1.Lanzar();
        Dado2.Lanzar();

    }

    private bool Evaluar (){

        return Dado1.MostrarNumero() == Dado2.MostrarNumero();


    }
    
    public string Finalizar(){

        if (Evaluar()){
            return "Ganaste";
        }
        return "Perdiste";

    }

}