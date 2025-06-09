using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconMakinator.ViewModel
{
    public class RevpublicPresetViewModel : PresetViewModelBase
    {
        public override string DisplayName => "Republic Preset (Rev)";

        private bool _hireAdmiral;
        private bool _retireAdmiral;
        private bool _hireJedi;
        private bool _retireJedi;

        public bool HireAdmiralRev
        {
            get => _hireAdmiral;
            set
            {
                _hireAdmiral = value;
                OnPropertyChanged();
            }
        }
        public bool RetireAdmiralRev
        {
            get => _retireAdmiral;
            set
            {
                _retireAdmiral = value;
                OnPropertyChanged();
            }
        }
        public bool HireJediRev
        {
            get => _hireJedi;
            set
            {
                _hireJedi = value;
                OnPropertyChanged();
            }
        }
        public bool RetireJediRev
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
