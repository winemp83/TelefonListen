using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Anruf
    {
        public string Uhrzeit { get; set; }
        public string Name { get; set; }
        public string Tele { get; set; }
        public string FahrtAm { get; set; }
        public string FahrtUm { get; set; }
        public string Abhohlort { get; set; }
        public string Ziel { get; set; }
        public string Typ { get; set; }
        public string Fahrer { get; set; }
        public string Notiz { get; set; }
        public string Fahrpreis { get; set; }

        public override string ToString()
        {
            return FahrtAm + " " + FahrtUm + " :: von " + Abhohlort + " nach " + Ziel + " für " + Fahrer + "\r\n Bemerkungen : " + Notiz;
        }

        public override bool Equals(object obj)
        {
            return obj is Anruf anruf &&
                   Uhrzeit == anruf.Uhrzeit &&
                   Name == anruf.Name &&
                   Tele == anruf.Tele &&
                   FahrtAm == anruf.FahrtAm &&
                   FahrtUm == anruf.FahrtUm &&
                   Abhohlort == anruf.Abhohlort &&
                   Ziel == anruf.Ziel &&
                   Typ == anruf.Typ &&
                   Fahrer == anruf.Fahrer &&
                   Notiz == anruf.Notiz &&
                   Fahrpreis == anruf.Fahrpreis;
        }

        public override int GetHashCode()
        {
            var hashCode = -1483257561;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Uhrzeit);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Tele);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FahrtAm);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FahrtUm);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Abhohlort);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Ziel);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Typ);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Fahrer);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Notiz);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Fahrpreis);
            return hashCode;
        }
    }
}
