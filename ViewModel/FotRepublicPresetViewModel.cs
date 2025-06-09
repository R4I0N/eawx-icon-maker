namespace IconMakinator.ViewModel
{
    public class FotRepublicPresetViewModel : PresetViewModelBase
    {
        public override string DisplayName => "Republic Preset (FotR)";

        private bool _hireAdmiral;
        private bool _retireAdmiral;
        private bool _hireMoff;
        private bool _retireMoff;
        private bool _hireClone;
        private bool _retireClone;
        private bool _hireCommando;
        private bool _retireCommando;
        private bool _hireGeneral;
        private bool _retireGeneral;
        private bool _hireJedi;
        private bool _retireJedi;
        public bool HireAdmiral
        {
            get => _hireAdmiral;
            set
            {
                _hireAdmiral = value;
                OnPropertyChanged();
            }
        }
        public bool RetireAdmiral
        {
            get => _retireAdmiral;
            set
            {
                _retireAdmiral = value;
                OnPropertyChanged();
            }
        }
        public bool HireMoff
        {
            get => _hireMoff;
            set
            {
                _hireMoff = value;
                OnPropertyChanged();
            }
        }
        public bool RetireMoff
        {
            get => _retireMoff;
            set
            {
                _retireMoff = value;
                OnPropertyChanged();
            }
        }
        public bool HireClone
        {
            get => _hireClone;
            set
            {
                _hireClone = value;
                OnPropertyChanged();
            }
        }
        public bool RetireClone
        {
            get => _retireClone;
            set
            {
                _retireClone = value;
                OnPropertyChanged();
            }
        }
        public bool HireCommando
        {
            get => _hireCommando;
            set
            {
                _hireCommando = value;
                OnPropertyChanged();
            }
        }
        public bool RetireCommando
        {
            get => _retireCommando;
            set
            {
                _retireCommando = value;
                OnPropertyChanged();
            }
        }
        public bool HireGeneral
        {
            get => _hireGeneral;
            set
            {
                _hireGeneral = value;
                OnPropertyChanged();
            }
        }
        public bool RetireGeneral
        {
            get => _retireGeneral;
            set
            {
                _retireGeneral = value;
                OnPropertyChanged();
            }
        }
        public bool HireJedi
        {
            get => _hireJedi;
            set
            {
                _hireJedi = value;
                OnPropertyChanged();
            }
        }
        public bool RetireJedi
        {
            get => _retireJedi;
            set
            {
                _retireJedi = value;
                OnPropertyChanged();
            }
        }
    }
}
