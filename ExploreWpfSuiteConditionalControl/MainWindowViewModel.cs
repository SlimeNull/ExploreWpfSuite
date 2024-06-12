using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ExploreWpfSuiteConditionalControl
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [RelayCommand]
        public async Task SomeTask()
        {
            await Task.Delay(3000);
        }
    }
}
