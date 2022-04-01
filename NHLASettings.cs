using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace NHLAClient
{
    public partial class NHLASettings : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public NHLASettings()
        {
            InitializeComponent();

            // Round corners
            FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            tbServer.Text = GLOBALS.SERVERIP;
            tbUpdate.Text = GLOBALS.UPDATERATE_MS.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // exit
            Hide();
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

        // get remote neofetch output
        private async void btnNeofetch_Click(object sender, EventArgs e)
        {
            try
            {
                string neofetch = await GetAsync(GLOBALS.SERVERIP + "api/neofetch");

                File.WriteAllText("neofetch.txt", neofetch);
                DialogResult dialog = MessageBox.Show("Wrote output to (neofetch.txt).\nOpen?", "NHLAClient/Neofetch", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                    Process.Start($@"notepad.exe", $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\neofetch.txt");
                else
                    return;

            } catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        // https://stackoverflow.com/questions/27108264/how-to-properly-make-a-http-web-get-request (thanks)
        private async Task<string> GetAsync(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return await reader.ReadToEndAsync();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // server ip
            if (tbServer.Text.Contains(" "))
            {
                MessageBox.Show("Server IP cannot contain spaces.");
                return;
            } else
                GLOBALS.SERVERIP = tbServer.Text.ToLower();

            // update rate
            if (tbUpdate.Text.All(char.IsDigit))
                GLOBALS.UPDATERATE_MS = Convert.ToInt32(tbUpdate.Text);
            else
            {
                MessageBox.Show("Update rate must be a number.");
                return;
            }

            GLOBALS.WRITE(); // write settings

            //! tell user settings were saved
            MessageBox.Show("Settings saved.");
        }

        private void NHLASettings_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
                NHLA.master = true;
            else if (Visible)
                NHLA.master = false;
        }
    }
}
