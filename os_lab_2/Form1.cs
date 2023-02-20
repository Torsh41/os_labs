using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.CodeDom.Compiler;

namespace os_lab_2
{
    public partial class Form1 : Form
    {
        private DiskData disk_data;

        //public DiskData disk_data;

        public Form1()
        {
            // init disk_data class
            disk_data = new DiskData();

            InitializeComponent();
            // other init
            string[] temp_string = this.disk_data.get_disk_names(); // get array of disk names
            this.comboBox1.Items.AddRange(temp_string); // add disk names to combo-box items
            this.comboBox1.Text = (string)this.comboBox1.Items[0]; // hope there's at least one drive. Also default disk value
            this.comboBox1.FormattingEnabled = false;
            this.label1.Text = "Выберите диск:";
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get information about 'disk-name' (=== combo-box.Text)
            DriveInfo drive = this.disk_data.get_disk_data(this.comboBox1.Text);
            // display the information in the text-box
            this.textBox1.Text = String.Format("\r\nTotal available space: {0, 15} bytes\r\nTotal size of drive: {1, 15} bytes", drive.TotalFreeSpace, drive.TotalSize);
        }
    }
}
