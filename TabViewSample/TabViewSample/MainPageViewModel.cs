using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.CommunityToolkit.UI.Views;

namespace TabViewSample
{
    public class MainPageViewModel
    {
        public IList Tabs { get; } = new ObservableCollection<string> { "Tab1", "Tab2", "Tab3" };
    }
}
