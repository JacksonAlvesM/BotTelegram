
namespace BotTelegramConnect
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMensagemSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMensagemComImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagemDaWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagemLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMensagemComEmogiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMernsagemComTemporizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.envioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // envioToolStripMenuItem
            // 
            this.envioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.envioDeMensagemSimplesToolStripMenuItem,
            this.envioDeMensagemComImagemToolStripMenuItem,
            this.envioDeMensagemComEmogiToolStripMenuItem,
            this.envioDeMernsagemComTemporizadorToolStripMenuItem});
            this.envioToolStripMenuItem.Name = "envioToolStripMenuItem";
            this.envioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.envioToolStripMenuItem.Text = "Envio";
            // 
            // envioDeMensagemSimplesToolStripMenuItem
            // 
            this.envioDeMensagemSimplesToolStripMenuItem.Name = "envioDeMensagemSimplesToolStripMenuItem";
            this.envioDeMensagemSimplesToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.envioDeMensagemSimplesToolStripMenuItem.Text = "Envio de Mensagem Simples";
            this.envioDeMensagemSimplesToolStripMenuItem.Click += new System.EventHandler(this.envioDeMensagemSimplesToolStripMenuItem_Click);
            // 
            // envioDeMensagemComImagemToolStripMenuItem
            // 
            this.envioDeMensagemComImagemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagemDaWebToolStripMenuItem,
            this.imagemLocalToolStripMenuItem});
            this.envioDeMensagemComImagemToolStripMenuItem.Name = "envioDeMensagemComImagemToolStripMenuItem";
            this.envioDeMensagemComImagemToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.envioDeMensagemComImagemToolStripMenuItem.Text = "Envio de Mensagem com Imagem";
            // 
            // imagemDaWebToolStripMenuItem
            // 
            this.imagemDaWebToolStripMenuItem.Name = "imagemDaWebToolStripMenuItem";
            this.imagemDaWebToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.imagemDaWebToolStripMenuItem.Text = "Imagem da Web ";
            this.imagemDaWebToolStripMenuItem.Click += new System.EventHandler(this.imagemDaWebToolStripMenuItem_Click);
            // 
            // imagemLocalToolStripMenuItem
            // 
            this.imagemLocalToolStripMenuItem.Name = "imagemLocalToolStripMenuItem";
            this.imagemLocalToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.imagemLocalToolStripMenuItem.Text = "Imagem Local";
            this.imagemLocalToolStripMenuItem.Click += new System.EventHandler(this.imagemLocalToolStripMenuItem_Click);
            // 
            // envioDeMensagemComEmogiToolStripMenuItem
            // 
            this.envioDeMensagemComEmogiToolStripMenuItem.Name = "envioDeMensagemComEmogiToolStripMenuItem";
            this.envioDeMensagemComEmogiToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.envioDeMensagemComEmogiToolStripMenuItem.Text = "Envio de mensagem com Emoji";
            this.envioDeMensagemComEmogiToolStripMenuItem.Click += new System.EventHandler(this.envioDeMensagemComEmogiToolStripMenuItem_Click);
            // 
            // envioDeMernsagemComTemporizadorToolStripMenuItem
            // 
            this.envioDeMernsagemComTemporizadorToolStripMenuItem.Name = "envioDeMernsagemComTemporizadorToolStripMenuItem";
            this.envioDeMernsagemComTemporizadorToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.envioDeMernsagemComTemporizadorToolStripMenuItem.Text = "Envio de Mernsagem com Temporizador";
            this.envioDeMernsagemComTemporizadorToolStripMenuItem.Click += new System.EventHandler(this.envioDeMernsagemComTemporizadorToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Formulario Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.BackgroundImageLayoutChanged += new System.EventHandler(this.FrmPrincipal_BackgroundImageLayoutChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMensagemSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMensagemComImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagemDaWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagemLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMensagemComEmogiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMernsagemComTemporizadorToolStripMenuItem;
    }
}

