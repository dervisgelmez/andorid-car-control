namespace Frankenstein
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
            this.downArrow = new System.Windows.Forms.Label();
            this.leftArrow = new System.Windows.Forms.Label();
            this.rightArrow = new System.Windows.Forms.Label();
            this.upArrow = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.controlText = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.stop = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cm = new MaterialSkin.Controls.MaterialLabel();
            this.reverse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // downArrow
            // 
            this.downArrow.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.downArrow.Font = new System.Drawing.Font("Arimo", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.downArrow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.downArrow.Location = new System.Drawing.Point(382, 438);
            this.downArrow.Name = "downArrow";
            this.downArrow.Padding = new System.Windows.Forms.Padding(20);
            this.downArrow.Size = new System.Drawing.Size(69, 69);
            this.downArrow.TabIndex = 12;
            this.downArrow.Text = "S";
            this.downArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.downArrow.Click += new System.EventHandler(this.downArrow_Click);
            // 
            // leftArrow
            // 
            this.leftArrow.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.leftArrow.Font = new System.Drawing.Font("Arimo", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.leftArrow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leftArrow.Location = new System.Drawing.Point(287, 438);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Padding = new System.Windows.Forms.Padding(20);
            this.leftArrow.Size = new System.Drawing.Size(70, 69);
            this.leftArrow.TabIndex = 10;
            this.leftArrow.Text = "A";
            this.leftArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.leftArrow.Click += new System.EventHandler(this.leftArrow_Click);
            // 
            // rightArrow
            // 
            this.rightArrow.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rightArrow.Font = new System.Drawing.Font("Arimo", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rightArrow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rightArrow.Location = new System.Drawing.Point(472, 438);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Padding = new System.Windows.Forms.Padding(20);
            this.rightArrow.Size = new System.Drawing.Size(70, 69);
            this.rightArrow.TabIndex = 11;
            this.rightArrow.Text = "D";
            this.rightArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rightArrow.Click += new System.EventHandler(this.rightArrow_Click);
            // 
            // upArrow
            // 
            this.upArrow.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.upArrow.Font = new System.Drawing.Font("Arimo", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.upArrow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.upArrow.Location = new System.Drawing.Point(380, 354);
            this.upArrow.Name = "upArrow";
            this.upArrow.Padding = new System.Windows.Forms.Padding(20);
            this.upArrow.Size = new System.Drawing.Size(76, 69);
            this.upArrow.TabIndex = 9;
            this.upArrow.Text = "W";
            this.upArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.upArrow.Click += new System.EventHandler(this.upArrow_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(477, 78);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(65, 36);
            this.materialFlatButton1.TabIndex = 14;
            this.materialFlatButton1.Text = "bağlan";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(342, 78);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(118, 36);
            this.materialFlatButton2.TabIndex = 15;
            this.materialFlatButton2.Text = "bağlantıyı kes";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // controlText
            // 
            this.controlText.AutoSize = true;
            this.controlText.BackColor = System.Drawing.Color.Transparent;
            this.controlText.Font = new System.Drawing.Font("Roboto Bk", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.controlText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.controlText.Location = new System.Drawing.Point(7, 4);
            this.controlText.Name = "controlText";
            this.controlText.Size = new System.Drawing.Size(173, 15);
            this.controlText.TabIndex = 13;
            this.controlText.Text = "Şuanda bağlantı bulunmuyor";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 329);
            this.listBox1.TabIndex = 16;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(151, 471);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(70, 36);
            this.materialFlatButton3.TabIndex = 17;
            this.materialFlatButton3.Text = "çalıştır";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Komut Satırı";
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Location = new System.Drawing.Point(14, 471);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(67, 36);
            this.materialFlatButton4.TabIndex = 19;
            this.materialFlatButton4.Text = "Temizle";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            this.materialFlatButton4.Click += new System.EventHandler(this.materialFlatButton4_Click);
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Location = new System.Drawing.Point(89, 471);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(54, 36);
            this.materialFlatButton5.TabIndex = 20;
            this.materialFlatButton5.Text = "Azalt";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            this.materialFlatButton5.Click += new System.EventHandler(this.materialFlatButton5_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.stop.Font = new System.Drawing.Font("Arimo", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stop.Location = new System.Drawing.Point(287, 354);
            this.stop.Name = "stop";
            this.stop.Padding = new System.Windows.Forms.Padding(20);
            this.stop.Size = new System.Drawing.Size(70, 69);
            this.stop.TabIndex = 21;
            this.stop.Text = "Q";
            this.stop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(338, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mesafe Sensörü";
            // 
            // materialLabel1
            // 
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(383, 172);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 22);
            this.materialLabel1.TabIndex = 27;
            this.materialLabel1.Text = "0";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cm
            // 
            this.cm.BackColor = System.Drawing.Color.Transparent;
            this.cm.Depth = 0;
            this.cm.Font = new System.Drawing.Font("Roboto", 11F);
            this.cm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cm.Location = new System.Drawing.Point(490, 166);
            this.cm.MouseState = MaterialSkin.MouseState.HOVER;
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(52, 30);
            this.cm.TabIndex = 28;
            this.cm.Text = "cm";
            this.cm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reverse
            // 
            this.reverse.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.reverse.Font = new System.Drawing.Font("Arimo", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reverse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reverse.Location = new System.Drawing.Point(472, 354);
            this.reverse.Name = "reverse";
            this.reverse.Padding = new System.Windows.Forms.Padding(20);
            this.reverse.Size = new System.Drawing.Size(70, 69);
            this.reverse.TabIndex = 29;
            this.reverse.Text = "R";
            this.reverse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reverse.Click += new System.EventHandler(this.reverse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 538);
            this.Controls.Add(this.reverse);
            this.Controls.Add(this.cm);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.materialFlatButton5);
            this.Controls.Add(this.materialFlatButton4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.controlText);
            this.Controls.Add(this.downArrow);
            this.Controls.Add(this.leftArrow);
            this.Controls.Add(this.rightArrow);
            this.Controls.Add(this.upArrow);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Frankenstein";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label downArrow;
        private System.Windows.Forms.Label leftArrow;
        private System.Windows.Forms.Label rightArrow;
        private System.Windows.Forms.Label upArrow;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.Label controlText;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ListBox listBox1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private System.Windows.Forms.Label stop;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Timer timer1;
        private MaterialSkin.Controls.MaterialLabel cm;
        private System.Windows.Forms.Label reverse;

    }
}

