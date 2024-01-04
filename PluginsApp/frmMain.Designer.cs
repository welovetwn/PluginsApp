
namespace PluginsApp
{
    partial class frmMain
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
            label1 = new System.Windows.Forms.Label();
            lstboxPlugins = new System.Windows.Forms.ListBox();
            btnExec = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            btnUnload = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txtOut = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            btnGC = new System.Windows.Forms.Button();
            ckbName = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "外掛程式：";
            // 
            // lstboxPlugins
            // 
            lstboxPlugins.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lstboxPlugins.FormattingEnabled = true;
            lstboxPlugins.ItemHeight = 15;
            lstboxPlugins.Location = new System.Drawing.Point(94, 11);
            lstboxPlugins.Name = "lstboxPlugins";
            lstboxPlugins.Size = new System.Drawing.Size(609, 109);
            lstboxPlugins.TabIndex = 2;
            // 
            // btnExec
            // 
            btnExec.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnExec.Location = new System.Drawing.Point(628, 124);
            btnExec.Name = "btnExec";
            btnExec.Size = new System.Drawing.Size(75, 22);
            btnExec.TabIndex = 3;
            btnExec.Text = "執行外掛";
            btnExec.UseVisualStyleBackColor = true;
            btnExec.Click += btnExec_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(94, 124);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(75, 22);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "載入外掛";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnUnload
            // 
            btnUnload.Location = new System.Drawing.Point(175, 124);
            btnUnload.Name = "btnUnload";
            btnUnload.Size = new System.Drawing.Size(75, 22);
            btnUnload.TabIndex = 4;
            btnUnload.Text = "卸除外掛";
            btnUnload.UseVisualStyleBackColor = true;
            btnUnload.Click += btnUnload_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(36, 150);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "輸  出：";
            // 
            // txtOut
            // 
            txtOut.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtOut.Location = new System.Drawing.Point(95, 150);
            txtOut.Multiline = true;
            txtOut.Name = "txtOut";
            txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtOut.Size = new System.Drawing.Size(608, 237);
            txtOut.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(342, 124);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 22);
            button1.TabIndex = 7;
            button1.Text = "組件輸出";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnGC
            // 
            btnGC.Location = new System.Drawing.Point(461, 124);
            btnGC.Name = "btnGC";
            btnGC.Size = new System.Drawing.Size(94, 22);
            btnGC.TabIndex = 7;
            btnGC.Text = "GC回收";
            btnGC.UseVisualStyleBackColor = true;
            btnGC.Click += btnGC_Click;
            // 
            // ckbName
            // 
            ckbName.AutoSize = true;
            ckbName.Location = new System.Drawing.Point(285, 126);
            ckbName.Name = "ckbName";
            ckbName.Size = new System.Drawing.Size(50, 19);
            ckbName.TabIndex = 8;
            ckbName.Text = "名稱";
            ckbName.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(715, 397);
            Controls.Add(ckbName);
            Controls.Add(btnGC);
            Controls.Add(button1);
            Controls.Add(txtOut);
            Controls.Add(label2);
            Controls.Add(btnUnload);
            Controls.Add(btnLoad);
            Controls.Add(btnExec);
            Controls.Add(lstboxPlugins);
            Controls.Add(label1);
            Name = "frmMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "外掛程式";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstboxPlugins;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnUnload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGC;
        private System.Windows.Forms.CheckBox ckbName;
    }
}

