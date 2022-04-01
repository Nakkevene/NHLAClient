using System;
using System.IO;
using System.Windows.Forms;

namespace NHLAClient
{
    public static class GLOBALS
    {
        public static void LOAD()
        {
            if (!File.Exists("config.txt"))
                WRITE();

            try
            {
                foreach (string line in File.ReadLines("config.txt"))
                    switch (line.Split('=')[0])
                    {
                        case "SERVERIP":
                            SERVERIP = line.Split('=')[1];
                            break;
                        case "UPDATERATE_MS":
                            try
                            {
                                UPDATERATE_MS = Convert.ToInt32(line.Split('=')[1]);
                            } catch (FormatException feerr)
                            {
                                MessageBox.Show("FormatException at UPDATERATE_MS in (config.txt).\n" + feerr);
                            } catch (OverflowException ofeerr)
                            {
                                MessageBox.Show("OverflowException at UPDATERATE_MS in (config.txt).\n" + ofeerr);
                            } catch (ArgumentNullException aneerr)
                            {
                                MessageBox.Show("ArgumentNullException at UPDATERATE_MS in (config.txt).\n" + aneerr);
                            }
                                
                            break;
                    }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

        public static void WRITE()
        {
            try
            {
                File.WriteAllText("config.txt", $"SERVERIP={SERVERIP}"
                    + $"\nUPDATERATE_MS={UPDATERATE_MS}");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

            LOAD();
        }

        //! funny variables (defaults loaded at boot)
        public static string SERVERIP = "http://NHLA.local:5666/";
        public static int UPDATERATE_MS = 5000;
    }
}