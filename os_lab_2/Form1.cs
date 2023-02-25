using System;
using System.IO;
using System.Windows.Forms;

namespace os_lab_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e) // Copy button
        {
            try
            {
                string file_path_src = this.textBox1.Text;
                string file_name = Path.GetFileName(file_path_src);
                string file_path_dest = this.textBox2.Text + "\\" + file_name;
                File.Copy(file_path_src, file_path_dest, true);
            }
            catch (Exception ex) // purely for debugging purposes
            {
                this.stoopid();
            }
        }
        private void button2_Click(object sender, EventArgs e) // Move button
        {
            try
            {
                string file_path_src = this.textBox1.Text;
                string file_name = Path.GetFileName(file_path_src);
                string file_path_dest = this.textBox2.Text + "\\" + file_name;
                File.Copy(file_path_src, file_path_dest, true);
                File.Delete(file_path_src);
            }
            catch (Exception ex) // purely for debugging purposes
            {
                this.stoopid();
            }
        }
        private void button3_Click(object sender, EventArgs e) // Del button
        {
            try
            {
                File.Delete(this.textBox1.Text);
            }
            catch
            {
                this.stoopid();
            }
        }
        private void button4_Click(object sender, EventArgs e) // Scr button
        {
            OpenFileDialog file_dialog = new OpenFileDialog();
            
            file_dialog.InitialDirectory = this.textBox1.Text;
            file_dialog.RestoreDirectory = true;
            
            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = file_dialog.FileName;
            }
        }
        private void button5_Click(object sender, EventArgs e) // Dest button
        {
            FolderBrowserDialog folder_dialog = new FolderBrowserDialog();
            
//            folder_dialog.InitialDirectory = this.textBox1.Text;
//            folder_dialog.RestoreDirectory = true;
            
            if (folder_dialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox2.Text = folder_dialog.SelectedPath;
            }
        }
        private void stoopid()
        {
            string message = "Why are u booing me??";
            string caption = "YOU!!! STOOPID!";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }
    }
}
