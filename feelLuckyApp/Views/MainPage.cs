using System;

using Xamarin.Forms;

namespace feelLuckyApp
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Page feelLuckyPage = null;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    feelLuckyPage = new NavigationPage(new FeelLuckyPage())
                    {
                        Title = "Feel Lucky"
                    };

                    feelLuckyPage.Icon = "tab_feed.png";
                    break;
                default:
                    feelLuckyPage = new FeelLuckyPage()
                    {
                        Title = "Feel Lucky?"
                    };
                    break;
            }
            Children.Add(feelLuckyPage);

            Title = Children[0].Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }
    }
}
