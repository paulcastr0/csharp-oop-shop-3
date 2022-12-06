using CSharp_Shop_3;
using CSharp_Shop_3.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using CSharp_Shop_3.CustomException;

namespace CSharp_Shop_3
{
    public class Acqua : Prodotto
    {
        private double litri;
        private double ph;
        private string sorgente;

        public Acqua(string nome, string descrizione, double litri, double ph,
            string sorgente, double prezzo, double iva) : base(nome, descrizione, prezzo, iva)
        {
            this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;
        }

        //--------------------------------- Metodi Get ---------------------------------

        public double GetLitri()
        {
            return this.litri;
        }
        public double GetpH()
        {
            return this.ph;
        }
        public string GetSorgente()
        {
            return this.sorgente;
        }
        //--------------------------------- Metodi set ---------------------------------

        public void SetLitri(double litri)
        {
            this.litri = litri;
        }
        public void SetpH(double pH)
        {
            if (this.ph < 0 || this.ph > 14)
            {
                throw new PhLimit("Il pH di un liquido non può essere maggiore di 14 o minore di 0;");
            }
            else { this.ph = ph; }
        }
        public void SetSorgente(string sorgente)
        {
            if (!string.IsNullOrEmpty(sorgente))
            {
                throw new();
            }
            this.sorgente = sorgente;
        }

        //--------------------------------- Metodi Acqua ---------------------------------

        public void svuotaBottiglia()
        {
            this.litri = 0;
        }

        public void riempiBottiglia()
        {
            this.litri = 1.5;
        }

        public void beviAcqua()
        {
            this.litri = this.litri - 0.3;
        }

        public void refillBottigliaUtente(double acquaInserita)
        {
            if (acquaInserita < 0)
            {
                Console.WriteLine("Non puoi piu rimuovere un valore negativo di acqua, tonto!");
            }
            else if (acquaInserita > 0 && acquaInserita <= 1.5 && this.litri + acquaInserita < 1.5)
            {
                this.litri += acquaInserita;
            }
            else
            {
                Console.WriteLine("Hai inserito troppa acqua!");
            }
        }

        // Override Metodo stampa
        public override void StampaProdotto()
        {
            Console.WriteLine("------ " + base.GetName() + " -----");
            Console.WriteLine();
            Console.WriteLine("Descrizione:" + base.GetDescription());
            Console.WriteLine("Capienza:" + this.litri + "l");
            Console.WriteLine("pH: " + this.ph);
            Console.WriteLine("Codice prodotto:" + base.GetCodice());
            Console.WriteLine("L'IVA è: " + base.GetIVA() + "%");
            Console.WriteLine("Il prezzo è: " + base.GetPrezzo() + "euro");
            Console.WriteLine("Il codice NomeEsteso è: " + this.GetNomeEsteso());
            Console.WriteLine();
        }

    }
}