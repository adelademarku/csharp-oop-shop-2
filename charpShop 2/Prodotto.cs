using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charpShop_2
{
    public class Prodotto  //ContenutoMultimediale

    {
        //// PROPRIETA' 

        private int codice;
        private string nome;
        private string descrizione;
        private double prezzo;
        private int iva;


        //Stato


        public Prodotto( string nome, string descrizione, double prezzo, int iva)
        {
            
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }



        // GETTERS

        public int GetCodice()
        {
            return this.codice;
        }

        public string GetNome()
        {
            return this.nome;
        }
      
        public string GetDescrizione()
        {
            return this.descrizione;
        }
        public double GetPrezzo()
        {
            return this.prezzo;
        }




       


        public void IvaProdotto(int iva)
        {

            if (iva != 4 && iva != 10 && iva != 22)
            {
                this.iva = iva;

            }
            else
            {
                Console.WriteLine("Non hai inserto un l'iva");
            }
        }




        private int SetMain()
        {
            Random rnd = new Random();
            int randumNumero = rnd.Next();
            return randumNumero;
        }

        private double SetPrezzoIva()
        {
            if (iva == 10)
            {
                this.prezzo = prezzo - (prezzo * 0.1);
            }
            else if (iva == 4)
            {
                return this.prezzo = prezzo - (prezzo * 0.04);
            }
            else if (iva == 22)
            {
                return this.prezzo = prezzo - (prezzo * 0.22);
            }
            return prezzo;

        }

        public static float ToSingle(double value)
        {
            return (float)value;
        }


        //Metodi di servizio 


        public void StampaProdotto()
        {
            Console.WriteLine("Codice: " + SetMain());
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Descrizione: " + descrizione);
            Console.WriteLine("Prezzo: " + prezzo + "£ ");
            Console.WriteLine("Iva: " + iva + " %");
            Console.WriteLine("Prezzo con iva: " + SetPrezzoIva() + "£ ");
        }







    }
}
