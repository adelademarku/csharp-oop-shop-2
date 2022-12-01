using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charpShop_2
{
    public class Acqua : Prodotto
    {
        //Proprietà
        /*attributo litri: per indicare quanti litri di acqua ci sono nella bottiglia di acqua
        attributo ph: che indica il livello di acidità dell’acqua (sola lettura)
        attributo sorgente: che indica la sorgente di provenienza dell’acqua (sola lettura)
        metodo bevi (double litriDaBere) che toglie dall’attributo litri una quantità pari a litriDaBere di acqua se presenti.
        metodo riempi(double litri) che riempie la bottiglia di acqua con tot litri di acqua, stando attenti a non riempirla troppo.
        metodo svuota() che rimuove tutta l’acqua dalla bottiglia.
        metodo stampaProdotto() che fa l’override del metodo di base StampaProdotto già dichiarato nella superclasse Prodotto (se non lo avete già fatto dichiaratelo anche nella classe prodotto è si occupa di stampare il “codice - nome”,l lo abbiamo chiamato NomeEsteso), per stampare oltre al codice e al nome dell’acqua, anche la sua sorgente, il ph e i litri contenuti.
        */
        private int litri;
        private int ph;
        private string sorgente;

    public Acqua (string nome, string descrizione, double prezzo, int iva) : base (nome,descrizione, prezzo, iva)
        {
            this.litri = litri;
            this.ph = ph;
        }


        public int GetLitri() 
        { return litri; 
        }

        public int GetPh()
        {
            return ph;
        }

        public string GetProvenienzaSorgente()
        {
            return sorgente;
        }



}
}
