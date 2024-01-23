namespace FacadeRepairUI
{
    partial class FacadeViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacadeViewerForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.facadeNameValue = new System.Windows.Forms.Label();
            this.objectInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.damageTypeValue = new System.Windows.Forms.Label();
            this.objectOwnerValue = new System.Windows.Forms.Label();
            this.objectAddressValue = new System.Windows.Forms.Label();
            this.damageTypeLabel = new System.Windows.Forms.Label();
            this.objectOwnerLabel = new System.Windows.Forms.Label();
            this.objectAddressLabel = new System.Windows.Forms.Label();
            this.objectNameValue = new System.Windows.Forms.Label();
            this.objectNameLabel = new System.Windows.Forms.Label();
            this.facadeRepresentationLabel = new System.Windows.Forms.Label();
            this.facadeRepresentationPicturebox = new System.Windows.Forms.PictureBox();
            this.editFacadeButton = new System.Windows.Forms.Button();
            this.polygonsListBox = new System.Windows.Forms.ListBox();
            this.polygonsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.objectInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facadeRepresentationPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(137, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Facade:";
            // 
            // facadeNameValue
            // 
            this.facadeNameValue.AutoSize = true;
            this.facadeNameValue.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.facadeNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.facadeNameValue.Location = new System.Drawing.Point(155, 9);
            this.facadeNameValue.Name = "facadeNameValue";
            this.facadeNameValue.Size = new System.Drawing.Size(150, 50);
            this.facadeNameValue.TabIndex = 1;
            this.facadeNameValue.Text = "<none>";
            // 
            // objectInfoGroupBox
            // 
            this.objectInfoGroupBox.Controls.Add(this.damageTypeValue);
            this.objectInfoGroupBox.Controls.Add(this.objectOwnerValue);
            this.objectInfoGroupBox.Controls.Add(this.objectAddressValue);
            this.objectInfoGroupBox.Controls.Add(this.damageTypeLabel);
            this.objectInfoGroupBox.Controls.Add(this.objectOwnerLabel);
            this.objectInfoGroupBox.Controls.Add(this.objectAddressLabel);
            this.objectInfoGroupBox.Controls.Add(this.objectNameValue);
            this.objectInfoGroupBox.Controls.Add(this.objectNameLabel);
            this.objectInfoGroupBox.Location = new System.Drawing.Point(666, 119);
            this.objectInfoGroupBox.Name = "objectInfoGroupBox";
            this.objectInfoGroupBox.Size = new System.Drawing.Size(394, 296);
            this.objectInfoGroupBox.TabIndex = 2;
            this.objectInfoGroupBox.TabStop = false;
            this.objectInfoGroupBox.Text = "Object Info";
            // 
            // damageTypeValue
            // 
            this.damageTypeValue.AutoSize = true;
            this.damageTypeValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.damageTypeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.damageTypeValue.Location = new System.Drawing.Point(275, 227);
            this.damageTypeValue.Name = "damageTypeValue";
            this.damageTypeValue.Size = new System.Drawing.Size(113, 37);
            this.damageTypeValue.TabIndex = 14;
            this.damageTypeValue.Text = "<none>";
            // 
            // objectOwnerValue
            // 
            this.objectOwnerValue.AutoSize = true;
            this.objectOwnerValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.objectOwnerValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.objectOwnerValue.Location = new System.Drawing.Point(275, 168);
            this.objectOwnerValue.Name = "objectOwnerValue";
            this.objectOwnerValue.Size = new System.Drawing.Size(113, 37);
            this.objectOwnerValue.TabIndex = 13;
            this.objectOwnerValue.Text = "<none>";
            // 
            // objectAddressValue
            // 
            this.objectAddressValue.AutoSize = true;
            this.objectAddressValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.objectAddressValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.objectAddressValue.Location = new System.Drawing.Point(275, 109);
            this.objectAddressValue.Name = "objectAddressValue";
            this.objectAddressValue.Size = new System.Drawing.Size(113, 37);
            this.objectAddressValue.TabIndex = 12;
            this.objectAddressValue.Text = "<none>";
            // 
            // damageTypeLabel
            // 
            this.damageTypeLabel.AutoSize = true;
            this.damageTypeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.damageTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.damageTypeLabel.Location = new System.Drawing.Point(15, 227);
            this.damageTypeLabel.Name = "damageTypeLabel";
            this.damageTypeLabel.Size = new System.Drawing.Size(221, 37);
            this.damageTypeLabel.TabIndex = 11;
            this.damageTypeLabel.Text = "Type Of Damage:";
            // 
            // objectOwnerLabel
            // 
            this.objectOwnerLabel.AutoSize = true;
            this.objectOwnerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.objectOwnerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.objectOwnerLabel.Location = new System.Drawing.Point(15, 168);
            this.objectOwnerLabel.Name = "objectOwnerLabel";
            this.objectOwnerLabel.Size = new System.Drawing.Size(186, 37);
            this.objectOwnerLabel.TabIndex = 10;
            this.objectOwnerLabel.Text = "Object Owner:";
            // 
            // objectAddressLabel
            // 
            this.objectAddressLabel.AutoSize = true;
            this.objectAddressLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.objectAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.objectAddressLabel.Location = new System.Drawing.Point(15, 109);
            this.objectAddressLabel.Name = "objectAddressLabel";
            this.objectAddressLabel.Size = new System.Drawing.Size(202, 37);
            this.objectAddressLabel.TabIndex = 9;
            this.objectAddressLabel.Text = "Object Address:";
            // 
            // objectNameValue
            // 
            this.objectNameValue.AutoSize = true;
            this.objectNameValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.objectNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.objectNameValue.Location = new System.Drawing.Point(275, 50);
            this.objectNameValue.Name = "objectNameValue";
            this.objectNameValue.Size = new System.Drawing.Size(113, 37);
            this.objectNameValue.TabIndex = 4;
            this.objectNameValue.Text = "<none>";
            // 
            // objectNameLabel
            // 
            this.objectNameLabel.AutoSize = true;
            this.objectNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.objectNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.objectNameLabel.Location = new System.Drawing.Point(15, 50);
            this.objectNameLabel.Name = "objectNameLabel";
            this.objectNameLabel.Size = new System.Drawing.Size(179, 37);
            this.objectNameLabel.TabIndex = 3;
            this.objectNameLabel.Text = "Object Name:";
            // 
            // facadeRepresentationLabel
            // 
            this.facadeRepresentationLabel.AutoSize = true;
            this.facadeRepresentationLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.facadeRepresentationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.facadeRepresentationLabel.Location = new System.Drawing.Point(12, 71);
            this.facadeRepresentationLabel.Name = "facadeRepresentationLabel";
            this.facadeRepresentationLabel.Size = new System.Drawing.Size(284, 37);
            this.facadeRepresentationLabel.TabIndex = 4;
            this.facadeRepresentationLabel.Text = "Facade Representation";
            // 
            // facadeRepresentationPicturebox
            // 
            this.facadeRepresentationPicturebox.BackColor = System.Drawing.Color.Silver;
            this.facadeRepresentationPicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.facadeRepresentationPicturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.facadeRepresentationPicturebox.Location = new System.Drawing.Point(4, 119);
            this.facadeRepresentationPicturebox.Name = "facadeRepresentationPicturebox";
            this.facadeRepresentationPicturebox.Size = new System.Drawing.Size(630, 872);
            this.facadeRepresentationPicturebox.TabIndex = 5;
            this.facadeRepresentationPicturebox.TabStop = false;
            // 
            // editFacadeButton
            // 
            this.editFacadeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.editFacadeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.editFacadeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.editFacadeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editFacadeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editFacadeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.editFacadeButton.Location = new System.Drawing.Point(751, 796);
            this.editFacadeButton.Name = "editFacadeButton";
            this.editFacadeButton.Size = new System.Drawing.Size(225, 59);
            this.editFacadeButton.TabIndex = 15;
            this.editFacadeButton.Text = "Edit Facade";
            this.editFacadeButton.UseVisualStyleBackColor = true;
            // 
            // polygonsListBox
            // 
            this.polygonsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.polygonsListBox.FormattingEnabled = true;
            this.polygonsListBox.ItemHeight = 30;
            this.polygonsListBox.Location = new System.Drawing.Point(666, 458);
            this.polygonsListBox.Name = "polygonsListBox";
            this.polygonsListBox.Size = new System.Drawing.Size(394, 332);
            this.polygonsListBox.TabIndex = 17;
            // 
            // polygonsLabel
            // 
            this.polygonsLabel.AutoSize = true;
            this.polygonsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.polygonsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.polygonsLabel.Location = new System.Drawing.Point(671, 418);
            this.polygonsLabel.Name = "polygonsLabel";
            this.polygonsLabel.Size = new System.Drawing.Size(125, 37);
            this.polygonsLabel.TabIndex = 16;
            this.polygonsLabel.Text = "Polygons";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(712, 912);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 79);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calculate Price";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FacadeViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 1011);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.polygonsListBox);
            this.Controls.Add(this.polygonsLabel);
            this.Controls.Add(this.editFacadeButton);
            this.Controls.Add(this.facadeRepresentationPicturebox);
            this.Controls.Add(this.facadeRepresentationLabel);
            this.Controls.Add(this.objectInfoGroupBox);
            this.Controls.Add(this.facadeNameValue);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FacadeViewerForm";
            this.Text = "Facade Viewer";
            this.objectInfoGroupBox.ResumeLayout(false);
            this.objectInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facadeRepresentationPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label facadeNameValue;
        private System.Windows.Forms.GroupBox objectInfoGroupBox;
        private System.Windows.Forms.Label objectNameValue;
        private System.Windows.Forms.Label objectNameLabel;
        private System.Windows.Forms.Label damageTypeValue;
        private System.Windows.Forms.Label objectOwnerValue;
        private System.Windows.Forms.Label objectAddressValue;
        private System.Windows.Forms.Label damageTypeLabel;
        private System.Windows.Forms.Label objectOwnerLabel;
        private System.Windows.Forms.Label objectAddressLabel;
        private System.Windows.Forms.Label facadeRepresentationLabel;
        private System.Windows.Forms.PictureBox facadeRepresentationPicturebox;
        private System.Windows.Forms.Button editFacadeButton;
        private System.Windows.Forms.ListBox polygonsListBox;
        private System.Windows.Forms.Label polygonsLabel;
        private System.Windows.Forms.Button button1;
    }
}

