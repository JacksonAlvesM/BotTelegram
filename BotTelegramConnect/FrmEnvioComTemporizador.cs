using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegramConnect
{
    public partial class FrmEnvioComTemporizador : Form
    {
        private List<string> lstMensagens;
        private int posicaoEnvio;
        public FrmEnvioComTemporizador()
        {
            InitializeComponent();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            lstMensagens = new List<string>();
            btnEnviar.Enabled = false;
        }

        private void PrepararEnvio()
        {
            posicaoEnvio = 0;
            InicializarProgressBar();
            InicializarTimerControle();
        }

        private void InicializarProgressBar()
        {
            prbStatusEnvio.Value = 0;
            prbStatusEnvio.Maximum = lstMensagens.Count;
        }

        private void InicializarTimerControle()
        {
            var minuto = Convert.ToInt32(txtTempo.Text.Trim());

            timerControle.Interval = minuto * 60 * 1000;
            timerControle.Enabled = true;

            this.timerControle.Tick += new EventHandler(TimerControle_Tick);
            this.BackColor = Color.Red;
        }

        private void PararTimerControle()
        {
            timerControle.Enabled = false;
            timerControle.Tick -= new EventHandler(TimerControle_Tick);
            this.BackColor = SystemColors.Control;
            btnEnviar.Enabled = true;
        }

        private void AtualizarProgressoEnvio()
        {
            prbStatusEnvio.Value++;
            lblStatusEnvio.Text = string.Format("Enviando {0} de {1}...", posicaoEnvio, lstMensagens.Count);
        }
        private async void TimerControle_Tick(object sender, EventArgs e)
        {
            try
            {
                var telegramBot = new TelegramBotClient("1432240157:AAE_14LbHxjMqx5S4NrqFfdlL1K8DVCD8H8");
                var mesagemAtual = lstMensagens[posicaoEnvio];

                mesagemAtual = EmojiConfig.Config(mesagemAtual);

                await telegramBot.SendTextMessageAsync(chatId: "-1001386936204", text: mesagemAtual, parseMode: ParseMode.Html);

                posicaoEnvio++;

                //Atualizar progresso de envio
                AtualizarProgressoEnvio();

                if (posicaoEnvio == lstMensagens.Count)
                    PararTimerControle();

            }
            catch (Exception ex)
            {
                PararTimerControle();
                MessageBox.Show("Erro ao enviar mensagem! " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCarregarMensagens_Click(object sender, EventArgs e)
        {
            try
            {
                btnCarregarMensagens.Enabled = false;
                var arquivoMensagens = "Mensagens.txt";

                lstMensagens.Clear();
                lbMensagens.Items.Clear();

                using (StreamReader sr = new StreamReader(arquivoMensagens))
                {
                    var strLinha = string.Empty;

                    while ((strLinha = sr.ReadLine()) !=null)
                    {
                        if (!strLinha.Trim().Equals(string.Empty))
                        {
                            lstMensagens.Add(strLinha.Trim());
                            lbMensagens.Items.Add(strLinha.Trim());
                        }
                    }
                }
                if (lstMensagens.Count > 0)
                    btnEnviar.Enabled = true;
            }
            catch (Exception ex)
            {

                btnCarregarMensagens.Enabled = true;
                btnEnviar.Enabled = false;
                lstMensagens.Clear();
                lbMensagens.Items.Clear();
                MessageBox.Show("Erro ao carregar o arquivo. " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtTempo.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você deve informar o tempo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnEnviar.Enabled = false;

            //Verificar se encontrou uma linha no arquivo de texto
            if (lstMensagens.Count == 0)
                MessageBox.Show("Nenhuma mensagem carregada no arquivo.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                PrepararEnvio();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }
    }
}
