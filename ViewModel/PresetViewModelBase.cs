using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Media.Imaging;
using IconMakinator.Exceptions;
using IconMakinator.Utility;

namespace IconMakinator.ViewModel
{
    public abstract class PresetViewModelBase : INotifyPropertyChanged
    {
        private string? _baseImagePath;
        private BitmapImage? _imagePreview;
        private string? _outputFolderPath;
        private string? _shortName;
        private readonly Dictionary<string, FileDetails> _filepaths = new()
        {
            //TR Imperial Gov
            { "LeaderRing", new FileDetails{DisplayName = "leader", OverlayFilePath = "Resources/Imperial/Leader.png", BackgroundFilePath = "Resources/Imperial/GoldBackground.png"}},
            { "LeaderSSD", new FileDetails{DisplayName = "leader_ssd", OverlayFilePath = "Resources/Imperial/LeaderSSD.png", BackgroundFilePath = "Resources/Imperial/GoldBackground.png"}},
            { "LeaderAdmin", new FileDetails{DisplayName = "leader_admin", OverlayFilePath = "Resources/Imperial/AdminLeader.png", BackgroundFilePath = "Resources/Imperial/GoldBackground.png"}},
            { "LeaderSpyMaster", new FileDetails{DisplayName = "leader_spymaster", OverlayFilePath = "Resources/Imperial/SpymasterLeader.png", BackgroundFilePath = "Resources/Imperial/GoldBackground.png"}},
            { "LeaderStructure", new FileDetails{DisplayName = "leader_structure", OverlayFilePath = "Resources/Imperial/LeaderStructure.png", BackgroundFilePath = "Resources/Imperial/GoldBackground.png"}},
            { "WarlordRing", new FileDetails{DisplayName = "warlord", OverlayFilePath = "Resources/Imperial/Warlord.png", BackgroundFilePath = "Resources/Shared/SilverBackground.png"}},
            //Shared
            { "JustSSD", new FileDetails{DisplayName = "ssd", OverlayFilePath = "Resources/Shared/SSD.png", BackgroundFilePath = "Resources/Shared/SilverBackground.png"}},
            { "AdminRing", new FileDetails{DisplayName = "admin", OverlayFilePath = "Resources/Shared/AdminHero.png", BackgroundFilePath = "Resources/Shared/SilverBackground.png"}},
            { "SpyMasterRing", new FileDetails{DisplayName = "spymaster", OverlayFilePath = "Resources/Shared/SpymasterHero.png", BackgroundFilePath = "Resources/Shared/SilverBackground.png"}},
            { "FighterHero", new FileDetails{DisplayName = "assign", OverlayFilePath = "Resources/Shared/assign_-_pilot.png"}},
            //New Republic
            { "HireSupComNR", new FileDetails{DisplayName = "sup_command", OverlayFilePath = "Resources/NewRepublic/hire_-_nr_admiral.png"}},
            { "HireHighComNR", new FileDetails{DisplayName = "high_command", OverlayFilePath = "Resources/NewRepublic/hire_-_nr_commander.png"}},
            { "HireFleetNR", new FileDetails{DisplayName = "fleet_command", OverlayFilePath = "Resources/NewRepublic/hire_-_nr_captain.png"}},
            { "RetireAdmiralNR", new FileDetails{DisplayName = "retire", OverlayFilePath = "Resources/NewRepublic/retirebase_-_nrofficer.png"}},
            { "HireGeneralNR", new FileDetails{DisplayName = "command", OverlayFilePath = "Resources/NewRepublic/hire_-_nr_general.png"}},
            { "RetireGeneralNR", new FileDetails{DisplayName = "retire", OverlayFilePath = "Resources/NewRepublic/retirebase_-_general.png"}},
            { "HireJediNR", new FileDetails{DisplayName = "command", OverlayFilePath = "Resources/Shared/hire_-_jedi.png"}},
            { "RetireJediNR", new FileDetails{DisplayName = "retire", OverlayFilePath = "Resources/Shared/retirebase_-_jedi.png"}},
            //FotR Republic
            { "HireAdmiral", new FileDetails{DisplayName = "command", OverlayFilePath = "Resources/FotRepublic/hire_-_admiral.png"}},
            { "RetireAdmiral", new FileDetails{DisplayName = "retire", OverlayFilePath = "Resources/FotRepublic/retirebase_-_admiral.png"}},
            { "HireMoff", new FileDetails{DisplayName = "command", OverlayFilePath = "Resources/FotRepublic/hire_-_moff.png"}},
            { "RetireMoff", new FileDetails{DisplayName = "retire", OverlayFilePath = "Resources/FotRepublic/retirebase_-_moff.png"}},
            { "HireClone", new FileDetails{DisplayName = "command", OverlayFilePath = "Resources/FotRepublic/hire_-_clone.png"}},
            { "RetireClone", new FileDetails{DisplayName = "retire", OverlayFilePath = "Resources/FotRepublic/retirebase_-_clone.png"}},
            { "HireCommando", new FileDetails{DisplayName = "command", OverlayFilePath = "Resources/FotRepublic/hire_-_clonecommando.png"}},
            { "RetireCommando", new FileDetails{DisplayName = "retire", OverlayFilePath = "Resources/FotRepublic/retirebase_-_clonecommando.png"}},
            { "HireGeneral", new FileDetails{DisplayName = "command", OverlayFilePath = "Resources/FotRepublic/hire_-_general.png"}},
            { "RetireGeneral", new FileDetails{DisplayName = "retire", OverlayFilePath = "Resources/FotRepublic/retirebase_-_general.png"}},
            { "HireJedi", new FileDetails{DisplayName = "command", OverlayFilePath = "Resources/Shared/hire_-_jedi.png"}},
            { "RetireJedi", new FileDetails{DisplayName = "retire", OverlayFilePath = "Resources/Shared/retirebase_-_jedi.png"}},
            //RevRev Republic
            { "HireAdmiralRev", new FileDetails{DisplayName = "command", OverlayFilePath = "Resources/Revpublic/hire_-_admiral.png"}},
            { "RetireAdmiralRev", new FileDetails{DisplayName = "retire", OverlayFilePath = "Resources/FotRepublic/retirebase_-_admiral.png"}},
            { "HireJediRev", new FileDetails{DisplayName = "command", OverlayFilePath = "Resources/Shared/hire_-_jedi.png"}},
            { "RetireJediRev", new FileDetails{DisplayName = "retire", OverlayFilePath = "Resources/Shared/retirebase_-_jedi.png"}},
            //Fighters
            { "OneThirdSquadron", new FileDetails{DisplayName = "third", OverlayFilePath = "Resources/Fighters/squadrons_-_0.3x.png"}},
            { "OneHalfSquadron", new FileDetails{DisplayName = "half", OverlayFilePath = "Resources/Fighters/squadrons_-_0.5x.png"}},
            { "SingleSquadron", new FileDetails{DisplayName = "one", OverlayFilePath = "Resources/Fighters/squadrons_-_1x.png"}},
            { "DoubleSquadron", new FileDetails{DisplayName = "two", OverlayFilePath = "Resources/Fighters/squadrons_-_2x.png"}},
            { "TripleSquadron", new FileDetails{DisplayName = "three", OverlayFilePath = "Resources/Fighters/squadrons_-_3x.png"}},
            { "BomberSquadron", new FileDetails{DisplayName = "", OverlayFilePath = "Resources/Fighters/units_-_bomber.png"}},
            //Infantry
            { "InfantryAssault", new FileDetails{DisplayName = "assault", OverlayFilePath = "Resources/Infantry/infantry_-_assault.png"}},
            { "InfantryHeavy", new FileDetails{DisplayName = "heavy", OverlayFilePath = "Resources/Infantry/infantry_-_heavy.png"}},
            { "InfantrySniper", new FileDetails{DisplayName = "sniper", OverlayFilePath = "Resources/Infantry/infantry_-_sniper.png"}},
            { "InfantrySupport", new FileDetails{DisplayName = "support", OverlayFilePath = "Resources/Infantry/infantry_-_support.png"}},
            { "InfantryElite", new FileDetails{DisplayName = "elite", OverlayFilePath = "Resources/Infantry/infantry_-_elite_guard.png"}},
            //Miscellaneous Unit Overlays
            { "Rocket", new FileDetails{DisplayName = "rocket", OverlayFilePath = "Resources/MiscUnits/infantry-ship_-_rocket.png"}},
            { "Armored", new FileDetails{DisplayName = "armored", OverlayFilePath = "Resources/MiscUnits/units_-_armored.png"}},
            { "Shielded", new FileDetails{DisplayName = "shielded", OverlayFilePath = "Resources/MiscUnits/units_-_shielded.png"}},
            { "ArmoredShielded", new FileDetails{DisplayName = "armored_shielded", OverlayFilePath = "Resources/MiscUnits/units_armored_shielded.png"}},
            { "Battleship", new FileDetails{DisplayName = "battleship", OverlayFilePath = "Resources/MiscUnits/units_-_battleship.png"}},
            { "Carrier", new FileDetails{DisplayName = "carrier", OverlayFilePath = "Resources/MiscUnits/units_-_carrier.png"}},
            { "FighterTender", new FileDetails{DisplayName = "fighter_tender", OverlayFilePath = "Resources/MiscUnits/units_-_fighter_tender.png"}},
            { "FleetTender", new FileDetails{DisplayName = "fleet_tender", OverlayFilePath = "Resources/MiscUnits/units_-_fleet_tender.png"}},
            { "Interdictor", new FileDetails{DisplayName = "interdictor", OverlayFilePath = "Resources/MiscUnits/units_-_interdictor-png"}},
            { "Pdf", new FileDetails{DisplayName = "pdf", OverlayFilePath = "Resources/MiscUnits/units_-_pdf.png"}},
            { "Research", new FileDetails{DisplayName = "research", OverlayFilePath = "Resources/MiscUnits/units_-_research.png"}},
            { "Sensor", new FileDetails{DisplayName = "sensor", OverlayFilePath = "Resources/MiscUnits/units_-_sensor.png"}},
            { "StarForge", new FileDetails{DisplayName = "starforge", OverlayFilePath = "Resources/MiscUnits/units_-_star_forge_refit.png"}},
            { "Refit", new FileDetails{DisplayName = "refit", OverlayFilePath = "Resources/MiscUnits/units_-_weird_refit.png"}}
        };
        public abstract string DisplayName { get; }
        public string BaseImagePath
        {
            get => _baseImagePath!;
            set
            {
                _baseImagePath = value;
                OnPropertyChanged(nameof(BaseImagePath));
            }
        }
        public BitmapImage ImagePreview
        {
            get => _imagePreview!;
            set
            {
                _imagePreview = value;
                OnPropertyChanged();
            }
        }

