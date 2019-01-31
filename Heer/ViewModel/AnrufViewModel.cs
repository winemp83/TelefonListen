using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    using ViewModelBase;
    using Model;

    /// <summary>
    /// A ViewModel for a Anruf.
    /// </summary>
    public class AnrufViewModel : ViewModel<Anruf>
    {
        public AnrufViewModel(Anruf model)
            : base(model)
        {
        }

        public string Uhrzeit {
            get { return Model.Uhrzeit; }
            set {
                if (Uhrzeit != value) {
                    Model.Uhrzeit = value;
                    this.OnPropertyChanged("Uhrzeit");
                }
            }
        }
        public string Name
        {
            get { return Model.Name; }
            set
            {
                if (Name != value)
                {
                    Model.Name = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }
        public string Telefon
        {
            get { return Model.Tele; }
            set
            {
                if (Telefon != value)
                {
                    Model.Tele = value;
                    this.OnPropertyChanged("Telefon");
                }
            }
        }
        public string FahrtAm
        {
            get { return Model.FahrtAm; }
            set
            {
                if (FahrtAm != value)
                {
                    Model.FahrtAm = value;
                    this.OnPropertyChanged("FahrtAm");
                }
            }
        }
        public string FahrtUm
        {
            get { return Model.FahrtUm; }
            set
            {
                if (FahrtUm != value)
                {
                    Model.FahrtUm = value;
                    this.OnPropertyChanged("FahrtUm");
                }
            }
        }
        public string AbhohlOrt
        {
            get { return Model.Abhohlort; }
            set
            {
                if (AbhohlOrt != value)
                {
                    Model.Abhohlort = value;
                    this.OnPropertyChanged("AbhohlOrt");
                }
            }
        }
        public string ZielOrt
        {
            get { return Model.Ziel; }
            set
            {
                if (ZielOrt != value)
                {
                    Model.Ziel = value;
                    this.OnPropertyChanged("ZielOrt");
                }
            }
        }
        public string FahrtArt
        {
            get { return Model.Typ; }
            set
            {
                if (FahrtArt != value)
                {
                    Model.Typ = value;
                    this.OnPropertyChanged("FahrtArt");
                }
            }
        }
        public string Fahrer
        {
            get { return Model.Fahrer; }
            set
            {
                if (Fahrer != value)
                {
                    Model.Fahrer = value;
                    this.OnPropertyChanged("Fahrer");
                }
            }
        }
        public string Notiz
        {
            get { return Model.Notiz; }
            set
            {
                if (Notiz != value)
                {
                    Model.Notiz = value;
                    this.OnPropertyChanged("Notiz");
                }
            }
        }
        public string Fahrpreis
        {
            get { return Model.Fahrpreis; }
            set
            {
                if (Fahrpreis != value)
                {
                    Model.Fahrpreis = value;
                    this.OnPropertyChanged("Fahrpreis");
                }
            }
        }
    }
}
