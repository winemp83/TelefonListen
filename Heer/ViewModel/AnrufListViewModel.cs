using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Input;
using Model;
using ViewModelBase;

namespace ViewModel
{
    public class AnrufListViewModel : ViewModelBase.ViewModel
    {
        private ObservableCollection<AnrufViewModel> anrufe;

        public ObservableCollection<AnrufViewModel> Anrufe
        {
            get { return anrufe; }
            set
            {
                if (Anrufe != value)
                {
                    anrufe = value;
                    this.OnPropertyChanged("Anrufe");
                }
            }
        }

        public AnrufListViewModel()
        {
            anrufe = new ObservableCollection<AnrufViewModel>(AnrufList.Anrufe.Select(p => new AnrufViewModel(p)));
            anrufe.CollectionChanged += Anrufe_CollectionChanged;
        }

        void Anrufe_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (AnrufViewModel vm in e.NewItems)
                {
                    AnrufList.Anrufe.Add(vm.Model);
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (AnrufViewModel vm in e.OldItems)
                {
                    AnrufList.Anrufe.Remove(vm.Model);
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Reset)
            {
                AnrufList.Anrufe.Clear();
            }

        }

        private ICommand addAnrufCommand;

        public ICommand AddAnrufCommand
        {
            get
            {
                if (addAnrufCommand == null)
                {
                    addAnrufCommand = new RelayCommand(p => ExecuteAddPersonCommand());
                }
                return addAnrufCommand;
            }
        }

        private void ExecuteAddPersonCommand()
        {
            Anrufe.Add(new AnrufViewModel(new Anruf()));
        }
    }
}
