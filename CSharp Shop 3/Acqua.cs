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
        //PROPRIETA o ATTRIBUTI
        private double litri;
        private double ph;
        private string sorgente;
        private double litriDaBere;
        private double bottiglia;
        private double litriMessi;

        //COSTRUTTORE
        public Acqua(string name, string description, double prezzo, double IVA, double litri, double ph, string sorgente, double litriMessi) : base(name, description, prezzo, IVA)
        {
            this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;
            this.litriDaBere = litriDaBere;
            this.bottiglia = bottiglia;
            this.litriMessi = litriMessi;
        }

        //GETTERs
        public double GetLitri()
        {
            return litri;
        }
        public double GetPh()
        {
            return ph;
        }
        public string GetSorgente()
        {
            return sorgente;
        }
        public double GetLitriDaBere()
        {
            return litriDaBere;
        }
        public double GetBottiglia()
        {
            return bottiglia;
        }

        //SETTERs
        public double SetLitri()
        {
            return this.litri;
        }
        public double SetLitriDaBere()
        {
            return this.litriDaBere;
        }
        public double SetBottigliaPiena()
        {
            return this.bottiglia = 1.5;
        }
        public double SetLitriMessi()
        {
            return this.litriMessi;
        }
        public void SetPh()
        {
            if(ph < 0 || ph > 14)
            {
                throw new PhLimit("Il pH dell'acqua non può essere minore di 0 o maggiore di 14");
            }
            else { this.ph = ph; }
        }
        public void SetSorgente(string sorgente)
        {
            if (!string.IsNullOrEmpty(sorgente))
            {
                throw new EmptyBottle("Non c'è acqua");
            }
        }
        //METODI PUBBLICI
        public void Bevi()
        {
            if (litriDaBere <= litri)
            {
                litri = litri - litriDaBere;
            }
        }
        public void Svuota()
        {
            if (litriDaBere >= litri)
            {
                litri = 0;
            }
        }
        public void Riempi()
        {
            if (litriMessi < bottiglia)
            {
                bottiglia = litriMessi;
            }
            else if (litriMessi > bottiglia)
            {
                Console.WriteLine("Hai messo troppa acqua!");
            }
        }

        public override void StampaProdotto()
        {
            Console.WriteLine("------ " + base.GetName() + " -----");
            Console.WriteLine();
            Console.WriteLine("Descrizione:" + base.GetDescription());
            Console.WriteLine("Capienza:" + this.litri + "l");
            Console.WriteLine("pH: " + this.ph);
            Console.WriteLine("Quanti Litri ci sono:" + this.litriMessi + "l");
            Console.WriteLine("Codice prodotto:" + base.GetCodice());
            Console.WriteLine("L'IVA è: " + base.GetIVA() + "%");
            Console.WriteLine("Il prezzo è: " + base.GetPrezzo() + "euro");
            Console.WriteLine("Il codice NomeEsteso è: " + this.GetNomeEsteso());
            Console.WriteLine();
        }

    }
}
