using FullStackWPFMVVM.WPF.States.Navigators;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullStackWPFMVVM.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public INavigator Navigator { get; set; } = new Navigator();
    }
}
