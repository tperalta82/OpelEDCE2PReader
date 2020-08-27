using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EDCOpenReadE2P
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void e2p_open_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog e2p_ofd = new OpenFileDialog();
            e2p_ofd.Filter = "Binary Files(*.bin)|*.bin|All Files (*.*)|*.*";
            e2p_ofd.DefaultExt = "bin";
            e2p_ofd.Title = "Open EEPROM Binay File";
            e2p_ofd.CheckFileExists = true;
            e2p_ofd.CheckPathExists = true;
            e2p_ofd.ShowDialog();
            e2p_file_path_txt.Text = e2p_ofd.FileName;


            try
            {
                // VIN LOC 000001A000 - 000001B000 = 16 * 84 = 1344
                // SEC CODE LOC 0000054003 - 0000054006 = 16 * 26 = begin 416 + 3 (offset)
                // SW VER LOC 0000002008 - 000000200F = 16 * 2 = begin 32 + 6 (offset)
                Stream fs = e2p_ofd.OpenFile();
                byte[] VINHex = new byte[17];
                byte[] PinHex = new byte[4];
                byte[] SWVerHEx = new byte[10];
                byte[] SWDate = new byte[8];
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    reader.BaseStream.Seek(416, SeekOrigin.Begin);
                    reader.Read(VINHex, 0, 17);

                    reader.BaseStream.Seek(1347, SeekOrigin.Begin);
                    reader.Read(PinHex, 0, 4);

                    reader.BaseStream.Seek(38, SeekOrigin.Begin);
                    reader.Read(SWVerHEx, 0, 10);

                    reader.BaseStream.Seek(18, SeekOrigin.Begin);
                    reader.Read(SWDate, 0, 8);
                }
                e2p_vin.Text = Encoding.Default.GetString(VINHex);
                e2p_sec_code.Text = Encoding.Default.GetString(PinHex);
                e2p_sw_ver.Text = Encoding.Default.GetString(SWVerHEx);
                e2p_sw_date.Text = Encoding.Default.GetString(SWDate);
            }
            catch( Exception ex)
            {
                MessageBox.Show("O Peralta fez merda porque: " + ex + " Ou então, sei lá, o ficheiro ta fodido ou o caralho, nao ha pops mas ha bangs");
            }
        }
    }
}
