namespace ProtoWayfarer
{
    partial class LootScreen
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
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            lvLootAvailable = new ListView();
            lvLootTaken = new ListView();
            btnLootTake = new Button();
            btnLootDone = new Button();
            btnLootDorp = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 15);
            label1.TabIndex = 0;
            label1.Text = "Choose Wisely Young Wayfarer";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 37);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(lvLootTaken);
            splitContainer1.Panel1.Controls.Add(lvLootAvailable);
            splitContainer1.Size = new Size(776, 401);
            splitContainer1.SplitterDistance = 544;
            splitContainer1.TabIndex = 1;
            // 
            // lvLootAvailable
            // 
            lvLootAvailable.Location = new Point(3, 3);
            lvLootAvailable.Name = "lvLootAvailable";
            lvLootAvailable.Size = new Size(273, 317);
            lvLootAvailable.TabIndex = 0;
            lvLootAvailable.UseCompatibleStateImageBehavior = false;
            // 
            // lvLootTaken
            // 
            lvLootTaken.Location = new Point(282, 3);
            lvLootTaken.Name = "lvLootTaken";
            lvLootTaken.Size = new Size(259, 317);
            lvLootTaken.TabIndex = 1;
            lvLootTaken.UseCompatibleStateImageBehavior = false;
            // 
            // btnLootTake
            // 
            btnLootTake.Location = new Point(3, 3);
            btnLootTake.Name = "btnLootTake";
            btnLootTake.Size = new Size(168, 71);
            btnLootTake.TabIndex = 2;
            btnLootTake.Text = "Take";
            btnLootTake.UseVisualStyleBackColor = true;
            btnLootTake.Click += button1_Click;
            // 
            // btnLootDone
            // 
            btnLootDone.Location = new Point(186, 3);
            btnLootDone.Name = "btnLootDone";
            btnLootDone.Size = new Size(168, 72);
            btnLootDone.TabIndex = 3;
            btnLootDone.Text = "Done";
            btnLootDone.UseVisualStyleBackColor = true;
            // 
            // btnLootDorp
            // 
            btnLootDorp.Location = new Point(368, 3);
            btnLootDorp.Name = "btnLootDorp";
            btnLootDorp.Size = new Size(168, 72);
            btnLootDorp.TabIndex = 4;
            btnLootDorp.Text = "Drop";
            btnLootDorp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLootDorp);
            panel1.Controls.Add(btnLootDone);
            panel1.Controls.Add(btnLootTake);
            panel1.Location = new Point(3, 323);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 77);
            panel1.TabIndex = 5;
            // 
            // LootScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(label1);
            Name = "LootScreen";
            Text = "LootScreen";
            Load += LootScreen_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private SplitContainer splitContainer1;
        private Button btnLootTake;
        private ListView lvLootTaken;
        private ListView lvLootAvailable;
        private Panel panel1;
        private Button btnLootDorp;
        private Button btnLootDone;
    }
}