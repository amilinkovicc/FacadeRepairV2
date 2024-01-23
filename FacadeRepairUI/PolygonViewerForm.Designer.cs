namespace FacadeRepairUI
{
    partial class PolygonViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolygonViewerForm));
            this.facadeNameValue = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.polygonRepresentationPicturebox = new System.Windows.Forms.PictureBox();
            this.polygonRepresentationLabel = new System.Windows.Forms.Label();
            this.polygonInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.polygonPerimeterLabel = new System.Windows.Forms.Label();
            this.polygonDiametreValue = new System.Windows.Forms.Label();
            this.polygonPerimeterValue = new System.Windows.Forms.Label();
            this.objectAddressValue = new System.Windows.Forms.Label();
            this.polygonSurfaceAreaLabel = new System.Windows.Forms.Label();
            this.polygonDiametreLabel = new System.Windows.Forms.Label();
            this.pointsListBox = new System.Windows.Forms.ListBox();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.editPolygonButton = new System.Windows.Forms.Button();
            this.boundingBoxButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.polygonRepresentationPicturebox)).BeginInit();
            this.polygonInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // facadeNameValue
            // 
            this.facadeNameValue.AutoSize = true;
            this.facadeNameValue.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.facadeNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.facadeNameValue.Location = new System.Drawing.Point(155, 9);
            this.facadeNameValue.Name = "facadeNameValue";
            this.facadeNameValue.Size = new System.Drawing.Size(150, 50);
            this.facadeNameValue.TabIndex = 3;
            this.facadeNameValue.Text = "<none>";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(156, 50);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Polygon:";
            // 
            // polygonRepresentationPicturebox
            // 
            this.polygonRepresentationPicturebox.BackColor = System.Drawing.Color.Silver;
            this.polygonRepresentationPicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.polygonRepresentationPicturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.polygonRepresentationPicturebox.Location = new System.Drawing.Point(22, 125);
            this.polygonRepresentationPicturebox.Name = "polygonRepresentationPicturebox";
            this.polygonRepresentationPicturebox.Size = new System.Drawing.Size(630, 850);
            this.polygonRepresentationPicturebox.TabIndex = 7;
            this.polygonRepresentationPicturebox.TabStop = false;
            // 
            // polygonRepresentationLabel
            // 
            this.polygonRepresentationLabel.AutoSize = true;
            this.polygonRepresentationLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.polygonRepresentationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.polygonRepresentationLabel.Location = new System.Drawing.Point(30, 77);
            this.polygonRepresentationLabel.Name = "polygonRepresentationLabel";
            this.polygonRepresentationLabel.Size = new System.Drawing.Size(299, 37);
            this.polygonRepresentationLabel.TabIndex = 6;
            this.polygonRepresentationLabel.Text = "Polygon Representation";
            // 
            // polygonInfoGroupBox
            // 
            this.polygonInfoGroupBox.Controls.Add(this.polygonPerimeterLabel);
            this.polygonInfoGroupBox.Controls.Add(this.polygonDiametreValue);
            this.polygonInfoGroupBox.Controls.Add(this.polygonPerimeterValue);
            this.polygonInfoGroupBox.Controls.Add(this.objectAddressValue);
            this.polygonInfoGroupBox.Controls.Add(this.polygonSurfaceAreaLabel);
            this.polygonInfoGroupBox.Controls.Add(this.polygonDiametreLabel);
            this.polygonInfoGroupBox.Location = new System.Drawing.Point(714, 125);
            this.polygonInfoGroupBox.Name = "polygonInfoGroupBox";
            this.polygonInfoGroupBox.Size = new System.Drawing.Size(437, 212);
            this.polygonInfoGroupBox.TabIndex = 26;
            this.polygonInfoGroupBox.TabStop = false;
            this.polygonInfoGroupBox.Text = "Polygon Info";
            // 
            // polygonPerimeterLabel
            // 
            this.polygonPerimeterLabel.AutoSize = true;
            this.polygonPerimeterLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.polygonPerimeterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.polygonPerimeterLabel.Location = new System.Drawing.Point(6, 49);
            this.polygonPerimeterLabel.Name = "polygonPerimeterLabel";
            this.polygonPerimeterLabel.Size = new System.Drawing.Size(240, 37);
            this.polygonPerimeterLabel.TabIndex = 19;
            this.polygonPerimeterLabel.Text = "Polygon Perimeter:";
            // 
            // polygonDiametreValue
            // 
            this.polygonDiametreValue.AutoSize = true;
            this.polygonDiametreValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.polygonDiametreValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.polygonDiametreValue.Location = new System.Drawing.Point(324, 167);
            this.polygonDiametreValue.Name = "polygonDiametreValue";
            this.polygonDiametreValue.Size = new System.Drawing.Size(113, 37);
            this.polygonDiametreValue.TabIndex = 24;
            this.polygonDiametreValue.Text = "<none>";
            // 
            // polygonPerimeterValue
            // 
            this.polygonPerimeterValue.AutoSize = true;
            this.polygonPerimeterValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.polygonPerimeterValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.polygonPerimeterValue.Location = new System.Drawing.Point(324, 49);
            this.polygonPerimeterValue.Name = "polygonPerimeterValue";
            this.polygonPerimeterValue.Size = new System.Drawing.Size(113, 37);
            this.polygonPerimeterValue.TabIndex = 20;
            this.polygonPerimeterValue.Text = "<none>";
            // 
            // objectAddressValue
            // 
            this.objectAddressValue.AutoSize = true;
            this.objectAddressValue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.objectAddressValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.objectAddressValue.Location = new System.Drawing.Point(324, 108);
            this.objectAddressValue.Name = "objectAddressValue";
            this.objectAddressValue.Size = new System.Drawing.Size(113, 37);
            this.objectAddressValue.TabIndex = 23;
            this.objectAddressValue.Text = "<none>";
            // 
            // polygonSurfaceAreaLabel
            // 
            this.polygonSurfaceAreaLabel.AutoSize = true;
            this.polygonSurfaceAreaLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.polygonSurfaceAreaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.polygonSurfaceAreaLabel.Location = new System.Drawing.Point(6, 108);
            this.polygonSurfaceAreaLabel.Name = "polygonSurfaceAreaLabel";
            this.polygonSurfaceAreaLabel.Size = new System.Drawing.Size(274, 37);
            this.polygonSurfaceAreaLabel.TabIndex = 21;
            this.polygonSurfaceAreaLabel.Text = "Polygon Surface Area:";
            // 
            // polygonDiametreLabel
            // 
            this.polygonDiametreLabel.AutoSize = true;
            this.polygonDiametreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.polygonDiametreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.polygonDiametreLabel.Location = new System.Drawing.Point(6, 167);
            this.polygonDiametreLabel.Name = "polygonDiametreLabel";
            this.polygonDiametreLabel.Size = new System.Drawing.Size(236, 37);
            this.polygonDiametreLabel.TabIndex = 22;
            this.polygonDiametreLabel.Text = "Polygon Diameter:";
            // 
            // pointsListBox
            // 
            this.pointsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pointsListBox.FormattingEnabled = true;
            this.pointsListBox.ItemHeight = 30;
            this.pointsListBox.Location = new System.Drawing.Point(714, 409);
            this.pointsListBox.Name = "pointsListBox";
            this.pointsListBox.Size = new System.Drawing.Size(437, 212);
            this.pointsListBox.TabIndex = 28;
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.pointsLabel.Location = new System.Drawing.Point(720, 369);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(89, 37);
            this.pointsLabel.TabIndex = 27;
            this.pointsLabel.Text = "Points";
            // 
            // editPolygonButton
            // 
            this.editPolygonButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.editPolygonButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.editPolygonButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.editPolygonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPolygonButton.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editPolygonButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.editPolygonButton.Location = new System.Drawing.Point(820, 694);
            this.editPolygonButton.Name = "editPolygonButton";
            this.editPolygonButton.Size = new System.Drawing.Size(225, 59);
            this.editPolygonButton.TabIndex = 29;
            this.editPolygonButton.Text = "Edit Polygon";
            this.editPolygonButton.UseVisualStyleBackColor = true;
            // 
            // boundingBoxButton
            // 
            this.boundingBoxButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.boundingBoxButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.boundingBoxButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.boundingBoxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boundingBoxButton.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boundingBoxButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.boundingBoxButton.Location = new System.Drawing.Point(820, 826);
            this.boundingBoxButton.Name = "boundingBoxButton";
            this.boundingBoxButton.Size = new System.Drawing.Size(225, 59);
            this.boundingBoxButton.TabIndex = 30;
            this.boundingBoxButton.Text = "BoundingBox";
            this.boundingBoxButton.UseVisualStyleBackColor = true;
            // 
            // PolygonViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 981);
            this.Controls.Add(this.boundingBoxButton);
            this.Controls.Add(this.editPolygonButton);
            this.Controls.Add(this.pointsListBox);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.polygonInfoGroupBox);
            this.Controls.Add(this.polygonRepresentationPicturebox);
            this.Controls.Add(this.polygonRepresentationLabel);
            this.Controls.Add(this.facadeNameValue);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "PolygonViewerForm";
            this.Text = "Polygon Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.polygonRepresentationPicturebox)).EndInit();
            this.polygonInfoGroupBox.ResumeLayout(false);
            this.polygonInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label facadeNameValue;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.PictureBox polygonRepresentationPicturebox;
        private System.Windows.Forms.Label polygonRepresentationLabel;
        private System.Windows.Forms.GroupBox polygonInfoGroupBox;
        private System.Windows.Forms.Label polygonPerimeterLabel;
        private System.Windows.Forms.Label polygonDiametreValue;
        private System.Windows.Forms.Label polygonPerimeterValue;
        private System.Windows.Forms.Label objectAddressValue;
        private System.Windows.Forms.Label polygonSurfaceAreaLabel;
        private System.Windows.Forms.Label polygonDiametreLabel;
        private System.Windows.Forms.ListBox pointsListBox;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Button editPolygonButton;
        private System.Windows.Forms.Button boundingBoxButton;
    }
}