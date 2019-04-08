using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Xml;
using System.IO.Compression;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {       
        string stdNo = "";
        string scheduledTime;
        static string spath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        string labName = "";
        string labFolder = "";
        string xmlFile = "";
        string scheduleButtonpressed = "";
        static string zipPathFolder= Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
             

        public MainForm()
        {
            InitializeComponent();
           scheduledtimeTextbox.CustomFormat = "MM/dd/yyyy hh:mm tt";
        }    
        private void DownloadButton_Click(object sender, EventArgs e)
        {
            string zipPath = Path.Combine(zipPathFolder, labName + ".zip");
            if (scheduleButtonpressed == "true")
            {
                try
                {
                    ZipFile.CreateFromDirectory(labFolder, zipPath);
                    MessageBox.Show("lab file downloaded, check documents");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                
            }
            else
            {
                MessageBox.Show("Please first schedule");
            }
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            scheduleButtonpressed = "true";
           if(stdName.Text !="" && studentnum.Text !="" && course.Text !="" && year.Text!="" && labs.Text!="" && scheduledtimeTextbox.Text !="")
            {
                stdNo = studentnum.Text.ToString();
                scheduledTime = scheduledtimeTextbox.Text;
                labName = labs.Text;
                labFolder = Path.Combine(spath, labName);
                xmlFile = Path.Combine(labFolder, "lab.xml");
                long number1 = 0;
                bool canConvert = long.TryParse(stdNo, out number1);
                if (canConvert == true)
                    {
                    XDocument doc = XDocument.Load(xmlFile);

                    XElement date = (from elem in doc.Descendants("Setting")
                                     where (string)elem.Attribute("Name") == "DateTime"
                                     select elem).FirstOrDefault<XElement>();
                    XElement stdno = (from elem in doc.Descendants("Setting")
                                      where (string)elem.Attribute("Name") == "StudentNumber"
                                      select elem).FirstOrDefault<XElement>();
                    date.Attribute("Value").Value = scheduledTime;
                    stdno.Attribute("Value").Value = stdNo;
                    doc.Save(xmlFile);
                    MessageBox.Show("Scheduled successfully","", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Please check your student number");
                }                
            }
            else
            {
                MessageBox.Show("please fill the fields");
            }            
        }

    }
}
