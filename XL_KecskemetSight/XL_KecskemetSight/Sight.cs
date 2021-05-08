using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XL_KecskemetSight
{
    public class Sight
    {
        public string Name { get; set; }
        public ImageSource Image { get; set; }
        public string PlusCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
