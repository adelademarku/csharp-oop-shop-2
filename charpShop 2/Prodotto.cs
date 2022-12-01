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


        public Prodotto( string nome,  double prezzo, int iva)
        {
            
            this.nome = nome;
            
            this.prezzo = prezzo;
            this.iva = iva;
        }

        public Prodotto(string nome,string descrizione, double prezzo, int iva)
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
            double prezzoIVA = (this.prezzo + (this.prezzo * this.iva) / 100);
            prezzoIVA = Math.Round(prezzoIVA, 2);
            return prezzoIVA;

        }


        public void SetPrezzo(double prezzo)
        {
            if (prezzo > 0)
            {
                this.prezzo = prezzo;
            }
            else
            {
                Console.WriteLine("Il prezzo non può avere un valore negativo!");
            }
        }

        public string GetNomeEsteso() 
        { 
            string codiceStringa = this.codice.ToString();
            codiceStringa = codiceStringa.PadLeft(8, '0');
            return codiceStringa + this.nome;
        }


        //Metodi di servizio 


        public virtual void StampaProdotto()
        {
            Console.WriteLine("Codice: " + SetMain());
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Il codice NomeEsteso è: " + this.GetNomeEsteso());
            Console.WriteLine("Descrizione: " + descrizione);
            Console.WriteLine("Prezzo: " + prezzo + "euro ");
            Console.WriteLine("Iva: " + iva + " %");
            Console.WriteLine("Prezzo con iva: " + SetPrezzoIva() + "euro ");
        }







    }
}
