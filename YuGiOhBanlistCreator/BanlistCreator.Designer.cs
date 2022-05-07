namespace YuGiOhBanlistCreator
{
    partial class BanlistCreator
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
            this.mnu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_file_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_file_open_add = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_file_open_load = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_file_saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_view = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_view_0 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_view_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_view_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_view_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_category1 = new System.Windows.Forms.ComboBox();
            this.lbl_category1 = new System.Windows.Forms.Label();
            this.cmb_category2 = new System.Windows.Forms.ComboBox();
            this.lbl_category2 = new System.Windows.Forms.Label();
            this.lbl_attribute = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.cmb_attribute = new System.Windows.Forms.ComboBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.dgv_limit = new System.Windows.Forms.DataGridView();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_limit)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_file,
            this.mnu_view});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu_file
            // 
            this.mnu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_file_new,
            this.mnu_file_open,
            this.mnu_file_saveAs,
            this.mnu_file_exit});
            this.mnu_file.Name = "mnu_file";
            this.mnu_file.Size = new System.Drawing.Size(37, 20);
            this.mnu_file.Text = "File";
            // 
            // mnu_file_new
            // 
            this.mnu_file_new.Name = "mnu_file_new";
            this.mnu_file_new.Size = new System.Drawing.Size(180, 22);
            this.mnu_file_new.Text = "New";
            // 
            // mnu_file_open
            // 
            this.mnu_file_open.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_file_open_add,
            this.mnu_file_open_load});
            this.mnu_file_open.Name = "mnu_file_open";
            this.mnu_file_open.Size = new System.Drawing.Size(180, 22);
            this.mnu_file_open.Text = "Open";
            // 
            // mnu_file_open_add
            // 
            this.mnu_file_open_add.Name = "mnu_file_open_add";
            this.mnu_file_open_add.Size = new System.Drawing.Size(180, 22);
            this.mnu_file_open_add.Text = "Add";
            this.mnu_file_open_add.Click += new System.EventHandler(this.mnu_file_open_add_Click);
            // 
            // mnu_file_open_load
            // 
            this.mnu_file_open_load.Name = "mnu_file_open_load";
            this.mnu_file_open_load.Size = new System.Drawing.Size(180, 22);
            this.mnu_file_open_load.Text = "Load";
            this.mnu_file_open_load.Click += new System.EventHandler(this.mnu_file_open_load_Click);
            // 
            // mnu_file_saveAs
            // 
            this.mnu_file_saveAs.Name = "mnu_file_saveAs";
            this.mnu_file_saveAs.Size = new System.Drawing.Size(180, 22);
            this.mnu_file_saveAs.Text = "Save As";
            // 
            // mnu_file_exit
            // 
            this.mnu_file_exit.Name = "mnu_file_exit";
            this.mnu_file_exit.Size = new System.Drawing.Size(180, 22);
            this.mnu_file_exit.Text = "Exit";
            // 
            // mnu_view
            // 
            this.mnu_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_view_0,
            this.mnu_view_1,
            this.mnu_view_2,
            this.mnu_view_3});
            this.mnu_view.Name = "mnu_view";
            this.mnu_view.Size = new System.Drawing.Size(44, 20);
            this.mnu_view.Text = "View";
            // 
            // mnu_view_0
            // 
            this.mnu_view_0.Name = "mnu_view_0";
            this.mnu_view_0.Size = new System.Drawing.Size(145, 22);
            this.mnu_view_0.Text = "Forbidden";
            // 
            // mnu_view_1
            // 
            this.mnu_view_1.Name = "mnu_view_1";
            this.mnu_view_1.Size = new System.Drawing.Size(145, 22);
            this.mnu_view_1.Text = "Limited";
            // 
            // mnu_view_2
            // 
            this.mnu_view_2.Name = "mnu_view_2";
            this.mnu_view_2.Size = new System.Drawing.Size(145, 22);
            this.mnu_view_2.Text = "Semi-Limited";
            // 
            // mnu_view_3
            // 
            this.mnu_view_3.Name = "mnu_view_3";
            this.mnu_view_3.Size = new System.Drawing.Size(145, 22);
            this.mnu_view_3.Text = "Unlimited";
            // 
            // cmb_category1
            // 
            this.cmb_category1.FormattingEnabled = true;
            this.cmb_category1.Location = new System.Drawing.Point(131, 27);
            this.cmb_category1.Name = "cmb_category1";
            this.cmb_category1.Size = new System.Drawing.Size(200, 23);
            this.cmb_category1.TabIndex = 2;
            // 
            // lbl_category1
            // 
            this.lbl_category1.AutoSize = true;
            this.lbl_category1.Location = new System.Drawing.Point(26, 30);
            this.lbl_category1.Name = "lbl_category1";
            this.lbl_category1.Size = new System.Drawing.Size(99, 15);
            this.lbl_category1.TabIndex = 3;
            this.lbl_category1.Text = "Primary Category";
            // 
            // cmb_category2
            // 
            this.cmb_category2.FormattingEnabled = true;
            this.cmb_category2.Location = new System.Drawing.Point(131, 56);
            this.cmb_category2.Name = "cmb_category2";
            this.cmb_category2.Size = new System.Drawing.Size(200, 23);
            this.cmb_category2.TabIndex = 4;
            // 
            // lbl_category2
            // 
            this.lbl_category2.AutoSize = true;
            this.lbl_category2.Location = new System.Drawing.Point(12, 59);
            this.lbl_category2.Name = "lbl_category2";
            this.lbl_category2.Size = new System.Drawing.Size(113, 15);
            this.lbl_category2.TabIndex = 5;
            this.lbl_category2.Text = "Secondary Category";
            // 
            // lbl_attribute
            // 
            this.lbl_attribute.AutoSize = true;
            this.lbl_attribute.Location = new System.Drawing.Point(337, 59);
            this.lbl_attribute.Name = "lbl_attribute";
            this.lbl_attribute.Size = new System.Drawing.Size(54, 15);
            this.lbl_attribute.TabIndex = 6;
            this.lbl_attribute.Text = "Attribute";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(360, 30);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(31, 15);
            this.lbl_type.TabIndex = 7;
            this.lbl_type.Text = "Type";
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(397, 27);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(120, 23);
            this.cmb_type.TabIndex = 8;
            // 
            // cmb_attribute
            // 
            this.cmb_attribute.FormattingEnabled = true;
            this.cmb_attribute.Location = new System.Drawing.Point(397, 56);
            this.cmb_attribute.Name = "cmb_attribute";
            this.cmb_attribute.Size = new System.Drawing.Size(120, 23);
            this.cmb_attribute.TabIndex = 9;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(632, 55);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(713, 55);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(632, 26);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(156, 23);
            this.txt_name.TabIndex = 12;
            // 
            // dgv_limit
            // 
            this.dgv_limit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_limit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_name});
            this.dgv_limit.Location = new System.Drawing.Point(12, 85);
            this.dgv_limit.Name = "dgv_limit";
            this.dgv_limit.RowTemplate.Height = 25;
            this.dgv_limit.Size = new System.Drawing.Size(394, 353);
            this.dgv_limit.TabIndex = 13;
            // 
            // col_name
            // 
            this.col_name.HeaderText = "Name";
            this.col_name.Name = "col_name";
            this.col_name.Width = 350;
            // 
            // BanlistCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_limit);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cmb_attribute);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_attribute);
            this.Controls.Add(this.lbl_category2);
            this.Controls.Add(this.cmb_category2);
            this.Controls.Add(this.lbl_category1);
            this.Controls.Add(this.cmb_category1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BanlistCreator";
            this.Text = "BanlistCreator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_limit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnu_file;
        private ToolStripMenuItem mnu_file_new;
        private ToolStripMenuItem mnu_file_open;
        private ToolStripMenuItem mnu_file_saveAs;
        private ToolStripMenuItem mnu_file_exit;
        private ToolStripMenuItem mnu_view;
        private ToolStripMenuItem mnu_view_0;
        private ToolStripMenuItem mnu_view_1;
        private ToolStripMenuItem mnu_view_2;
        private ComboBox cmb_category1;
        private Label lbl_category1;
        private ComboBox cmb_category2;
        private Label lbl_category2;
        private Label lbl_attribute;
        private Label lbl_type;
        private ComboBox cmb_type;
        private ComboBox cmb_attribute;
        private Button btn_clear;
        private Button btn_search;
        private TextBox txt_name;
        private ToolStripMenuItem mnu_file_open_add;
        private ToolStripMenuItem mnu_file_open_load;
        private ToolStripMenuItem mnu_view_3;
        private DataGridView dgv_limit;
        private DataGridViewTextBoxColumn col_name;
    }
}