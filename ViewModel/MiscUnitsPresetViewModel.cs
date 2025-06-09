namespace IconMakinator.ViewModel
{
    public class MiscUnitsPresetViewModel : PresetViewModelBase
    {
        public override string DisplayName => "Miscellaneous Unit Overlays Preset";

        private bool _rocket;
        private bool _armored;
        private bool _shielded;
        private bool _armoredShielded;
        private bool _battleship;
        private bool _carrier;
        private bool _fighterTender;
        private bool _fleetTender;
        private bool _interdictor;
        private bool _pdf;
        private bool _research;
        private bool _sensor;
        private bool _starForge;
        private bool _refit;
        public bool Rocket
        {
            get => _rocket;
            set
            {
                _rocket = value;
                OnPropertyChanged();
            }
        }
        public bool Armored
        {
            get => _armored;
            set
            {
                _armored = value;
                OnPropertyChanged();
            }
        }
        public bool Shielded
        {
            get => _shielded;
            set
            {
                _shielded = value;
                OnPropertyChanged();
            }
        }
        public bool ArmoredShielded
        {
            get => _armoredShielded;
            set
            {
                _armoredShielded = value;
                OnPropertyChanged();
            }
        }
        public bool Battleship
        {
            get => _battleship;
            set
            {
                _battleship = value;
                OnPropertyChanged();
            }
        }
        public bool Carrier
        {
            get => _carrier;
            set
            {
                _carrier = value;
                OnPropertyChanged();
            }
        }
        public bool FighterTender
        {
            get => _fighterTender;
            set
            {
                _fighterTender = value;
                OnPropertyChanged();
            }
        }
        public bool FleetTender
        {
            get => _fleetTender;
            set
            {
                _fleetTender = value;
                OnPropertyChanged();
            }
        }
        public bool Interdictor
        {
            get => _interdictor;
            set
            {
                _interdictor = value;
                OnPropertyChanged();
            }
        }
        public bool Pdf
        {
            get => _pdf;
            set
            {
                _pdf = value;
                OnPropertyChanged();
            }
        }
        public bool Research
        {
            get => _research;
            set
            {
                _research = value;
                OnPropertyChanged();
            }
        }
        public bool Sensor
        {
            get => _sensor;
            set
            {
                _sensor = value;
                OnPropertyChanged();
            }
        }
        public bool StarForge
        {
            get => _starForge;
            set
            {
                _starForge = value;
                OnPropertyChanged();
            }
        }
        public bool Refit
        {
            get => _refit;
            set
            {
                _refit = value;
                OnPropertyChanged();
            }
        }
    }
}
