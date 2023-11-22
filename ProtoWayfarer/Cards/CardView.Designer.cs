namespace ProtoWayfarer.Cards
{
    partial class CardView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            lblHeadline = new Label();
            lblTypValue = new Label();
            toolTip = new ToolTip(components);
            lblTokens = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 16);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 96);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            toolTip.SetToolTip(pictureBox1, "Tooltip with Text for the Card");
            // 
            // lblHeadline
            // 
            lblHeadline.AutoSize = true;
            lblHeadline.Location = new Point(0, 0);
            lblHeadline.Margin = new Padding(0);
            lblHeadline.Name = "lblHeadline";
            lblHeadline.Size = new Size(54, 15);
            lblHeadline.TabIndex = 1;
            lblHeadline.Text = "Headline";
            // 
            // lblTypValue
            // 
            lblTypValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTypValue.AutoSize = true;
            lblTypValue.Location = new Point(61, 1);
            lblTypValue.Margin = new Padding(0);
            lblTypValue.Name = "lblTypValue";
            lblTypValue.Size = new Size(35, 15);
            lblTypValue.TabIndex = 2;
            lblTypValue.Text = "Value";
            lblTypValue.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTokens
            // 
            lblTokens.Dock = DockStyle.Bottom;
            lblTokens.Location = new Point(0, 113);
            lblTokens.Margin = new Padding(0);
            lblTokens.Name = "lblTokens";
            lblTokens.Size = new Size(96, 15);
            lblTokens.TabIndex = 3;
            lblTokens.Text = "Tokens";
            lblTokens.TextAlign = ContentAlignment.BottomCenter;
            // 
            // CardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTokens);
            Controls.Add(lblTypValue);
            Controls.Add(lblHeadline);
            Controls.Add(pictureBox1);
            Margin = new Padding(0);
            Name = "CardView";
            Size = new Size(96, 128);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblHeadline;
        private Label lblTypValue;
        private ToolTip toolTip;
        private Label lblTokens;
    }
}
