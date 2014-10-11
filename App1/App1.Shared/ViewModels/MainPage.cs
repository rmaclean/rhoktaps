using App1.mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace App1.ViewModels
{
    public class MainPage : BasePage
    {
        public ICommand CaptureDrippingTap { get; set; }
        private bool showCaptureUI;

        public bool ShowCaptureUI
        {
            get { return showCaptureUI; }
            set
            {
                showCaptureUI = value;
                OnPropertyChanged();
            }
        }


        public MainPage()
        {
            CaptureDrippingTap = new Command(CaptureDrippingTapExecute);

        }
        private void CaptureDrippingTapExecute()
        {
            ShowCaptureUI = true;
        }
    }
}
