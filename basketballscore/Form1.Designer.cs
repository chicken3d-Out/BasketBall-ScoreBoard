
namespace basketballscore
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
            this.txt_Score1 = new System.Windows.Forms.TextBox();
            this.txt_Score2 = new System.Windows.Forms.TextBox();
            this.btn_add1 = new System.Windows.Forms.Button();
            this.btn_add2 = new System.Windows.Forms.Button();
            this.btn_add3 = new System.Windows.Forms.Button();
            this.btn_minus1 = new System.Windows.Forms.Button();
            this.btn_minus2 = new System.Windows.Forms.Button();
            this.btn_minus3 = new System.Windows.Forms.Button();
            this.lbl_Team1 = new System.Windows.Forms.Label();
            this.lbl_Team2 = new System.Windows.Forms.Label();
            this.btn_Plus1B = new System.Windows.Forms.Button();
            this.btn_Plus2B = new System.Windows.Forms.Button();
            this.btn_Plus3B = new System.Windows.Forms.Button();
            this.btn_Minus1B = new System.Windows.Forms.Button();
            this.btn_Minus2B = new System.Windows.Forms.Button();
            this.btn_Minus3B = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.resetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Score1
            // 
            this.txt_Score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txt_Score1.ForeColor = System.Drawing.Color.Maroon;
            this.txt_Score1.Location = new System.Drawing.Point(150, 103);
            this.txt_Score1.Name = "txt_Score1";
            this.txt_Score1.Size = new System.Drawing.Size(82, 53);
            this.txt_Score1.TabIndex = 0;
            this.txt_Score1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Score1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Score1_KeyDown);
            // 
            // txt_Score2
            // 
            this.txt_Score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txt_Score2.ForeColor = System.Drawing.Color.Maroon;
            this.txt_Score2.Location = new System.Drawing.Point(400, 103);
            this.txt_Score2.Name = "txt_Score2";
            this.txt_Score2.Size = new System.Drawing.Size(82, 53);
            this.txt_Score2.TabIndex = 1;
            this.txt_Score2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Score2.TextChanged += new System.EventHandler(this.txt_Score2_TextChanged);
            this.txt_Score2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Score2_KeyDown);
            // 
            // btn_add1
            // 
            this.btn_add1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_add1.Location = new System.Drawing.Point(104, 180);
            this.btn_add1.Name = "btn_add1";
            this.btn_add1.Size = new System.Drawing.Size(65, 48);
            this.btn_add1.TabIndex = 2;
            this.btn_add1.Text = "+1";
            this.btn_add1.UseVisualStyleBackColor = true;
            this.btn_add1.Click += new System.EventHandler(this.btn_add1_Click);
            // 
            // btn_add2
            // 
            this.btn_add2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_add2.Location = new System.Drawing.Point(104, 234);
            this.btn_add2.Name = "btn_add2";
            this.btn_add2.Size = new System.Drawing.Size(65, 48);
            this.btn_add2.TabIndex = 3;
            this.btn_add2.Text = "+2";
            this.btn_add2.UseVisualStyleBackColor = true;
            this.btn_add2.Click += new System.EventHandler(this.btn_add2_Click);
            // 
            // btn_add3
            // 
            this.btn_add3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_add3.Location = new System.Drawing.Point(104, 288);
            this.btn_add3.Name = "btn_add3";
            this.btn_add3.Size = new System.Drawing.Size(65, 48);
            this.btn_add3.TabIndex = 4;
            this.btn_add3.Text = "+3";
            this.btn_add3.UseVisualStyleBackColor = true;
            this.btn_add3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_minus1
            // 
            this.btn_minus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_minus1.Location = new System.Drawing.Point(203, 180);
            this.btn_minus1.Name = "btn_minus1";
            this.btn_minus1.Size = new System.Drawing.Size(65, 48);
            this.btn_minus1.TabIndex = 5;
            this.btn_minus1.Text = "-1";
            this.btn_minus1.UseVisualStyleBackColor = true;
            this.btn_minus1.Click += new System.EventHandler(this.btn_minus1_Click);
            // 
            // btn_minus2
            // 
            this.btn_minus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_minus2.Location = new System.Drawing.Point(203, 234);
            this.btn_minus2.Name = "btn_minus2";
            this.btn_minus2.Size = new System.Drawing.Size(65, 48);
            this.btn_minus2.TabIndex = 6;
            this.btn_minus2.Text = "-2";
            this.btn_minus2.UseVisualStyleBackColor = true;
            this.btn_minus2.Click += new System.EventHandler(this.btn_minus2_Click);
            // 
            // btn_minus3
            // 
            this.btn_minus3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_minus3.Location = new System.Drawing.Point(203, 288);
            this.btn_minus3.Name = "btn_minus3";
            this.btn_minus3.Size = new System.Drawing.Size(65, 48);
            this.btn_minus3.TabIndex = 7;
            this.btn_minus3.Text = "-3";
            this.btn_minus3.UseVisualStyleBackColor = true;
            this.btn_minus3.Click += new System.EventHandler(this.btn_minus3_Click);
            // 
            // lbl_Team1
            // 
            this.lbl_Team1.AutoSize = true;
            this.lbl_Team1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_Team1.Location = new System.Drawing.Point(113, 56);
            this.lbl_Team1.Name = "lbl_Team1";
            this.lbl_Team1.Size = new System.Drawing.Size(0, 31);
            this.lbl_Team1.TabIndex = 14;
            this.lbl_Team1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Team1.Click += new System.EventHandler(this.lbl_Team1_Click);
            // 
            // lbl_Team2
            // 
            this.lbl_Team2.AutoSize = true;
            this.lbl_Team2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_Team2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Team2.Location = new System.Drawing.Point(348, 56);
            this.lbl_Team2.Name = "lbl_Team2";
            this.lbl_Team2.Size = new System.Drawing.Size(0, 31);
            this.lbl_Team2.TabIndex = 15;
            // 
            // btn_Plus1B
            // 
            this.btn_Plus1B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Plus1B.Location = new System.Drawing.Point(354, 180);
            this.btn_Plus1B.Name = "btn_Plus1B";
            this.btn_Plus1B.Size = new System.Drawing.Size(65, 48);
            this.btn_Plus1B.TabIndex = 16;
            this.btn_Plus1B.Text = "+1";
            this.btn_Plus1B.UseVisualStyleBackColor = true;
            this.btn_Plus1B.Click += new System.EventHandler(this.btn_Plus1B_Click);
            // 
            // btn_Plus2B
            // 
            this.btn_Plus2B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Plus2B.Location = new System.Drawing.Point(354, 234);
            this.btn_Plus2B.Name = "btn_Plus2B";
            this.btn_Plus2B.Size = new System.Drawing.Size(65, 48);
            this.btn_Plus2B.TabIndex = 17;
            this.btn_Plus2B.Text = "+2";
            this.btn_Plus2B.UseVisualStyleBackColor = true;
            this.btn_Plus2B.Click += new System.EventHandler(this.btn_Plus2B_Click);
            // 
            // btn_Plus3B
            // 
            this.btn_Plus3B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Plus3B.Location = new System.Drawing.Point(354, 288);
            this.btn_Plus3B.Name = "btn_Plus3B";
            this.btn_Plus3B.Size = new System.Drawing.Size(65, 48);
            this.btn_Plus3B.TabIndex = 18;
            this.btn_Plus3B.Text = "+3";
            this.btn_Plus3B.UseVisualStyleBackColor = true;
            this.btn_Plus3B.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btn_Minus1B
            // 
            this.btn_Minus1B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Minus1B.Location = new System.Drawing.Point(458, 180);
            this.btn_Minus1B.Name = "btn_Minus1B";
            this.btn_Minus1B.Size = new System.Drawing.Size(65, 48);
            this.btn_Minus1B.TabIndex = 19;
            this.btn_Minus1B.Text = "-1";
            this.btn_Minus1B.UseVisualStyleBackColor = true;
            this.btn_Minus1B.Click += new System.EventHandler(this.btn_Minus1B_Click);
            // 
            // btn_Minus2B
            // 
            this.btn_Minus2B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Minus2B.Location = new System.Drawing.Point(458, 234);
            this.btn_Minus2B.Name = "btn_Minus2B";
            this.btn_Minus2B.Size = new System.Drawing.Size(65, 48);
            this.btn_Minus2B.TabIndex = 20;
            this.btn_Minus2B.Text = "-2";
            this.btn_Minus2B.UseVisualStyleBackColor = true;
            this.btn_Minus2B.Click += new System.EventHandler(this.btn_Minus2B_Click);
            // 
            // btn_Minus3B
            // 
            this.btn_Minus3B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Minus3B.Location = new System.Drawing.Point(458, 288);
            this.btn_Minus3B.Name = "btn_Minus3B";
            this.btn_Minus3B.Size = new System.Drawing.Size(65, 48);
            this.btn_Minus3B.TabIndex = 21;
            this.btn_Minus3B.Text = "-3";
            this.btn_Minus3B.UseVisualStyleBackColor = true;
            this.btn_Minus3B.Click += new System.EventHandler(this.btn_Minus3B_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.newMenuItem,
            this.toolStripMenuItem1,
            this.resetMenuItem,
            this.toolStripMenuItem3,
            this.exitMenuItem,
            this.toolStripMenuItem4});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(99, 6);
            // 
            // newMenuItem
            // 
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Size = new System.Drawing.Size(102, 22);
            this.newMenuItem.Text = "New";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 6);
            // 
            // resetMenuItem
            // 
            this.resetMenuItem.Name = "resetMenuItem";
            this.resetMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetMenuItem.Text = "Reset";
            this.resetMenuItem.Click += new System.EventHandler(this.resetMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(99, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(99, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Basketball Scoreboard";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(641, 346);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Minus3B);
            this.Controls.Add(this.btn_Minus2B);
            this.Controls.Add(this.btn_Minus1B);
            this.Controls.Add(this.btn_Plus3B);
            this.Controls.Add(this.btn_Plus2B);
            this.Controls.Add(this.btn_Plus1B);
            this.Controls.Add(this.lbl_Team2);
            this.Controls.Add(this.lbl_Team1);
            this.Controls.Add(this.btn_minus3);
            this.Controls.Add(this.btn_minus2);
            this.Controls.Add(this.btn_minus1);
            this.Controls.Add(this.btn_add3);
            this.Controls.Add(this.btn_add2);
            this.Controls.Add(this.btn_add1);
            this.Controls.Add(this.txt_Score2);
            this.Controls.Add(this.txt_Score1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basketball Score";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Score1;
        private System.Windows.Forms.TextBox txt_Score2;
        private System.Windows.Forms.Button btn_add1;
        private System.Windows.Forms.Button btn_add2;
        private System.Windows.Forms.Button btn_add3;
        private System.Windows.Forms.Button btn_minus1;
        private System.Windows.Forms.Button btn_minus2;
        private System.Windows.Forms.Button btn_minus3;
        private System.Windows.Forms.Label lbl_Team1;
        private System.Windows.Forms.Label lbl_Team2;
        private System.Windows.Forms.Button btn_Plus1B;
        private System.Windows.Forms.Button btn_Plus2B;
        private System.Windows.Forms.Button btn_Plus3B;
        private System.Windows.Forms.Button btn_Minus1B;
        private System.Windows.Forms.Button btn_Minus2B;
        private System.Windows.Forms.Button btn_Minus3B;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.Label label1;
    }
}

