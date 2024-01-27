namespace FacadeRepairUI
{
    partial class BoundingBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoundingBoxForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.bbRepresentationPictureBox = new System.Windows.Forms.PictureBox();
            this.bbRepresentationLabel = new System.Windows.Forms.Label();
            this.bbInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.bbPerimeterLabel = new System.Windows.Forms.Label();
            this.bbDiametreValue = new System.Windows.Forms.Label();
            this.bbPerimeterValue = new System.Windows.Forms.Label();
            this.bbSurfaceAreaValue = new System.Windows.Forms.Label();
            this.bbSurfaceAreaLabel = new System.Windows.Forms.Label();
            this.bbDiametreLabel = new System.Windows.Forms.Label();
            this.bbPointsListBox = new System.Windows.Forms.ListBox();
            this.bbPointsLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bbRepresentationPictureBox)).BeginInit();
            this.bbInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(239, 50);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "Bounding Box";
            // 
            // bbRepresentationPictureBox
            // 
            this.bbRepresentationPictureBox.BackColor = System.Drawing.Color.Silver;
            this.bbRepresentationPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bbRepresentationPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bbRepresentationPictureBox.Location = new System.Drawing.Point(19, 120);
            this.bbRepresentationPictureBox.Name = "bbRepresentationPictureBox";
            this.bbRepresentationPictureBox.Size = new System.Drawing.Size(630, 850);
            this.bbRepresentationPictureBox.TabIndex = 9;
            this.bbRepresentationPictureBox.TabStop = false;
            this.bbRepresentationPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.bbRepresentationPictureBox_Paint);
            // 
            // bbRepresentationLabel
            // 
            this.bbRepresentationLabel.AutoSize = true;
            this.bbRepresentationLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bbRepresentationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.bbRepresentationLabel.Location = new System.Drawing.Point(27, 72);
            this.bbRepresentationLabel.Name = "bbRepresentationLabel";
            this.bbRepresentationLabel.Size = new System.Drawing.Size(367, 37);
            this.bbRepresentationLabel.TabIndex = 8;
            this.bbRepresentationLabel.Text = "Bounding Box Representation";
            // 
            // bbInfoGroupBox
            // 
            this.bbInfoGroupBox.Controls.Add(this.bbPerimeterLabel);
            this.bbInfoGroupBox.Controls.Add(this.bbDiametreValue);
            this.bbInfoGroupBox.Controls.Add(this.bbPerimeterValue);
            this.bbInfoGroupBox.Controls.Add(this.bbSurfaceAreaValue);
            this.bbInfoGroupBox.Controls.Add(this.bbSurfaceAreaLabel);
            this.bbInfoGroupBox.Controls.Add(this.bbDiametreLabel);
            this.bbInfoGroupBox.Location = new System.Drawing.Point(744, 120);
            this.bbInfoGroupBox.Name = "bbInfoGroupBox";
            this.bbInfoGroupBox.Size = new System.Drawing.Size(495, 212);
            this.bbInfoGroupBox.TabIndex = 27;
            this.bbInfoGroupBox.TabStop = false;
            this.bbInfoGroupBox.Text = "Bounding Box Info";
            // 
            // bbPerimeterLabel
            // 
            this.bbPerimeterLabel.AutoSize = true;
            this.bbPerimeterLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bbPerimeterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.bbPerimeterLabel.Location = new System.Drawing.Point(6, 49);
            this.bbPerimeterLabel.Name = "bbPerimeterLabel";
            this.bbPerimeterLabel.Size = new System.Drawing.Size(308, 37);
            this.bbPerimeterLabel.TabIndex = 19;
            this.bbPerimeterLabel.Text = "Bounding Box Perimeter:";
            // 
            // bbDiametreValue
            // 
            this.bbDiametreValue.AutoSize = true;
            this.bbDiametreValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bbDiametreValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.bbDiametreValue.Location = new System.Drawing.Point(354, 167);
            this.bbDiametreValue.Name = "bbDiametreValue";
            this.bbDiametreValue.Size = new System.Drawing.Size(113, 37);
            this.bbDiametreValue.TabIndex = 24;
            this.bbDiametreValue.Text = "<none>";
            // 
            // bbPerimeterValue
            // 
            this.bbPerimeterValue.AutoSize = true;
            this.bbPerimeterValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bbPerimeterValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.bbPerimeterValue.Location = new System.Drawing.Point(354, 49);
            this.bbPerimeterValue.Name = "bbPerimeterValue";
            this.bbPerimeterValue.Size = new System.Drawing.Size(113, 37);
            this.bbPerimeterValue.TabIndex = 20;
            this.bbPerimeterValue.Text = "<none>";
            // 
            // bbSurfaceAreaValue
            // 
            this.bbSurfaceAreaValue.AutoSize = true;
            this.bbSurfaceAreaValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bbSurfaceAreaValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.bbSurfaceAreaValue.Location = new System.Drawing.Point(354, 108);
            this.bbSurfaceAreaValue.Name = "bbSurfaceAreaValue";
            this.bbSurfaceAreaValue.Size = new System.Drawing.Size(113, 37);
            this.bbSurfaceAreaValue.TabIndex = 23;
            this.bbSurfaceAreaValue.Text = "<none>";
            // 
            // bbSurfaceAreaLabel
            // 
            this.bbSurfaceAreaLabel.AutoSize = true;
            this.bbSurfaceAreaLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bbSurfaceAreaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.bbSurfaceAreaLabel.Location = new System.Drawing.Point(6, 108);
            this.bbSurfaceAreaLabel.Name = "bbSurfaceAreaLabel";
            this.bbSurfaceAreaLabel.Size = new System.Drawing.Size(342, 37);
            this.bbSurfaceAreaLabel.TabIndex = 21;
            this.bbSurfaceAreaLabel.Text = "Bounding Box Surface Area:";
            // 
            // bbDiametreLabel
            // 
            this.bbDiametreLabel.AutoSize = true;
            this.bbDiametreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bbDiametreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.bbDiametreLabel.Location = new System.Drawing.Point(6, 167);
            this.bbDiametreLabel.Name = "bbDiametreLabel";
            this.bbDiametreLabel.Size = new System.Drawing.Size(304, 37);
            this.bbDiametreLabel.TabIndex = 22;
            this.bbDiametreLabel.Text = "Bounding Box Diameter:";
            // 
            // bbPointsListBox
            // 
            this.bbPointsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bbPointsListBox.FormattingEnabled = true;
            this.bbPointsListBox.ItemHeight = 30;
            this.bbPointsListBox.Location = new System.Drawing.Point(744, 411);
            this.bbPointsListBox.Name = "bbPointsListBox";
            this.bbPointsListBox.Size = new System.Drawing.Size(495, 212);
            this.bbPointsListBox.TabIndex = 30;
            // 
            // bbPointsLabel
            // 
            this.bbPointsLabel.AutoSize = true;
            this.bbPointsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bbPointsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.bbPointsLabel.Location = new System.Drawing.Point(750, 371);
            this.bbPointsLabel.Name = "bbPointsLabel";
            this.bbPointsLabel.Size = new System.Drawing.Size(261, 37);
            this.bbPointsLabel.TabIndex = 29;
            this.bbPointsLabel.Text = "Bounding Box Points";
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18.25F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.backButton.Location = new System.Drawing.Point(1102, 920);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(150, 50);
            this.backButton.TabIndex = 31;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // BoundingBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 981);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.bbPointsListBox);
            this.Controls.Add(this.bbPointsLabel);
            this.Controls.Add(this.bbInfoGroupBox);
            this.Controls.Add(this.bbRepresentationPictureBox);
            this.Controls.Add(this.bbRepresentationLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "BoundingBoxForm";
            this.Text = "Bounding Box";
            ((System.ComponentModel.ISupportInitialize)(this.bbRepresentationPictureBox)).EndInit();
            this.bbInfoGroupBox.ResumeLayout(false);
            this.bbInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.PictureBox bbRepresentationPictureBox;
        private System.Windows.Forms.Label bbRepresentationLabel;
        private System.Windows.Forms.GroupBox bbInfoGroupBox;
        private System.Windows.Forms.Label bbPerimeterLabel;
        private System.Windows.Forms.Label bbDiametreValue;
        private System.Windows.Forms.Label bbPerimeterValue;
        private System.Windows.Forms.Label bbSurfaceAreaValue;
        private System.Windows.Forms.Label bbSurfaceAreaLabel;
        private System.Windows.Forms.Label bbDiametreLabel;
        private System.Windows.Forms.ListBox bbPointsListBox;
        private System.Windows.Forms.Label bbPointsLabel;
        private System.Windows.Forms.Button backButton;
    }
}