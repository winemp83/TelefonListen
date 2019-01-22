using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class AnrufList
    {
        public static IList<Anruf> Anrufe { get; private set; }

        static AnrufList()
        {
            Anrufe = new List<Anruf>()
            {
                new Anruf(){
                Uhrzeit = "13:00",
                Name = "Unbekannt",
                Tele = "05431/9896911",
                FahrtAm = "01.01.1970",
                FahrtUm = "13:30",
                Abhohlort = "Speckplatz Großalmerode",
                Ziel = "Helsa Bahnhof",
                Typ = "AST",
                Fahrer = "SaKo",
                Notiz = "Dies ist eine Testfahr \r\nIch hoffe es wird alles angezeigt",
                Fahrpreis = "1.00" }
            };
        }
    }
}
