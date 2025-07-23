using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using IconMakinator.Exceptions;

namespace IconMakinator.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private PresetViewModelBase _preset;
        public ObservableCollection<PresetViewModelBase> Presets { get; set; }
        public PresetViewModelBase SelectedPreset
        {
            get => _preset;
            set
            {
                _preset = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            Presets = new ObservableCollection<PresetViewModelBase>()
            {
                new ImperialPresetViewModel(),
                new NewRepublicPresetViewModel(),
                new FotRepublicPresetViewModel(),
                new RevpublicPresetViewModel(),
                new SharedPresetViewModel(),
                new FighterPresetViewModel(),
                new InfantryPresetViewModel(),
                new MiscUnitsPresetViewModel(),
                new AlphanumericPresetViewModel()
            };
            SelectedPreset = Presets.First();
        }

        public void LoadBaseImage(string filename)
        {
            SelectedPreset?.SetImageProperty(filename);
        }
        public bool? ApplyOverlays(string outputFolderPath)
        {
            try
            {
                SelectedPreset.OutputFolderPath = outputFolderPath;
                return SelectedPreset?.GenerateImage();
            }
            catch (NoOverlaySelectedException)
            {
                throw;
            }
            catch (NoNameSetException)
            {
                throw;
            }
            catch (NoImageSelectedException)
            {
                throw;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
