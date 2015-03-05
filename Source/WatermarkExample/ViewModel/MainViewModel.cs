using GalaSoft.MvvmLight;
using System;

namespace WatermarkExample.ViewModel
{    
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            this.WatermarkText = "Enter some text";
        }


        #region Text Property

        /// <summary>
        /// Private member backing variable for <see cref="Text" />
        /// </summary>
        private String _Text = null;

        /// <summary>
        /// Gets and sets the text associated with our demo textbox
        /// </summary>
        public String Text
        {
            get
            {
                if (_Text == null)
                { _Text = String.Empty; }

                return _Text;
            }
            set { Set(() => Text, ref _Text, value); }
        }

        #endregion
        
        #region WatermarkText Property

        /// <summary>
        /// Private member backing variable for <see cref="WatermarkText" />
        /// </summary>
        private String _WatermarkText = null;

        /// <summary>
        /// Gets and sets the text of the watermark
        /// </summary>
        public String WatermarkText
        {
            get
            {
                if (_WatermarkText == null)
                { _WatermarkText = String.Empty; }

                return _WatermarkText;
            }
            set { Set(() => WatermarkText, ref _WatermarkText, value); }
        }

        #endregion

    }
}