using GalaSoft.MvvmLight;

namespace catec.MvvmSample.Logic.Ui
{
    
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
                WindowTitle = "MvvmSample (Design)";
            }
            else
            {
                // Code runs "for real"
                WindowTitle = "MvvmSample";
            }
        }

        public string WindowTitle { get; private set; }
    }
}