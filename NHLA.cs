using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace NHLAClient
{
    public partial class NHLA : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        Form formSettings = new NHLASettings();
        public NHLA()
        {
            InitializeComponent();

            // setup updater
            TempUpdate.Interval = GLOBALS.UPDATERATE_MS;
            TempUpdate.Enabled = true;

            // Round corners
            FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            GLOBALS.LOAD();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // exit
            Application.Exit();
        }

        // move form
        private void pnHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // open settings form
        private void btnSettings_Click(object sender, EventArgs e)
        {
            // check if form is already visible (avoid duplicates)
            FormCollection formCollection = Application.OpenForms;
            foreach (Form frm in formCollection)
                if (frm.Name != "NHLASettings")
                {
                    formSettings.Visible = true;
                    break;
                }
                    


        }

        // https://stackoverflow.com/questions/27108264/how-to-properly-make-a-http-web-get-request (thanks)
        // once interval is reached
        public static bool master = true;
        private static bool updating = false;
        private async void TempUpdate_Tick(object sender, EventArgs e)
        {
            if (master)
            {
                // if not already updating
                if (!updating)
                {
                    // mark that thread is updating
                    updating = true;
                    laHeader.Text = "NHLAClient - Updating";

                    // contains parsed temps
                    List<string> temps = new List<string>();

                    // 1. get values from server and split them by carriage returns.
                    // 2. check for error
                    // 3. add values to temps list
                    string rTemps = await GetAsync(GLOBALS.SERVERIP + "api/temp");
                    if (rTemps == "ERR")
                    {
                        laHeader.Text = "NHLAClient - Not Connected";
                        updating = false;
                        return;
                    }

                    foreach (string temp in rTemps.Split('\n'))
                    {
                        temps.Add(temp);
                    }

                    // display temps
                    try
                    {
                        // --------------------
                        laTemp0.Text = temps[0];
                        if (temps[0].Split('.')[0].Length >= 3)
                            pbTemp0.Value = 100;
                        else if (temps[0].Split('.')[0].StartsWith("-"))
                            pbTemp0.Value = 0;
                        else
                            pbTemp0.Value = Convert.ToInt32(temps[0].Split('.')[0]);

                        // --------------------
                        laTemp1.Text = temps[1];
                        if (temps[1].Split('.')[0].Length >= 3)
                            pbTemp1.Value = 100;
                        else if (temps[1].Split('.')[0].StartsWith("-"))
                            pbTemp1.Value = 0;
                        else
                            pbTemp1.Value = Convert.ToInt32(temps[1].Split('.')[0]);

                        // --------------------
                        laTemp2.Text = temps[2];
                        if (temps[2].Split('.')[0].Length >= 3)
                            pbTemp2.Value = 100;
                        else if (temps[2].Split('.')[0].StartsWith("-"))
                            pbTemp2.Value = 0;
                        else
                            pbTemp2.Value = Convert.ToInt32(temps[2].Split('.')[0]);

                        // --------------------
                        laTemp3.Text = temps[3];
                        if (temps[3].Split('.')[0].Length >= 3)
                            pbTemp3.Value = 100;
                        else if (temps[3].Split('.')[0].StartsWith("-"))
                            pbTemp3.Value = 0;
                        else
                            pbTemp3.Value = Convert.ToInt32(temps[3].Split('.')[0]);
                    }
                    catch
                    {
                        laTemp0.Text = "N/A";
                        pbTemp0.Value = 100;

                        laTemp1.Text = "N/A";
                        pbTemp1.Value = 100;

                        laTemp2.Text = "N/A";
                        pbTemp2.Value = 100;

                        laTemp3.Text = "N/A";
                        pbTemp3.Value = 100;
                    }

                    laHeader.Text = "NHLAClient - Connected";
                    updating = false;
                }
            }
        }

        private async Task<string> GetAsync(string uri)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return await reader.ReadToEndAsync();
                }
            } catch
            {
                return "ERR";
            }
        }
    }
}
