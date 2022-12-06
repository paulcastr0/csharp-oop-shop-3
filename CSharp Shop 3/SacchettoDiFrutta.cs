﻿using CSharp_Shop_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Shop_3
{

    public class Sacchetto_di_frutta : Prodotto
    {
        private uint numeroFrutti;
        private string tipoFrutto;
        private double pesoSacchetto;
        private double pesoFrutto;


        public Sacchetto_di_frutta(string name, string description, double prezzo, double IVA, uint numeroFrutti, double pesoSacchetto, string tipoFrutto) : base(name, description, prezzo, IVA)
        {
            this.numeroFrutti = numeroFrutti;
            this.tipoFrutto = tipoFrutto;
            this.pesoSacchetto = pesoSacchetto;
            this.pesoFrutto = PesoFrutto();
        }

        public uint GetNumeroFrutti()
        {
            return this.numeroFrutti;
        }

        public string GetTipoFrutto()
        {
            return this.tipoFrutto;
        }

        public double GetPesoSacchetto()
        {
            return this.pesoSacchetto;
        }

        public double GetPesoFrutto()
        {
            return this.pesoFrutto;
        }

        public void AggiungiFrutta(uint numeroFrutti)
        {
            double prezzoSingoloFrutto = this.GetPrezzo() / this.numeroFrutti;
            this.numeroFrutti = this.numeroFrutti + numeroFrutti;
            this.pesoSacchetto = this.pesoSacchetto + (numeroFrutti * this.pesoFrutto);
            double prezzoAggiornato = prezzoSingoloFrutto * this.numeroFrutti;
            this.SetPrezzo(prezzoAggiornato);
        }

        private double PesoFrutto()
        {
            double pesofrutto = this.pesoSacchetto / this.numeroFrutti;
            return pesofrutto;
        }
    }
}
