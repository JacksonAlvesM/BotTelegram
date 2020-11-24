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
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegramConnect
{
    public partial class FrmEnvioImagemWeb : Form
    {
        public FrmEnvioImagemWeb()
        {
            InitializeComponent();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtURLImagem.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe a URL da imagem para envio!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var telegramBot = new TelegramBotClient("1432240157:AAE_14LbHxjMqx5S4NrqFfdlL1K8DVCD8H8");
                var imagemRequest = WebRequest.Create(txtURLImagem.Text.Trim());

                using (var imagemResponse = imagemRequest.GetResponse())
                {
                    var stream = imagemResponse.GetResponseStream();
                    await telegramBot.SendPhotoAsync(chatId: "-1001386936204", photo: stream, caption: txtMensagem.Text.Trim(), parseMode: ParseMode.Html);
                }


                MessageBox.Show("Mensagem enviada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao enviar mensagem! " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtMensagem.Text = string.Empty;
                txtURLImagem.Text = string.Empty;
            }
        }
    }

}

