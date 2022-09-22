using OOP.Class;

DadoSeisCaras Dado1 = new DadoSeisCaras();
DadoSeisCaras Dado2 = new DadoSeisCaras();

JuegoDados Juego = new JuegoDados(Dado1, Dado2);

Juego.Iniciar();
Console.WriteLine(Juego.Finalizar());