        public string OutputFolderPath
        {
            get => _outputFolderPath!;
            set
            {
                _outputFolderPath = value;
                OnPropertyChanged(nameof(OutputFolderPath));
            }
        }
        public string ShortName
        {
            get => _shortName!;
            set
            {
                _shortName = value;
                OnPropertyChanged();
            }
        }
        public Dictionary<string, FileDetails> FilePaths
        {
            get => _filepaths;
        }
        public virtual void SetImageProperty(string filename)
        {
            BaseImagePath = filename;
            BitmapImage bitmap = new();
            bitmap.BeginInit();
            bitmap.UriSource = (new Uri(BaseImagePath));
            bitmap.CacheOption = BitmapCacheOption.OnLoad;
            bitmap.EndInit();
            ImagePreview = bitmap;
        }
        public bool GenerateImage()
        {
            try
            {
                if (string.IsNullOrEmpty(BaseImagePath) || !File.Exists(BaseImagePath))
                    throw new NoImageSelectedException();

                var properties = GetType()
                    .GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)
                    .Where(p => p.PropertyType == typeof(bool) && (bool?)p.GetValue(this) == true);

                if (properties.Count() == 0)
                    throw new NoOverlaySelectedException();

                foreach (var property in properties)
                {
                    if (!GetFilepaths(property.Name))
                        throw new Exception();
                }

                ImageCreator.BasicTga(BaseImagePath, ConstructImageName(""));

                return true;
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
            catch (Exception)
            {
                return false;
            }
        }
        public bool GetFilepaths(string dictKey)
        {
            try
            {
                var entry = FilePaths[dictKey];
                string filepath = ConstructImageName(entry.DisplayName);
                if (dictKey == "BomberSquadron")
                {
                    var newPath = ImageCreator.BomberSpecific(BaseImagePath, filepath);
                    var newPath2 = ImageCreator.AllInOne(newPath, entry.BackgroundFilePath ?? "", entry.OverlayFilePath, filepath);
                    SetImageProperty(newPath2);
                }
                else
                {
                    ImageCreator.AllInOne(BaseImagePath, entry.BackgroundFilePath ?? "", entry.OverlayFilePath, filepath);
                }
                return true;
            }
            catch (NoNameSetException)
            {
                throw;
            }
            catch (NoImageSelectedException)
            {
                throw;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public string ConstructImageName(string displayName)
        {
            if (ShortName == null || ShortName == string.Empty)
                throw new NoNameSetException();
            string outputPath = Path.Combine(OutputFolderPath, "Output", ShortName);
            Directory.CreateDirectory(outputPath);
            string display = string.IsNullOrEmpty(displayName) ? "" : $"_{displayName}";
            string finalFileName = Path.Combine(outputPath, $"i_button_{ShortName}{display}.tga");

            return finalFileName.ToLower();
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
