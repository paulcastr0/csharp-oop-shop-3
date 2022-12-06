﻿// See https://aka.ms/new-console-template for more information

using CSharp_Shop_3;

Caramella goleador = new Caramella("Goleador", "Una buona caramella", 0.10, 22, "frutta", 30);
Caramella bubblegum = new Caramella("BubbleGum", "Gomma Americana", 0.15, 22, "amarena", 45);


Acqua BottigliaAcqua = new Acqua("Bottiglia D'acqua", "bottiglia da 1.5l", 1, 22, 1.5, -5, "Trentino alto adige", 0.8);
BottigliaAcqua.StampaProdotto();


Videogioco Pokemon = new Videogioco("Pokémon Scarlatto", "L'ultimo gioco dei Pokemon", 60.00, 22, "GameFreak");

Sacchetto_di_frutta sacchettoArance = new Sacchetto_di_frutta("Arance", "Un sacchetto di arance", 1.60, 4, 4, 1, "Arancia");

Prodotto lavatriceBosch = new Prodotto("Lavatrice Bosch LD2022", 150.00, 22);


Console.WriteLine(goleador.GetNumeroKcalorie());


List<Prodotto> scaffaliNegozio = new List<Prodotto>() { lavatriceBosch, goleador, Pokemon, sacchettoArance };


foreach (Prodotto articolo in scaffaliNegozio)
{


    switch (articolo)
    {
        case Caramella:
            Caramella caramella = (Caramella)articolo;
            Console.WriteLine(caramella.GetNumeroKcalorie());
            break;
        case Videogioco:
            Videogioco videogioco = (Videogioco)articolo;
            Console.WriteLine(videogioco.GetStudioDiSviluppo());
            break;
    }
    articolo.StampaProdotto();

}
