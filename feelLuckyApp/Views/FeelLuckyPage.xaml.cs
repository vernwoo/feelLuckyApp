using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace feelLuckyApp
{
    public partial class FeelLuckyPage : ContentPage
    {
        public IDataStore DataStore => DependencyService.Get<IDataStore>() ?? new MockDataStore();
        public FeelLuckyPage()
        {
            InitializeComponent();
        }

        public void OnTryIt(Object sender, EventArgs e )
        {
            lblLuckyText.Text = DataStore.GetLuckyString(true);
        }
    }
}
