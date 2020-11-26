using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotTelegramConnect
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            foreach(Control controle in this.Controls)
            {
                if (controle is MdiClient)
                {
                    controle.BackgroundImage = Properties.Resources.paper_planes_seamless_pattern_telegram_symbol_paper_planes_seamless_pattern_telegram_background_158925499;
                    break;
                }
            }
        }

        private void FrmPrincipal_BackgroundImageLayoutChanged(object sender, EventArgs e)
        {

        }

        private void envioDeMensagemComEmogiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnvioTextoComEmoji();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void envioDeMensagemSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnvioTexto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void imagemDaWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnvioImagemWeb();
            frm.MdiParent = this;
            frm.Show();
        }

        private void imagemLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnvioImagem();
            frm.MdiParent = this;
            frm.Show();
        }

        private void envioDeMernsagemComTemporizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmEnvioComTemporizador();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
