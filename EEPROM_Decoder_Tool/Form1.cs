using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEPROM_Decoder_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EEPROM_decoder EEPROM_decoder = new EEPROM_decoder();
        private void button_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "選擇要開啟的EEPROM檔案";
            openFileDialog1.Filter = "EEPROM Files |*.txt;*.hex|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!EEPROM_decoder.OpenHex(openFileDialog1.FileName))
                    MessageBox.Show("Open wrong content of EEPROM hex file", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_open.Text = openFileDialog1.FileName;
            }
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "選擇要儲存的EEPROM檔案";
            openFileDialog1.Filter = "EEPROM Files |*.txt;*.hex|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(!EEPROM_decoder.SaveHex(openFileDialog1.FileName))
                    MessageBox.Show("Save EEPROM hex file error,\nPlease try again", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_save.Text = openFileDialog1.FileName;               
            }
        }
    }
}
