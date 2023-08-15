using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrrad
{
    internal class Fahrrad
    {
        private string pedale;
        private reifen vorderreifen;
        private reifen Hinterdereifen;


        public void Setpedale(string pedale)
        {
            this.pedale = pedale;
        }

        public string Getpedale()
        {
            return this.pedale;
        }
        //public void Setreifen(reifen wheel)
        //{
        //    this.vorderreifen = wheel;
        //}
        //public reifen Getreifen()
        //{
        //    return this.vorderreifen;
        //}

        public void Setvorderreifen(reifen wheel)
        {
            this.vorderreifen = wheel;
        }
        public reifen Getvorderreifen()
        {
            return this.vorderreifen;
        }
        public void SetHiterreifen(reifen wheel)
        {
            this.Hinterdereifen = wheel;
        }
        public reifen GetHiterreifen()
        {
            return this.Hinterdereifen;
        }
    }
}
