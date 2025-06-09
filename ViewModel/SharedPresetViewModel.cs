namespace IconMakinator.ViewModel
{
    public class SharedPresetViewModel : PresetViewModelBase
    {
        public override string DisplayName => "Shared Preset";

        private bool _spyMasterRing;
        private bool _adminRing;
        private bool _agentRing;
        private bool _fighterHero;
        private bool _justSSD;

        public bool SpyMasterRing
        {
            get => _spyMasterRing;
            set
            {
                _spyMasterRing = value;
                OnPropertyChanged();
            }
        }
        public bool AdminRing
        {
            get => _adminRing;
            set
            {
                _adminRing = value;
                OnPropertyChanged();
            }
        }
        public bool AgentRing
        {
            get => _agentRing;
            set
            {
                _agentRing = value;
                OnPropertyChanged();
            }
        }
        public bool FighterHero
        {
            get => _fighterHero;
            set
            {
                _fighterHero = value;
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
