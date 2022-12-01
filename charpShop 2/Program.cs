// See https://aka.ms/new-console-template for more information
using charpShop_2;
using System.Runtime.ConstrainedExecution;

//creare una classe Prodotto generica per gestire un generico prodotto dello Shop, vi chiedo ora di essere più specifichi
//e di creare le sottoclassi opportune di alcuni prodotti che potremmo identificare nel nostro shop.
//In particolare immaginiamo che nel nostro shop possiamo commerciare le seguenti tipologie di prodotto:
//Acqua(massimo 1.5L)
//Sacchetto di Frutta a pezzi (al massimo puo contenere 5 pezzi di frutta)
//Elettrodomestico
//Cibo in Scatola (al massimo può contenere 300g di peso su una scatola)
//Per ognuno dei seguenti prodotti più specifici vi si chiede di identificare quali potrebbero essere i loro attributi e
//metodi che eventualmente gli riguardano, ereditando i metodi e gli attributi generici dalla classe Prodotto creata nell’esercizio precedente.


Acqua Levissima = new Acqua("Levissima",7.9,1500,true,0.88,22 );

Levissima.StampaProdotto();

SacchettiDiFrutta Misto = new SacchettiDiFrutta("Misto", 3.5, 4, string[]frutta= {"mela","pera","pesca"};);

Misto.StampaProdotto();