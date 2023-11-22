namespace ProtoWayfarer
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            szenarioToolStripMenuItem = new ToolStripMenuItem();
            neuToolStripMenuItem = new ToolStripMenuItem();
            speichernToolStripMenuItem = new ToolStripMenuItem();
            ladenToolStripMenuItem = new ToolStripMenuItem();
            spielBeendenToolStripMenuItem = new ToolStripMenuItem();
            charaktereToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            mentalLoadToolStripMenuItem = new ToolStripMenuItem();
            rulesOfEngagementToolStripMenuItem = new ToolStripMenuItem();
            wayfarersCortexToolStripMenuItem = new ToolStripMenuItem();
            cardView1 = new Cards.CardView();
            flpCardPanelTest = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { szenarioToolStripMenuItem, charaktereToolStripMenuItem, wayfarersCortexToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // szenarioToolStripMenuItem
            // 
            szenarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { neuToolStripMenuItem, speichernToolStripMenuItem, ladenToolStripMenuItem, spielBeendenToolStripMenuItem });
            szenarioToolStripMenuItem.Name = "szenarioToolStripMenuItem";
            szenarioToolStripMenuItem.Size = new Size(63, 20);
            szenarioToolStripMenuItem.Text = "Szenario";
            // 
            // neuToolStripMenuItem
            // 
            neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            neuToolStripMenuItem.Size = new Size(148, 22);
            neuToolStripMenuItem.Text = "Neu";
            // 
            // speichernToolStripMenuItem
            // 
            speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            speichernToolStripMenuItem.Size = new Size(148, 22);
            speichernToolStripMenuItem.Text = "Speichern";
            // 
            // ladenToolStripMenuItem
            // 
            ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
            ladenToolStripMenuItem.Size = new Size(148, 22);
            ladenToolStripMenuItem.Text = "Laden";
            // 
            // spielBeendenToolStripMenuItem
            // 
            spielBeendenToolStripMenuItem.Name = "spielBeendenToolStripMenuItem";
            spielBeendenToolStripMenuItem.Size = new Size(148, 22);
            spielBeendenToolStripMenuItem.Text = "Spiel beenden";
            // 
            // charaktereToolStripMenuItem
            // 
            charaktereToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inventoryToolStripMenuItem, mentalLoadToolStripMenuItem, rulesOfEngagementToolStripMenuItem });
            charaktereToolStripMenuItem.Name = "charaktereToolStripMenuItem";
            charaktereToolStripMenuItem.Size = new Size(70, 20);
            charaktereToolStripMenuItem.Text = "Charakter";
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(186, 22);
            inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // mentalLoadToolStripMenuItem
            // 
            mentalLoadToolStripMenuItem.Name = "mentalLoadToolStripMenuItem";
            mentalLoadToolStripMenuItem.Size = new Size(186, 22);
            mentalLoadToolStripMenuItem.Text = "Mental Loadout";
            // 
            // rulesOfEngagementToolStripMenuItem
            // 
            rulesOfEngagementToolStripMenuItem.Name = "rulesOfEngagementToolStripMenuItem";
            rulesOfEngagementToolStripMenuItem.Size = new Size(186, 22);
            rulesOfEngagementToolStripMenuItem.Text = "Rules of Engagement";
            // 
            // wayfarersCortexToolStripMenuItem
            // 
            wayfarersCortexToolStripMenuItem.Name = "wayfarersCortexToolStripMenuItem";
            wayfarersCortexToolStripMenuItem.Size = new Size(109, 20);
            wayfarersCortexToolStripMenuItem.Text = "Wayfarers Cortex";
            // 
            // cardView1
            // 
            cardView1.Location = new Point(76, 67);
            cardView1.Margin = new Padding(0);
            cardView1.MyCard = null;
            cardView1.Name = "cardView1";
            cardView1.Size = new Size(150, 150);
            cardView1.TabIndex = 1;
            // 
            // flpCardPanelTest
            // 
            flpCardPanelTest.Location = new Point(334, 111);
            flpCardPanelTest.Name = "flpCardPanelTest";
            flpCardPanelTest.Size = new Size(454, 327);
            flpCardPanelTest.TabIndex = 2;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpCardPanelTest);
            Controls.Add(cardView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainScreen";
            Text = "Wayfarer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem szenarioToolStripMenuItem;
        private ToolStripMenuItem neuToolStripMenuItem;
        private ToolStripMenuItem speichernToolStripMenuItem;
        private ToolStripMenuItem ladenToolStripMenuItem;
        private ToolStripMenuItem spielBeendenToolStripMenuItem;
        private ToolStripMenuItem charaktereToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem mentalLoadToolStripMenuItem;
        private ToolStripMenuItem rulesOfEngagementToolStripMenuItem;
        private ToolStripMenuItem wayfarersCortexToolStripMenuItem;
        private Cards.CardView cardView1;
        private FlowLayoutPanel flpCardPanelTest;
    }
}