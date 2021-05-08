using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XL_KecskemetSight
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SightPage : ContentPage
    {
        List<Sight> Sights = new List<Sight>();

        public SightPage()
        {
            InitializeComponent();
            Sights.Add(
					new Sight
					{
						PlusCode = "VMW9+CM Kecskemét",
						Latitude = 46.8960,
						Longitude = 19.6690,
						Name = "GAMF Faculty of Engineering and Computer Science, John von Neumann University",
						Image = ImageSource.FromUri(new Uri("https://www.uni-neumann.hu/images/Egyetem/infrastruktura/gamf/gamf_01.JPG")),
						Description = "The GAMF Faculty's educational and research activities cover the most state-of-the-art materials in use today, while also examining their properties and related technologies. It is of paramount importance that students acquire not only theoretical knowledge, but obtain pragmatic know-how as well through easy access to materials, machines and equipment.\r\nThe university places a major emphasis on practice-oriented teaching. This objective is supported by modern and extensive pool of equipment, and by faculty members with close ties to the industry.Continuous renewal,the providing of up - to - date solutions, and the assurance of life - long learning for our Faculty members are paramount."
					});
					Sights.Add(new Sight
					{
						PlusCode = "VPW9+X4 Kecskemét",
						Name = "Kecskemét Zoo",
						Latitude = 46.897488,
						Longitude = 19.717761,
						Image = ImageSource.FromUri(new Uri("https://lh5.googleusercontent.com/p/AF1QipP94spGK9OgoMe5k4aRkDNQOKq08z5D7FM1nlSv=w408-h273-k-no")),
						Description = "The Kecskemét Wildlife Garden was established in 1971 mainly for the purpose of presenting native Hungarian domestic and wild animals. The zoo has been dynamicaly developed since than, nowadays among others a tiger house, a bear house, a monkey house and a lion houseenriches the beautiful environment."
					});
					Sights.Add(new Sight
					{
						PlusCode = "WM28+PH Kecskemét",
						Name = "Kecskemét Spa",
						Latitude = 46.9021,
						Longitude = 19.6664,
						Image = ImageSource.FromUri(new Uri("https://lh5.googleusercontent.com/p/AF1QipPHXDJg3csT6AlsCpjhmQA1_0OCC5tdj7-Ccwfh=w408-h271-k-no")),
						Description = "There are several pools, indoor and outdoor as well (wave pool,	pool for children, cave pool, etc.). Good facilities, sauna, and thermal bath part are avasilable as well."
					});
					Sights.Add(new Sight
					{
						PlusCode = "WM4R+MP Kecskemét",
						Name = "Kecskemét City Hall",
						Latitude = 46.906692,
						Longitude = 19.691810,
						Image = ImageSource.FromUri(new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/3/35/Kecskem%C3%A9tv%C3%A1rosh%C3%A1z_l%C3%A9gifot%C3%B3.jpg/250px-Kecskem%C3%A9tv%C3%A1rosh%C3%A1z_l%C3%A9gifot%C3%B3.jpg")),
						Description = "The City Hall registered as the pearl of secession can be found at the Main Square. It was built between 1893-1897 according to the design of the architects Ödön Lechner and Gyula Pártos. The City Hall is one of the best-known buildings of Kecskemét, and a monument visited by the most tourists.\r\nYou can hear the carillon on the facade of the building since 1983 playing the works of Kodály, Erkel,	and Beethoven every hour.Its outside walls are decorated by the majolica of Zsolnay,which can be seen on other buildings in the town as well."
					});
			lvList.ItemsSource = Sights;
			Application.Current.Properties["CurrentSight"] = Sights[0];
        }

        private void lvList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
			Application.Current.Properties["CurrentSight"] = e.SelectedItem as Sight;
			//var MasterPage = this.Parent as MainPage;

		}
    }
}