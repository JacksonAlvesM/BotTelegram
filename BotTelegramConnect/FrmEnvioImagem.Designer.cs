
namespace BotTelegramConnect
{
    partial class FrmEnvioImagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bnBscImagem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaminhoImagem = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnBscImagem
            // 
            this.bnBscImagem.Location = new System.Drawing.Point(503, 204);
            this.bnBscImagem.Name = "bnBscImagem";
            this.bnBscImagem.Size = new System.Drawing.Size(96, 20);
            this.bnBscImagem.TabIndex = 0;
            this.bnBscImagem.Text = "...";
            this.bnBscImagem.UseVisualStyleBackColor = true;
            this.bnBscImagem.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mensagem:";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(15, 54);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(584, 116);
            this.txtMensagem.TabIndex = 2;
            this.txtMensagem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Caminho da Imagem:";
            // 
            // txtCaminhoImagem
            // 
            this.txtCaminhoImagem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCaminhoImagem.Enabled = false;
            this.txtCaminhoImagem.Location = new System.Drawing.Point(15, 204);
            this.txtCaminhoImagem.Name = "txtCaminhoImagem";
            this.txtCaminhoImagem.Size = new System.Drawing.Size(481, 20);
            this.txtCaminhoImagem.TabIndex = 4;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(364, 241);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(235, 40);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar Mensagem";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FrmEnvioImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 293);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtCaminhoImagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnBscImagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnvioImagem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de Mesagem com Imagem Local";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnBscImagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaminhoImagem;
        private System.Windows.Forms.Button btnEnviar;
    }
}