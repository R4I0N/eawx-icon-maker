using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconMakinator.ViewModel
{
    public class InfantryPresetViewModel : PresetViewModelBase
    {
        public override string DisplayName => "Infantry Preset";

        private bool _infantryAssault;
        private bool _infantryHeavy;
        private bool _infantrySniper;
        private bool _infantrySupport;
        private bool _infantryElite;
        private bool _infantryCommander;
        public bool InfantryAssault
        {
            get => _infantryAssault;
            set
            {
                _infantryAssault = value;
                OnPropertyChanged();
            }
        }
        public bool InfantryHeavy
        {
            get => _infantryHeavy;
            set
            {
                _infantryHeavy = value;
                OnPropertyChanged();
            }
        }
        public bool InfantrySniper
        {
            get => _infantrySniper;
            set
            {
                _infantrySniper = value;
                OnPropertyChanged();
            }
        }
        public bool InfantrySupport
        {
            get => _infantrySupport;
            set
            {
                _infantrySupport = value;
                OnPropertyChanged();
            }
        }
        public bool InfantryElite
        {
            get => _infantryElite;
            set
            {
                _infantryElite = value;
                OnPropertyChanged();
            }
        }
        public bool InfantryCommander
        {
            get => _infantryCommander;
            set
            {
                _infantryCommander = value;
                OnPropertyChanged();
            }
        }
    }
}
