using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LearnWpfSuiteBindingProxy
{
    public partial class MainWindowViewModel : ObservableObject
    {
        public ObservableCollection<string> SomeStrings { get; } = new()
        {
            "QWEQOIFJEIOWE",
            "JFWOIEJFOISDF",
            "JFOISDJF"
        };


        [RelayCommand]
        public void ShowSomeMessage()
        {
            MessageBox.Show("Some message", "Tip", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        [RelayCommand]
        public void ShowText(string text)
        {
            MessageBox.Show(text, "Tip", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
