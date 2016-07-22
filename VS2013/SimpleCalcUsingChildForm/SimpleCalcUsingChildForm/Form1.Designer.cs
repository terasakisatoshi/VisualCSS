namespace SimpleCalcUsingChildForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuDialogA = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDialogB = new System.Windows.Forms.ToolStripMenuItem();
            this.演算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSub = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMul = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDiv = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDialogA,
            this.menuDialogB,
            this.演算ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuDialogA
            // 
            this.menuDialogA.Name = "menuDialogA";
            this.menuDialogA.Size = new System.Drawing.Size(105, 29);
            this.menuDialogA.Text = "Aの値入力";
            this.menuDialogA.Click += new System.EventHandler(this.menuDialogA_Click);
            // 
            // menuDialogB
            // 
            this.menuDialogB.Name = "menuDialogB";
            this.menuDialogB.Size = new System.Drawing.Size(103, 29);
            this.menuDialogB.Text = "Bの値入力";
            this.menuDialogB.Click += new System.EventHandler(this.menuDialogB_Click);
            // 
            // 演算ToolStripMenuItem
            // 
            this.演算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.menuSub,
            this.menuMul,
            this.menuDiv});
            this.演算ToolStripMenuItem.Name = "演算ToolStripMenuItem";
            this.演算ToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.演算ToolStripMenuItem.Text = "演算";
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(211, 30);
            this.menuAdd.Text = "加算";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // menuSub
            // 
            this.menuSub.Name = "menuSub";
            this.menuSub.Size = new System.Drawing.Size(211, 30);
            this.menuSub.Text = "減算";
            this.menuSub.Click += new System.EventHandler(this.menuSub_Click);
            // 
            // menuMul
            // 
            this.menuMul.Name = "menuMul";
            this.menuMul.Size = new System.Drawing.Size(211, 30);
            this.menuMul.Text = "乗算";
            this.menuMul.Click += new System.EventHandler(this.menuMul_Click);
            // 
            // menuDiv
            // 
            this.menuDiv.Name = "menuDiv";
            this.menuDiv.Size = new System.Drawing.Size(211, 30);
            this.menuDiv.Text = "除算";
            this.menuDiv.Click += new System.EventHandler(this.menuDiv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(530, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 407);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "加減乗除";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDialogA;
        private System.Windows.Forms.ToolStripMenuItem menuDialogB;
        private System.Windows.Forms.ToolStripMenuItem 演算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuSub;
        private System.Windows.Forms.ToolStripMenuItem menuMul;
        private System.Windows.Forms.ToolStripMenuItem menuDiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip2;
    }
}

