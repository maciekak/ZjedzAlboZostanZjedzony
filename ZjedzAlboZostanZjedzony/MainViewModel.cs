using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ZjedzAlboZostanZjedzony.Annotations;

namespace ZjedzAlboZostanZjedzony
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private int _mapSize = 40;
        private int _stepFrequency = 700;
        private int _seekingRadius = 6;
        private int _addingNumberFrequencyLevel = 3;
        private ViewState _viewState;

        public ViewState ViewState
        {
            get => _viewState;
            set
            {
                if (_viewState != value)
                {
                    _viewState = value;
                    OnPropertyChanged(nameof(ViewState));
                }
            }
        }

        public ICommand StartCommand { get; }

        public int MapSize
        {
            get => _mapSize;
            set
            {
                if (_mapSize != value)
                {
                    _mapSize = value;
                    OnPropertyChanged(nameof(MapSize));
                }
            }
        }

        public int StepFrequency
        {
            get => _stepFrequency;
            set
            {
                if (_stepFrequency != value)
                {
                    _stepFrequency = value;
                    OnPropertyChanged(nameof(StepFrequency));
                }
            }
        }

        public int SeekingRadius
        {
            get => _seekingRadius;
            set
            {
                if (_seekingRadius != value)
                {
                    _seekingRadius = value;
                    OnPropertyChanged(nameof(SeekingRadius));
                }
            }
        }

        public int AddingNumberFrequencyLevel
        {
            get => _addingNumberFrequencyLevel;
            set
            {
                if (_addingNumberFrequencyLevel != value)
                {
                    _addingNumberFrequencyLevel = value;
                    OnPropertyChanged(nameof(AddingNumberFrequencyLevel));
                }
            }
        }

        public MainViewModel()
        {
            ViewState = ViewState.InitialView;
            StartCommand = new StartCommand(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
