using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LearnWpfSuiteConditionalControl
{
    public partial class MainWindowViewModel : ObservableObject
    {
        public ObservableCollection<string> SomeCollection { get; } = new();


        [RelayCommand]
        public async Task SomeTask()
        {
            await Task.Delay(3000);
        }

        [RelayCommand]
        public void AddItem()
        {
            SomeCollection.Add(System.IO.Path.GetRandomFileName());
        }

        [RelayCommand]
        public void RemoveItem()
        {
            if (SomeCollection.Count == 0)
                return;

            SomeCollection.RemoveAt(SomeCollection.Count - 1);
        }
    }
}
