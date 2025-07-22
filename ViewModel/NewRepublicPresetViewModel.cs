namespace IconMakinator.ViewModel
{
    public class NewRepublicPresetViewModel : PresetViewModelBase
    {
        public override string DisplayName => "New Republic Preset";

        private bool _hireSupCom;
        private bool _hireHighCom;
        private bool _hireOfficer;
        private bool _retireAdmiral;
        private bool _hireGeneral;
        private bool _retireGeneral;
        private bool _hireJedi;
        private bool _retireJedi;

        public bool HireSupComNR
        {
            get => _hireSupCom;
            set
            {
                _hireSupCom = value;
                OnPropertyChanged();
            }
        }
        public bool HireHighComNR
        {
            get => _hireHighCom;
            set
            {
                _hireHighCom = value;
                OnPropertyChanged();
            }
        }
        public bool HireFleetOfficerNR
        {
            get => _hireOfficer;
            set
            {
                _hireOfficer = value;
                OnPropertyChanged();
            }
        }
        public bool RetireAdmiralNR
        {
            get => _retireAdmiral;
            set
            {
                _retireAdmiral = value;
                OnPropertyChanged();
            }
        }
        public bool HireGeneralNR
        {
            get => _hireGeneral;
            set
            {
                _hireGeneral = value;
                OnPropertyChanged();
            }
        }
        public bool RetireGeneralNR
        {
            get => _retireGeneral;
            set
            {
                _retireGeneral = value;
                OnPropertyChanged();
            }
        }
        public bool HireJediNR
        {
            get => _hireJedi;
            set
            {
                _hireJedi = value;
                OnPropertyChanged();
            }
        }
        public bool RetireJediNR
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
