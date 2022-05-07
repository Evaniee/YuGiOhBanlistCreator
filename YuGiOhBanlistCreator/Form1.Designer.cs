namespace YuGiOhBanlistCreator
{
    partial class Form1
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
            this.sfd_saveList = new System.Windows.Forms.SaveFileDialog();
            this.ofd_openList = new System.Windows.Forms.OpenFileDialog();
            this.dgv_forbidden = new System.Windows.Forms.DataGridView();
            this.col_nameBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_idBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forbiddenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limitedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semiLimitedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_limited = new System.Windows.Forms.DataGridView();
            this.col_nameLim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_idLim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_semi = new System.Windows.Forms.DataGridView();
            this.col_nameSemi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_idSemi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_cards = new System.Windows.Forms.DataGridView();
            this.col_nameCards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_idCards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_forbidden)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_limited)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_semi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cards)).BeginInit();
            this.SuspendLayout();
            // 
            // sfd_saveList
            // 
            this.sfd_saveList.Title = "Save Banlist File";
            this.sfd_saveList.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // ofd_openList
            // 
            this.ofd_openList.Title = "Open Banlist File";
            this.ofd_openList.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // dgv_forbidden
            // 
            this.dgv_forbidden.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.dgv_forbidden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_forbidden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nameBan,
            this.col_idBan});
            this.dgv_forbidden.Location = new System.Drawing.Point(10, 25);
            this.dgv_forbidden.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_forbidden.Name = "dgv_forbidden";
            this.dgv_forbidden.RowTemplate.Height = 25;
            this.dgv_forbidden.Size = new System.Drawing.Size(250, 350);
            this.dgv_forbidden.TabIndex = 0;
            // 
            // col_nameBan
            // 
            this.col_nameBan.HeaderText = "Name";
            this.col_nameBan.Name = "col_nameBan";
            // 
            // col_idBan
            // 
            this.col_idBan.HeaderText = "ID";
            this.col_idBan.Name = "col_idBan";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forbiddenToolStripMenuItem,
            this.limitedToolStripMenuItem,
            this.semiLimitedToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // forbiddenToolStripMenuItem
            // 
            this.forbiddenToolStripMenuItem.Name = "forbiddenToolStripMenuItem";
            this.forbiddenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.forbiddenToolStripMenuItem.Text = "Forbidden";
            this.forbiddenToolStripMenuItem.Click += new System.EventHandler(this.forbiddenToolStripMenuItem_Click);
            // 
            // limitedToolStripMenuItem
            // 
            this.limitedToolStripMenuItem.Name = "limitedToolStripMenuItem";
            this.limitedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.limitedToolStripMenuItem.Text = "Limited";
            this.limitedToolStripMenuItem.Click += new System.EventHandler(this.limitedToolStripMenuItem_Click);
            // 
            // semiLimitedToolStripMenuItem
            // 
            this.semiLimitedToolStripMenuItem.Name = "semiLimitedToolStripMenuItem";
            this.semiLimitedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.semiLimitedToolStripMenuItem.Text = "Semi-Limited";
            this.semiLimitedToolStripMenuItem.Click += new System.EventHandler(this.semiLimitedToolStripMenuItem_Click);
            // 
            // dgv_limited
            // 
            this.dgv_limited.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(155)))));
            this.dgv_limited.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_limited.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nameLim,
            this.col_idLim});
            this.dgv_limited.Location = new System.Drawing.Point(270, 25);
            this.dgv_limited.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_limited.Name = "dgv_limited";
            this.dgv_limited.RowTemplate.Height = 25;
            this.dgv_limited.Size = new System.Drawing.Size(250, 350);
            this.dgv_limited.TabIndex = 2;
            // 
            // col_nameLim
            // 
            this.col_nameLim.HeaderText = "Name";
            this.col_nameLim.Name = "col_nameLim";
            // 
            // col_idLim
            // 
            this.col_idLim.HeaderText = "ID";
            this.col_idLim.Name = "col_idLim";
            // 
            // dgv_semi
            // 
            this.dgv_semi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(255)))), ((int)(((byte)(155)))));
            this.dgv_semi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_semi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nameSemi,
            this.col_idSemi});
            this.dgv_semi.Location = new System.Drawing.Point(530, 25);
            this.dgv_semi.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_semi.Name = "dgv_semi";
            this.dgv_semi.RowTemplate.Height = 25;
            this.dgv_semi.Size = new System.Drawing.Size(250, 350);
            this.dgv_semi.TabIndex = 3;
            // 
            // col_nameSemi
            // 
            this.col_nameSemi.HeaderText = "Name";
            this.col_nameSemi.Name = "col_nameSemi";
            // 
            // col_idSemi
            // 
            this.col_idSemi.HeaderText = "ID";
            this.col_idSemi.Name = "col_idSemi";
            // 
            // dgv_cards
            // 
            this.dgv_cards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nameCards,
            this.col_idCards});
            this.dgv_cards.Location = new System.Drawing.Point(790, 60);
            this.dgv_cards.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_cards.Name = "dgv_cards";
            this.dgv_cards.RowTemplate.Height = 25;
            this.dgv_cards.Size = new System.Drawing.Size(250, 315);
            this.dgv_cards.TabIndex = 4;
            // 
            // col_nameCards
            // 
            this.col_nameCards.HeaderText = "Name";
            this.col_nameCards.Name = "col_nameCards";
            this.col_nameCards.Width = 150;
            // 
            // col_idCards
            // 
            this.col_idCards.HeaderText = "ID";
            this.col_idCards.Name = "col_idCards";
            this.col_idCards.Width = 50;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(790, 26);
            this.txt_search.Margin = new System.Windows.Forms.Padding(0);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(170, 23);
            this.txt_search.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(965, 25);
            this.btn_search.Margin = new System.Windows.Forms.Padding(0);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 25);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 391);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_cards);
            this.Controls.Add(this.dgv_semi);
            this.Controls.Add(this.dgv_limited);
            this.Controls.Add(this.dgv_forbidden);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_forbidden)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_limited)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_semi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SaveFileDialog sfd_saveList;
        private OpenFileDialog ofd_openList;
        private DataGridView dgv_forbidden;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem forbiddenToolStripMenuItem;
        private ToolStripMenuItem limitedToolStripMenuItem;
        private ToolStripMenuItem semiLimitedToolStripMenuItem;
        private DataGridView dgv_limited;
        private DataGridView dgv_semi;
        private DataGridView dgv_cards;
        private TextBox txt_search;
        private DataGridViewTextBoxColumn col_nameBan;
        private DataGridViewTextBoxColumn col_idBan;
        private DataGridViewTextBoxColumn col_nameLim;
        private DataGridViewTextBoxColumn col_idLim;
        private DataGridViewTextBoxColumn col_nameSemi;
        private DataGridViewTextBoxColumn col_idSemi;
        private Button btn_search;
        private DataGridViewTextBoxColumn col_nameCards;
        private DataGridViewTextBoxColumn col_idCards;
    }
}