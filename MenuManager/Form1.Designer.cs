namespace MenuManager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.startMenuFilterInput = new System.Windows.Forms.TextBox();
            this.startMenuListView = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(855, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.startMenuFilterInput);
            this.tabPage2.Controls.Add(this.startMenuListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(847, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "开始菜单管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "过滤";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // startMenuFilterInput
            // 
            this.startMenuFilterInput.Location = new System.Drawing.Point(66, 24);
            this.startMenuFilterInput.Name = "startMenuFilterInput";
            this.startMenuFilterInput.Size = new System.Drawing.Size(564, 21);
            this.startMenuFilterInput.TabIndex = 1;
            this.startMenuFilterInput.TextChanged += new System.EventHandler(this.startMenuFilterInput_TextChanged);
            this.startMenuFilterInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.startMenuFilterInput_KeyUp);
            // 
            // startMenuListView
            // 
            this.startMenuListView.Location = new System.Drawing.Point(26, 51);
            this.startMenuListView.Name = "startMenuListView";
            this.startMenuListView.ShowItemToolTips = true;
            this.startMenuListView.Size = new System.Drawing.Size(791, 302);
            this.startMenuListView.TabIndex = 0;
            this.startMenuListView.UseCompatibleStateImageBehavior = false;
            this.startMenuListView.View = System.Windows.Forms.View.Details;
            this.startMenuListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.startMenuListView_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "打开文件夹";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox startMenuFilterInput;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

        private System.Windows.Forms.ListView startMenuListView;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;

        #endregion
    }
}