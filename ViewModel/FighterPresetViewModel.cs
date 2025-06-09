namespace IconMakinator.ViewModel
{
    public class FighterPresetViewModel : PresetViewModelBase
    {
        public override string DisplayName => "Fighter Preset";

        private bool _bomberSquadron;
        private bool _oneThirdSquadron;
        private bool _oneHalfSquadron;
        private bool _singleSquadron;
        private bool _doubleSquadron;
        private bool _tripleSquadron;

        public bool BomberSquadron
        {
            get => _bomberSquadron;
            set
            {
                _bomberSquadron = value;
                OnPropertyChanged();
            }
        }
        public bool OneThirdSquadron
        {
            get => _oneThirdSquadron;
            set
            {
                _oneThirdSquadron = value;
                OnPropertyChanged();
            }
        }
        public bool OneHalfSquadron
        {
            get => _oneHalfSquadron;
            set
            {
                _oneHalfSquadron = value;
                OnPropertyChanged();
            }
        }
        public bool SingleSquadron
        {
            get => _singleSquadron;
            set
            {
                _singleSquadron = value;
                OnPropertyChanged();
            }
        }
        public bool DoubleSquadron
        {
            get => _doubleSquadron;
            set
            {
                _doubleSquadron = value;
                OnPropertyChanged();
            }
        }
        public bool TripleSquadron
        {
            get => _tripleSquadron;
            set
            {
                _tripleSquadron = value;
                OnPropertyChanged();
            }
        }
    }
}
