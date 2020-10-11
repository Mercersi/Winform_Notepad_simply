namespace notepad
{
    partial class Find
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
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Find = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_Replace = new System.Windows.Forms.Button();
            this.txb_Replace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_ReplaceAll = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find:";
            // 
            // txb_Find
            // 
            this.txb_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Find.Location = new System.Drawing.Point(140, 39);
            this.txb_Find.Name = "txb_Find";
            this.txb_Find.Size = new System.Drawing.Size(224, 26);
            this.txb_Find.TabIndex = 1;
            // 
            // btn_Find
            // 
            this.btn_Find.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.Location = new System.Drawing.Point(386, 12);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(105, 32);
            this.btn_Find.TabIndex = 2;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_Replace
            // 
            this.btn_Replace.Enabled = false;
            this.btn_Replace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Replace.Location = new System.Drawing.Point(386, 88);
            this.btn_Replace.Name = "btn_Replace";
            this.btn_Replace.Size = new System.Drawing.Size(105, 32);
            this.btn_Replace.TabIndex = 5;
            this.btn_Replace.Text = "Replace";
            this.btn_Replace.UseVisualStyleBackColor = true;
            this.btn_Replace.Click += new System.EventHandler(this.btn_Replace_Click);
            // 
            // txb_Replace
            // 
            this.txb_Replace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Replace.Location = new System.Drawing.Point(140, 71);
            this.txb_Replace.Name = "txb_Replace";
            this.txb_Replace.Size = new System.Drawing.Size(224, 26);
            this.txb_Replace.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Replace with";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(386, 164);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(105, 32);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_ReplaceAll
            // 
            this.btn_ReplaceAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReplaceAll.Location = new System.Drawing.Point(386, 126);
            this.btn_ReplaceAll.Name = "btn_ReplaceAll";
            this.btn_ReplaceAll.Size = new System.Drawing.Size(105, 32);
            this.btn_ReplaceAll.TabIndex = 6;
            this.btn_ReplaceAll.Text = "Replace All";
            this.btn_ReplaceAll.UseVisualStyleBackColor = true;
            this.btn_ReplaceAll.Click += new System.EventHandler(this.btn_ReplaceAll_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(386, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Find All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_ReplaceAll);
            this.Controls.Add(this.btn_Replace);
            this.Controls.Add(this.txb_Replace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.txb_Find);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Find";
            this.Text = "Find";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Find;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_Replace;
        private System.Windows.Forms.TextBox txb_Replace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_ReplaceAll;
        private System.Windows.Forms.Button button1;
    }
}