using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Notekeeper.Views
{
    public partial class GATest : ContentPage
    {
        IEventTracker eventTracker;

        public GATest()
        {
            InitializeComponent();
            eventTracker = DependencyService.Get<IEventTracker>();
        }

        async void OnButton01Clicked(object sender, System.EventArgs e)
        {
            eventTracker.SendEvent("Click01");
        }

        async void OnButton02Clicked(object sender, System.EventArgs e)
        {
            eventTracker.SendEvent("Click02", "Comment", "Hello Events");
        }

        async void OnButton03Clicked(object sender, System.EventArgs e)
        {
            var dictionary = new Dictionary<string, string>
            {
                {"Name", "John Xamarin"},
                {"Phone", "55 555 555 555"},
                {"Email", "johnxamarin@john.com"}
            };
            eventTracker.SendEvent("Click03", dictionary);
        }
    }
}