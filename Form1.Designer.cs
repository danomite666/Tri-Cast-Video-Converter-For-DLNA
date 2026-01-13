namespace Tri_Cast_Video_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnShowOutput = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btn720p = new System.Windows.Forms.Button();
            this.btn1080p = new System.Windows.Forms.Button();
            this.btn1440p = new System.Windows.Forms.Button();
            this.btn4k = new System.Windows.Forms.Button();
            this.txtCustomBitrate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustomBitrate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Tri_Cast_Video_Converter.Properties.Resources.Yellow;
            this.button1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(429, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 173);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse . . . To Load Video";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtInputFile
            // 
            this.txtInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputFile.Location = new System.Drawing.Point(799, 313);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(2677, 62);
            this.txtInputFile.TabIndex = 1;
            // 
            // Convert
            // 
            this.Convert.BackgroundImage = global::Tri_Cast_Video_Converter.Properties.Resources.Green;
            this.Convert.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert.Location = new System.Drawing.Point(429, 533);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(307, 173);
            this.Convert.TabIndex = 2;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(430, 1731);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(3046, 61);
            this.progressBar1.TabIndex = 3;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(423, 1645);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(252, 48);
            this.lblProgress.TabIndex = 4;
            this.lblProgress.Text = "Progress: 0%";
            // 
            // btnShowOutput
            // 
            this.btnShowOutput.BackgroundImage = global::Tri_Cast_Video_Converter.Properties.Resources.Purple;
            this.btnShowOutput.Enabled = false;
            this.btnShowOutput.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowOutput.Location = new System.Drawing.Point(429, 855);
            this.btnShowOutput.Name = "btnShowOutput";
            this.btnShowOutput.Size = new System.Drawing.Size(307, 173);
            this.btnShowOutput.TabIndex = 5;
            this.btnShowOutput.Text = "Show Output File";
            this.btnShowOutput.UseVisualStyleBackColor = true;
            this.btnShowOutput.Click += new System.EventHandler(this.btnShowOutput_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::Tri_Cast_Video_Converter.Properties.Resources.Peach;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(429, 1175);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(307, 173);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel Conversion";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btn720p
            // 
            this.btn720p.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn720p.Location = new System.Drawing.Point(920, 533);
            this.btn720p.Name = "btn720p";
            this.btn720p.Size = new System.Drawing.Size(307, 173);
            this.btn720p.TabIndex = 7;
            this.btn720p.Text = "720p";
            this.btn720p.UseVisualStyleBackColor = true;
            this.btn720p.Click += new System.EventHandler(this.btn720p_Click_1);
            // 
            // btn1080p
            // 
            this.btn1080p.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1080p.Location = new System.Drawing.Point(1391, 533);
            this.btn1080p.Name = "btn1080p";
            this.btn1080p.Size = new System.Drawing.Size(307, 173);
            this.btn1080p.TabIndex = 8;
            this.btn1080p.Text = "1080p";
            this.btn1080p.UseVisualStyleBackColor = true;
            this.btn1080p.Click += new System.EventHandler(this.btn1080p_Click_1);
            // 
            // btn1440p
            // 
            this.btn1440p.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1440p.Location = new System.Drawing.Point(1869, 533);
            this.btn1440p.Name = "btn1440p";
            this.btn1440p.Size = new System.Drawing.Size(307, 173);
            this.btn1440p.TabIndex = 9;
            this.btn1440p.Text = "1440p";
            this.btn1440p.UseVisualStyleBackColor = true;
            this.btn1440p.Click += new System.EventHandler(this.btn1440p_Click_1);
            // 
            // btn4k
            // 
            this.btn4k.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4k.Location = new System.Drawing.Point(2357, 533);
            this.btn4k.Name = "btn4k";
            this.btn4k.Size = new System.Drawing.Size(307, 173);
            this.btn4k.TabIndex = 10;
            this.btn4k.Text = "4K UHD";
            this.btn4k.UseVisualStyleBackColor = true;
            this.btn4k.Click += new System.EventHandler(this.btn4k_Click);
            // 
            // txtCustomBitrate
            // 
            this.txtCustomBitrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomBitrate.Location = new System.Drawing.Point(2826, 915);
            this.txtCustomBitrate.Name = "txtCustomBitrate";
            this.txtCustomBitrate.Size = new System.Drawing.Size(650, 53);
            this.txtCustomBitrate.TabIndex = 11;
            this.txtCustomBitrate.Text = "\"Enter bitrate in kbps (e.g., 12000k)\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2818, 866);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Custom Bitrate:";
            // 
            // btnCustomBitrate
            // 
            this.btnCustomBitrate.BackgroundImage = global::Tri_Cast_Video_Converter.Properties.Resources.Pink;
            this.btnCustomBitrate.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomBitrate.Location = new System.Drawing.Point(2826, 533);
            this.btnCustomBitrate.Name = "btnCustomBitrate";
            this.btnCustomBitrate.Size = new System.Drawing.Size(307, 173);
            this.btnCustomBitrate.TabIndex = 13;
            this.btnCustomBitrate.Text = "Use Custom Bitrate";
            this.btnCustomBitrate.UseVisualStyleBackColor = true;
            this.btnCustomBitrate.Click += new System.EventHandler(this.btnCustomBitrate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JUICE Light Italic", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2901, 72);
            this.label2.TabIndex = 14;
            this.label2.Text = "THIS IS A STRAIGHT ACROSS FIXED RESOLUTION VARIABLE BITRATE VIDEO CONVERTER FOR D" +
    "LNA.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JUICE Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1383, 915);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(509, 44);
            this.label3.TabIndex = 15;
            this.label3.Text = "1. Load Video To Convert.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JUICE Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1383, 1025);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(715, 44);
            this.label4.TabIndex = 16;
            this.label4.Text = "2. Select Resolution Of Input Video,";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JUICE Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1383, 1197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(608, 44);
            this.label5.TabIndex = 17;
            this.label5.Text = "3. Press The \"Convert\" Button.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JUICE Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1383, 1316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(839, 44);
            this.label6.TabIndex = 18;
            this.label6.Text = "4. Click On The \"Show Output File\" Button.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("JUICE Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1383, 1431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1367, 44);
            this.label7.TabIndex = 19;
            this.label7.Text = "5. The Converted File Is Now Ready To Stream With The Tri Cast App.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("JUICE Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1426, 1086);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(639, 44);
            this.label8.TabIndex = 20;
            this.label8.Text = "Or Choose \"Use Custom Bitrate\"";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2818, 748);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(511, 46);
            this.label9.TabIndex = 21;
            this.label9.Text = "Enter Custom Bitrate Below";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2818, 994);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(566, 46);
            this.label10.TabIndex = 22;
            this.label10.Text = "Then Click Use Custom Bitrate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2818, 1058);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(565, 46);
            this.label11.TabIndex = 23;
            this.label11.Text = "Then Click The Convert Button";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1668, 456);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(708, 46);
            this.label12.TabIndex = 24;
            this.label12.Text = "Bitrate Settings For Resolution Presets";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1005, 748);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 46);
            this.label13.TabIndex = 25;
            this.label13.Text = "7760k";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1463, 748);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 46);
            this.label14.TabIndex = 26;
            this.label14.Text = "12000k";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1948, 748);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 46);
            this.label15.TabIndex = 27;
            this.label15.Text = "18000k";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(2434, 748);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 46);
            this.label16.TabIndex = 28;
            this.label16.Text = "28000k";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("JUICE Regular", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(912, 1549);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(2338, 44);
            this.label17.TabIndex = 29;
            this.label17.Text = "NOTE:  THIS IS NOT A VIDEO RE-SIZER.  IT WILL NOT CHANGE THE INPUT VIDEOS ASPECT " +
    "RATIO OR ALTER THE RESOLUTION.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("JUICE Regular", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(912, 217);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(2234, 44);
            this.label18.TabIndex = 30;
            this.label18.Text = "CONVERT ANY RESOLUTION VIDEO INTO ANY BITRATE DESIRED FOR A DLNA STREAMING COMPAT" +
    "IBLE VIDEO FORMAT.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1772, 1868);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(526, 37);
            this.label19.TabIndex = 31;
            this.label19.Text = "© 2026 Tri Cast. All rights reserved.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(3844, 1914);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCustomBitrate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomBitrate);
            this.Controls.Add(this.btn4k);
            this.Controls.Add(this.btn1440p);
            this.Controls.Add(this.btn1080p);
            this.Controls.Add(this.btn720p);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnShowOutput);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.txtInputFile);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Tri Cast Video Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnShowOutput;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btn720p;
        private System.Windows.Forms.Button btn1080p;
        private System.Windows.Forms.Button btn1440p;
        private System.Windows.Forms.Button btn4k;
        private System.Windows.Forms.TextBox txtCustomBitrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCustomBitrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}

