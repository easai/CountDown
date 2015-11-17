using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDown
{
    public partial class CountDown : Form
    {
        string keyStr = @"Software\LFI\SlideShow";
        string textFile = "DeclarationOfIndependence.txt";


        public CountDown()
        {
            InitializeComponent();

            setRandomText();

            timer.Interval = 1000;
            timer.Start();

            loadConfig();

            slideShow.setImage();
        }

        private void CountDown_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime endTime = new DateTime(now.Year, now.Month, now.Day, 17, 30, 0);

            TimeSpan diff = endTime - now;            
            TimeText.Text = new DateTime(diff.Ticks).ToString("HH:mm:ss");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveConfig();
            Dispose();
        }

        private void aboutCountDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutCountDown().ShowDialog();
        }

        private void loadConfig()
        {
            using (var reg32 = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry64))
            using (Microsoft.Win32.RegistryKey rKey = reg32.OpenSubKey(keyStr))
            {
                try
                {
                    for (int i = 0; i < 4; i++)
                    {
                        string fileName = (string)rKey.GetValue("imagefile" + i);
                        if (fileName != null && !fileName.Equals(""))
                        {
                            slideShow.setImage(i, fileName);
                        }
                    }
                }
                catch (NullReferenceException excep)
                {
                    Console.Error.WriteLine(excep.Message);
                }
            }
        }

        private void saveConfig()
        {
            using (var reg32 = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry64))
            using (Microsoft.Win32.RegistryKey rKey = reg32.CreateSubKey(keyStr))
            {
                try
                {
                    for (int i = 0; i < 4; i++)
                    {
                        string fileName = slideShow.getImage(i);
                        if (fileName != null)
                            rKey.SetValue("imagefile" + i, fileName);
                    }
                }
                catch (NullReferenceException excep) 
                {
                    Console.Error.WriteLine(excep.Message);
                }
            }
        }

        private void setRandomText()
        {
            string str = CountDownFile.getRandom(textFile);
            messageText.Text = str;
        }

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setRandomText();
            Refresh();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textFile = fileDialog.FileName;
                setRandomText();
            }
        }
    }
}
