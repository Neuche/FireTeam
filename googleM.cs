using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;

namespace FireTeam
{
    public partial class googleM : Form
    {
        public googleM()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            map.MapProvider = GMapProviders.GoogleSatelliteMap;
            double lat = Convert.ToDouble(-31.417123);
            double lon = Convert.ToDouble(-64.188910);
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = Convert.ToDouble(10);
            map.Position = new PointLatLng(lat, lon);
        }

        private void googleM_Load(object sender, EventArgs e)
        {

        }
    }
}
