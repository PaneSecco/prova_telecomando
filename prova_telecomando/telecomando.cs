using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_telecomando
{
    internal class telecomando
    {
        //immutabili
        private string produttore;
        private string modello;
        private string modalita;

        //mutabili
        private int canale=0;
        private int volume=0;
        private bool stato=false;

        public telecomando()
        {

        }

        public void setcanale(int cambio)
        {
            canale = cambio;
        }

        public int getcanale()
        {
            return canale;
        }

        public void cambio_stato()
        {
            if (stato == false)
            {
                stato = true;
            }
            else
            {
                stato = false;
            }
        }

        public bool get_stato()
        {
            return stato;
        }

        public void volume_su()
        {
            volume = volume + 1;
        }
        public void volume_giu()
        {
            volume = volume - 1;
        }

        public int get_volume()
        {
            return volume;
        }
        public void set_specifiche(string produttore1, string modello1, string modalita1)
        {
            produttore = produttore1;
            modello = modello1;
            modalita = modalita1;
        }
        public string[] get_specifiche()
        {
            string[] array = { produttore, modello, modalita };
            return array;
        }
    }
}
