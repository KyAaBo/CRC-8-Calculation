namespace CRC8Calculation
{
    partial class CRCTestGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRCTestGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.selectedFileText = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openFileButton = new System.Windows.Forms.ToolStripButton();
            this.selectedFileName = new System.Windows.Forms.TextBox();
            this.helpButton = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateCrcButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.crcDecimal = new System.Windows.Forms.TextBox();
            this.crcHex = new System.Windows.Forms.TextBox();
            this.crcOctal = new System.Windows.Forms.TextBox();
            this.crcBinary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contents of selected file..";
            // 
            // selectedFileText
            // 
            this.selectedFileText.Location = new System.Drawing.Point(13, 64);
            this.selectedFileText.Multiline = true;
            this.selectedFileText.Name = "selectedFileText";
            this.selectedFileText.ReadOnly = true;
            this.selectedFileText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.selectedFileText.Size = new System.Drawing.Size(251, 160);
            this.selectedFileText.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileButton,
            this.helpButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(511, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openFileButton
            // 
            this.openFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openFileButton.Image = ((System.Drawing.Image)(resources.GetObject("openFileButton.Image")));
            this.openFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(23, 22);
            this.openFileButton.Text = "Open File";
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // selectedFileName
            // 
            this.selectedFileName.Location = new System.Drawing.Point(87, 24);
            this.selectedFileName.Name = "selectedFileName";
            this.selectedFileName.ReadOnly = true;
            this.selectedFileName.Size = new System.Drawing.Size(177, 20);
            this.selectedFileName.TabIndex = 5;
            // 
            // helpButton
            // 
            this.helpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(23, 22);
            this.helpButton.Text = "Help";
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selected File:";
            // 
            // calculateCrcButton
            // 
            this.calculateCrcButton.Location = new System.Drawing.Point(405, 19);
            this.calculateCrcButton.Name = "calculateCrcButton";
            this.calculateCrcButton.Size = new System.Drawing.Size(94, 25);
            this.calculateCrcButton.TabIndex = 7;
            this.calculateCrcButton.Text = "Calculate CRC";
            this.calculateCrcButton.UseVisualStyleBackColor = true;
            this.calculateCrcButton.Click += new System.EventHandler(this.calculateCrcButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "CRC Results:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crcDecimal
            // 
            this.crcDecimal.Location = new System.Drawing.Point(348, 98);
            this.crcDecimal.Name = "crcDecimal";
            this.crcDecimal.ReadOnly = true;
            this.crcDecimal.Size = new System.Drawing.Size(151, 20);
            this.crcDecimal.TabIndex = 10;
            // 
            // crcHex
            // 
            this.crcHex.Location = new System.Drawing.Point(348, 124);
            this.crcHex.Name = "crcHex";
            this.crcHex.ReadOnly = true;
            this.crcHex.Size = new System.Drawing.Size(151, 20);
            this.crcHex.TabIndex = 11;
            // 
            // crcOctal
            // 
            this.crcOctal.Location = new System.Drawing.Point(348, 150);
            this.crcOctal.Name = "crcOctal";
            this.crcOctal.ReadOnly = true;
            this.crcOctal.Size = new System.Drawing.Size(151, 20);
            this.crcOctal.TabIndex = 12;
            // 
            // crcBinary
            // 
            this.crcBinary.Location = new System.Drawing.Point(348, 176);
            this.crcBinary.Name = "crcBinary";
            this.crcBinary.ReadOnly = true;
            this.crcBinary.Size = new System.Drawing.Size(151, 20);
            this.crcBinary.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Decimal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Hex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Octal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Binary";
            // 
            // CRCTestGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 236);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.crcBinary);
            this.Controls.Add(this.crcOctal);
            this.Controls.Add(this.crcHex);
            this.Controls.Add(this.crcDecimal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculateCrcButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedFileName);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.selectedFileText);
            this.Controls.Add(this.label1);
            this.Name = "CRCTestGUI";
            this.Text = "CRC8 Test Application";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selectedFileText;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton openFileButton;
        private System.Windows.Forms.ToolStripButton helpButton;
        private System.Windows.Forms.TextBox selectedFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateCrcButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox crcDecimal;
        private System.Windows.Forms.TextBox crcHex;
        private System.Windows.Forms.TextBox crcOctal;
        private System.Windows.Forms.TextBox crcBinary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

