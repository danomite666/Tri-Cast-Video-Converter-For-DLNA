namespace Tri_Cast_Video_Converter
{
    partial class LicenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseForm));
            this.richTextBoxLicense = new System.Windows.Forms.RichTextBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxLicense
            // 
            this.richTextBoxLicense.Location = new System.Drawing.Point(184, 139);
            this.richTextBoxLicense.Name = "richTextBoxLicense";
            this.richTextBoxLicense.Size = new System.Drawing.Size(1421, 1228);
            this.richTextBoxLicense.TabIndex = 0;
            this.richTextBoxLicense.Text = "";
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackgroundImage = global::Tri_Cast_Video_Converter.Properties.Resources.Green;
            this.buttonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccept.Location = new System.Drawing.Point(689, 480);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(385, 115);
            this.buttonAccept.TabIndex = 1;
            this.buttonAccept.Text = "I Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click_1);
            // 
            // LicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2515, 1618);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.richTextBoxLicense);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LicenseForm";
            this.Text = "License Agreement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxLicense;
        private System.Windows.Forms.Button buttonAccept;
    }
}