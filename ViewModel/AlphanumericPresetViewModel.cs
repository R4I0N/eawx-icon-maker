using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconMakinator.ViewModel
{
    public class AlphanumericPresetViewModel : PresetViewModelBase
    {
        public override string DisplayName => "Alphanumeric";

        private bool _romanOne;
        private bool _romanTwo;
        private bool _romanThree;
        private bool _romanFour;

        public bool RomanOne
        {
            get => _romanOne;
            set
            {
                _romanOne = value;
                OnPropertyChanged();
            }
        }
        public bool RomanTwo
        {
            get => _romanTwo;
            set
            {
                _romanTwo = value;
                OnPropertyChanged();
            }
        }
        public bool RomanThree
        {
            get => _romanThree;
            set
            {
                _romanThree = value;
                OnPropertyChanged();
            }
        }
        public bool RomanFour
        {
            get => _romanFour;
            set
            {
                _romanFour = value;
                OnPropertyChanged();
            }
        }
    }
}
