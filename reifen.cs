using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fahrrad
{
    internal class reifen
    {
        private int grosse;
        private wentil wentil =new wentil();
        private int speichen;
        private int breite;
        private string Art;
        


        public void SetGrosse(int grosse)
        {
            this.grosse = grosse;
        }
        public int GetGrosse()
        {
            return this.grosse;
        }
        public void Setwentil( wentil p)
        {
            this.wentil = p;
        }
        public wentil Getwentil()
        {
            return this.wentil;
        }
        public void Setspeichen(int speichen)
        {
            this.speichen = speichen;
        }
        public int Getspeichen()
        {
            return this.speichen;
        }
        public void Setbreite(int breite)
        {
            this.breite = breite;
        }
        public int Getbreite()
        {
            return this.breite;
        }
        public void SetArt(string art)
        {
            this.Art = art;
        }
        public string GetArt()
        {
            return this.Art;

        }
        public void Talkabutyourself()
        {
            Console.WriteLine($"ich bin ein reifen{this.GetGrosse()},und meine breite ist {this.Getbreite()},und ich habe {this.Getspeichen()} speichen \n" +
                $"ich habe {this.Getwentil()} wentile,mein Art ist {this.GetArt()}");
        }
        public void GeplatzterReifen(int zeit)
        {
           Thread.Sleep(zeit);
           
           Thread.Sleep(zeit);
            Console.WriteLine("Die Reifen ist geplazt");
        }
    }
}
