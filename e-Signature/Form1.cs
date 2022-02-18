using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace e_Signature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float InitialPosX = 0, InitialPosY = 0;
        float LastPosX = 0, LastPosY = 0;

        private void SignaturePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = SignaturePanel.CreateGraphics();
            G.DrawLine(Pens.Black, InitialPosX, InitialPosY, LastPosX, LastPosY);
            LastPosX = InitialPosX;
            LastPosY = InitialPosY;
        }

        private void SavePNG_Click(object sender, EventArgs e)
        {
            
            Image bmp = new Bitmap(SignaturePanel.Width, SignaturePanel.Height);
            var gg = Graphics.FromImage(bmp);
            var rect = SignaturePanel.RectangleToScreen(SignaturePanel.ClientRectangle);
            gg.CopyFromScreen(rect.Location, Point.Empty, SignaturePanel.Size);

            //saves file in "C:\Users\Yusuf\OneDrive\Desktop\e-Signature\bin\debug"
            bmp.Save("Test.png", ImageFormat.Png);

            //Opens Files Dialog and Manually Select Folder Location and File Name
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG(*.PNG)|*.png";

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bmp.Save(sfd.FileName);
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Graphics g = SignaturePanel.CreateGraphics();
            g.Clear(Color.White);
            SignaturePanel.Controls.Clear();
            SignaturePanel.Invalidate();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(@"C:\Users\Yusuf\Downloads\Saved Signatures\");
            DataTable table = new DataTable();
            table.Columns.Add("File Name");

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file.Name);
            }

            SignatureDataGridView.DataSource = table;

        }

        private void SignatureDataGridView_DoubleClick(object sender, EventArgs e)
        {
            Form2 pictureForm = new Form2();
            string PNGName = SignatureDataGridView.CurrentRow.Cells[0].Value.ToString();
            Image img;
            img = Image.FromFile(@"C:\Users\Yusuf\Downloads\Saved Signatures\" + PNGName);
            pictureForm.pictureBox1.Image = img;
            pictureForm.ShowDialog();
        }

        private void SignaturePanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPosX = e.X;
            LastPosY = e.Y;
        }

        private void SignaturePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                InitialPosX = e.X;
                InitialPosY = e.Y;
                SignaturePanel_Paint(this, null);
            }
        }
    }
}
