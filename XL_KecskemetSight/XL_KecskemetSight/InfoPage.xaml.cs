using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace XL_KecskemetSight
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPage : ContentPage
    {
        Sight CurrentSight;

        public InfoPage()
        {
            InitializeComponent();
        }

        private void InfoPage_Appearing(object sender, EventArgs e)
        {
            CurrentSight = Application.Current.Properties["CurrentSight"] as Sight;
            if (CurrentSight == null) return;
            BindingContext = CurrentSight;
        }

        private async void btShowOnMap_Clicked(object sender, EventArgs e)
        {
            var PlusCode = CurrentSight.PlusCode.Replace("+", "%2b");
            await Launcher.OpenAsync("geo:0,0?q=" + PlusCode);
        }
    }
}