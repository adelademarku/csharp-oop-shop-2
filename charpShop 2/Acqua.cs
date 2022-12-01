using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Proprietà
/*attributo litri: per indicare quanti litri di acqua ci sono nella bottiglia di acqua
attributo ph: che indica il livello di acidità dell’acqua (sola lettura)
attributo sorgente: che indica la sorgente di provenienza dell’acqua (sola lettura)
metodo bevi (double litriDaBere) che toglie dall’attributo litri una quantità pari a litriDaBere di acqua se presenti.
metodo riempi(double litri) che riempie la bottiglia di acqua con tot litri di acqua, stando attenti a non riempirla troppo.
metodo svuota() che rimuove tutta l’acqua dalla bottiglia.
metodo stampaProdotto() che fa l’override del metodo di base StampaProdotto già dichiarato nella superclasse Prodotto 
(se non lo avete già fatto dichiaratelo anche nella classe prodotto è si occupa di stampare il “codice - nome”,l lo abbiamo chiamato NomeEsteso), 
per stampare oltre al codice e al nome dell’acqua, anche la sua sorgente, il ph e i litri contenuti.
*/


namespace charpShop_2
{

    public class Acqua : Prodotto
    {
        
        private double ph;
        private string sorgente;
        private int capacitaMassimalitri;
        private int contenutolitri;
        private bool naturale;
    public Acqua (string nome,double ph, int capacitaMassimalitri, bool naturale, double prezzo, int iva) : base (nome, prezzo, iva)
        {
            
            this.ph = ph;
            this.capacitaMassimalitri = capacitaMassimalitri;
            this.naturale = naturale;
           
        }


        //getters
        

        public double GetPh()
        {
            return ph;
        }

        public string GetProvenienzaSorgente()
        {
            return sorgente;
        }

        public int GetCapacitaMassimalitri()
        {
            return capacitaMassimalitri;
        }
        public int GetContenutoLitri()
        {
            return contenutolitri;
        }

        public bool GetTipo()
        {
            return this.naturale;
        }

      


        //Metodi

        public void SetTipo()
        {
            if (naturale = true)
            {
                Console.WriteLine("Naturale");
            } else { Console.WriteLine("Frizzante"); }
        }


        public int ContenitoreDelAcqua()
        {
            this.contenutolitri = capacitaMassimalitri;
            return contenutolitri;
        }
        //riempi 

        public int RiempiContenitoreDelAcqua(int litri)
        {
            if (contenutolitri + litri > capacitaMassimalitri)
            {
                contenutolitri = capacitaMassimalitri;
            }
            else
            {
                this.contenutolitri = this.contenutolitri + litri;
            }

            return contenutolitri;
        }

        //bevi

        public int SvuotaMentreBevi (int litri)
        {
            if (contenutolitri - litri > 0)
            {
                contenutolitri = 0;
            } else
            {
                this.contenutolitri = this.contenutolitri - litri;
            }
            return contenutolitri;
        }

        //svuota tutto

        public int SvuotaTuttalAcqua (int litri)
        {
            this.contenutolitri = contenutolitri - litri;
            return contenutolitri;
        }

        //Metodo pubblico

        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("Ph. :" + ph);
            Console.WriteLine("Litri attuali :" + contenutolitri);
            Console.WriteLine("Litri  :" + capacitaMassimalitri);
            Console.WriteLine(GetTipo());
        }



    }
}
