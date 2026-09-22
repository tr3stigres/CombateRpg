class Program
{
    public static void Main()
    {

        VidaRpg personajePrincipal = new VidaRpg("Ada", 100, 25);
        VidaRpg personajeSecundario = new VidaRpg("Bruno", 80, 20);


        int contador = 1;
        Console.WriteLine(personajePrincipal + " vs " + personajeSecundario);
        while (personajePrincipal.EstaVivo() && personajeSecundario.EstaVivo())
        {
            personajePrincipal.Atacar(personajeSecundario);        
            if (personajeSecundario.EstaVivo())
                personajeSecundario.Atacar(personajePrincipal);
            Console.WriteLine(contador + ".- " + personajePrincipal + " vs " + personajeSecundario);
            contador++;
        };

        if (personajePrincipal.VidaActual > 0)
            Console.WriteLine("El ganador es: " + personajePrincipal.Nombre);
        else
            Console.WriteLine("El ganador es: " + personajeSecundario.Nombre);

    }

}
