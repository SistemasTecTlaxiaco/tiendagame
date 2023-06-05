using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void But_Noti_Click(object sender, EventArgs e)
        {
            Noticia noticia = new Noticia();
            noticia.Show();
            this.Hide();
        }

        private void But_TopJPG_Click(object sender, EventArgs e)
        {
            PAGA pAGA = new PAGA();
            pAGA.Show();
            this.Hide();
        }

        private void But_TopJG_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void BTN_OVERWATCH2_Click(object sender, EventArgs e)
        {
            OVER oVER = new OVER();
            oVER.Show();
            this.Hide();
        }

        private void BTN_VALORAN_Click(object sender, EventArgs e)
        {
            VALORANTXT vALORANTXT = new VALORANTXT();
            vALORANTXT.Show();
            this.Hide();
        }

        private void BTN_PUBG_Click(object sender, EventArgs e)
        {
            PUBG pUBG = new PUBG();
            pUBG.Show();
            this.Hide();
        }

        private void BTN_MINECRAFT_Click(object sender, EventArgs e)
        {
            MINE mINE = new MINE(); 
            mINE.Show();    
            this.Hide();
        }

        private void BTN_WARZONE_Click(object sender, EventArgs e)
        {

        }

        private void BTN_FALLGUYS_Click(object sender, EventArgs e)
        {

        }

        private void But_InicioPag_Click(object sender, EventArgs e)
        {

        }

        private void BTN_TIENDA_Click(object sender, EventArgs e)
        {
            Form3 tienda = new Form3();
            tienda.Show();
            this.Hide();
        }
    }
}
