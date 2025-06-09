namespace IconMakinator.ViewModel
{
    public class ImperialPresetViewModel : PresetViewModelBase
    {
        private bool _leaderRing;
        private bool _leaderSSD;
        private bool _leaderAdmin;
        private bool _leaderSpyMaster;
        private bool _leaderStructure;
        private bool _warlordRing;
        private bool _justSSD;

        public override string DisplayName => "Imperial Preset";
        public bool LeaderRing
        {
            get => _leaderRing;
            set
            {
                _leaderRing = value;
                OnPropertyChanged();
            }
        }
        public bool LeaderSSD
        {
            get => _leaderSSD;
            set
            {
                _leaderSSD = value;
                OnPropertyChanged();
            }
        }
        public bool LeaderAdmin
        {
            get => _leaderAdmin;
            set
            {
                _leaderAdmin = value;
                OnPropertyChanged();
            }
        }
        public bool LeaderSpyMaster
        {
            get => _leaderSpyMaster;
            set
            {
                _leaderSpyMaster = value;
                OnPropertyChanged();
            }
        }
        public bool LeaderStructure
        {
            get => _leaderStructure;
            set
            {
                _leaderStructure = value;
                OnPropertyChanged();
            }
        }
        public bool WarlordRing
        {
            get => _warlordRing;
            set
            {
                _warlordRing = value;
                OnPropertyChanged();
            }
        }
        public bool JustSSD
        {
            get => _justSSD;
            set
            {
                _justSSD = value;
                OnPropertyChanged();
            }
        }
    }
}
