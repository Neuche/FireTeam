using CsvHelper;
using GMap.NET;
using GMap.NET.MapProviders;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireTeam
{
    public partial class Form1 : Form
    {
        private const string PathMarker = @"C:\Users\User\source\repos\FireTeam\FireTeam\fireMarkers.csv";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Wrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 270)
            {
                Sidebar.Visible = false;
                Sidebar.Width = 68;
                Sidebarwrapper.Width = 90;
                AnimacionSidebar.Show(Sidebar);
            }
            else
            {
                Sidebar.Width = 270;
                Sidebarwrapper.Width = 300;
                LineSidebbar.Width = 252;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maxim_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maxim.Visible = false;
            restore.Visible = true;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            restore.Visible = false;
            Maxim.Visible = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void SidebarWrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            map2.Visible = false;
        }

        private void Adentro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void map2_Load(object sender, EventArgs e)
        {

        }

        private void Maps_Click(object sender, EventArgs e)
        {
            map2.Visible = true;
        }


        public class CbaData
        {
            public double lat { get; set; }
            public double lon { get; set; }
            public double val { get; set; }
        }

        private void map2_Load_1(object sender, EventArgs e)
        {
            map2.MapProvider = GMapProviders.GoogleSatelliteMap;
            double lat = Convert.ToDouble(-31.417123);
            double lon = Convert.ToDouble(-64.188910);
            map2.MinZoom = 5;
            map2.MaxZoom = 100;
            map2.Zoom = Convert.ToDouble(10);
            map2.Position = new PointLatLng(lat, lon);

            //using (TextFieldParser parser = new TextFieldParser(PathMarker))
            //{
            //    parser.TextFieldType = FieldType.Delimited;
            //    parser.SetDelimiters(",");
            //    while (!parser.EndOfData)
            //    {
            //        //Processing row
            //        string[] fields = parser.ReadFields();
            //        foreach (string field in fields)
            //        {
            //            MessageBox.Show(field);
            //            //TODO: Process field
            //        }
            //    }
            //}

            


        /*
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(-25.966688, 32.580528),
            GMarkerGoogleType.green);
            markersOverlay.Markers.Add(marker);
            gmap.Overlays.Add(markersOverlay);
         */
    }

        private void chats_Click(object sender, EventArgs e)
        {
            map2.Visible = false;
        }

        private void Reportes_Click(object sender, EventArgs e)
        {
            map2.Visible = false;
        }

        private void signout_Click(object sender, EventArgs e)
        {
            map2.Visible = false;
            Dispose();
        }
    }
}
