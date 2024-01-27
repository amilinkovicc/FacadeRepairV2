namespace FacadeRepairUI
{
    partial class CreatePolygonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePolygonForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.pointsListBox = new System.Windows.Forms.ListBox();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.editPointButton = new System.Windows.Forms.Button();
            this.deletePointButton = new System.Windows.Forms.Button();
            this.createPolygonButton = new System.Windows.Forms.Button();
            this.addPointGroupBox = new System.Windows.Forms.GroupBox();
            this.incorrectYValue = new System.Windows.Forms.Label();
            this.incorrectXValue = new System.Windows.Forms.Label();
            this.addPointButton = new System.Windows.Forms.Button();
            this.yValue = new System.Windows.Forms.TextBox();
            this.xValue = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.addPointGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(259, 50);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Create Polygon";
            // 
            // pointsListBox
            // 
            this.pointsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pointsListBox.FormattingEnabled = true;
            this.pointsListBox.ItemHeight = 30;
            this.pointsListBox.Location = new System.Drawing.Point(10, 115);
            this.pointsListBox.Name = "pointsListBox";
            this.pointsListBox.Size = new System.Drawing.Size(343, 272);
            this.pointsListBox.TabIndex = 13;
            this.pointsListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pointsListBox_MouseClick);
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.pointsLabel.Location = new System.Drawing.Point(14, 75);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(89, 37);
            this.pointsLabel.TabIndex = 12;
            this.pointsLabel.Text = "Points";
            // 
            // editPointButton
            // 
            this.editPointButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.editPointButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.editPointButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.editPointButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPointButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editPointButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.editPointButton.Location = new System.Drawing.Point(35, 227);
            this.editPointButton.Name = "editPointButton";
            this.editPointButton.Size = new System.Drawing.Size(152, 42);
            this.editPointButton.TabIndex = 18;
            this.editPointButton.Text = "Edit Point";
            this.editPointButton.UseVisualStyleBackColor = true;
            this.editPointButton.Click += new System.EventHandler(this.editPointButton_Click);
            // 
            // deletePointButton
            // 
            this.deletePointButton.BackColor = System.Drawing.Color.White;
            this.deletePointButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deletePointButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deletePointButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deletePointButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePointButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deletePointButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deletePointButton.Location = new System.Drawing.Point(175, 393);
            this.deletePointButton.Name = "deletePointButton";
            this.deletePointButton.Size = new System.Drawing.Size(178, 42);
            this.deletePointButton.TabIndex = 17;
            this.deletePointButton.Text = "Delete Point";
            this.deletePointButton.UseVisualStyleBackColor = false;
            this.deletePointButton.Click += new System.EventHandler(this.deletePointButton_Click);
            // 
            // createPolygonButton
            // 
            this.createPolygonButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPolygonButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPolygonButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPolygonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPolygonButton.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createPolygonButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPolygonButton.Location = new System.Drawing.Point(379, 393);
            this.createPolygonButton.Name = "createPolygonButton";
            this.createPolygonButton.Size = new System.Drawing.Size(225, 59);
            this.createPolygonButton.TabIndex = 19;
            this.createPolygonButton.Text = "Create Polygon";
            this.createPolygonButton.UseVisualStyleBackColor = true;
            this.createPolygonButton.Click += new System.EventHandler(this.createPolygonButton_Click);
            // 
            // addPointGroupBox
            // 
            this.addPointGroupBox.Controls.Add(this.incorrectYValue);
            this.addPointGroupBox.Controls.Add(this.incorrectXValue);
            this.addPointGroupBox.Controls.Add(this.addPointButton);
            this.addPointGroupBox.Controls.Add(this.yValue);
            this.addPointGroupBox.Controls.Add(this.editPointButton);
            this.addPointGroupBox.Controls.Add(this.xValue);
            this.addPointGroupBox.Controls.Add(this.xLabel);
            this.addPointGroupBox.Controls.Add(this.yLabel);
            this.addPointGroupBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addPointGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addPointGroupBox.Location = new System.Drawing.Point(373, 103);
            this.addPointGroupBox.Name = "addPointGroupBox";
            this.addPointGroupBox.Size = new System.Drawing.Size(231, 284);
            this.addPointGroupBox.TabIndex = 28;
            this.addPointGroupBox.TabStop = false;
            this.addPointGroupBox.Text = "Add Point";
            // 
            // incorrectYValue
            // 
            this.incorrectYValue.AutoSize = true;
            this.incorrectYValue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.incorrectYValue.ForeColor = System.Drawing.Color.Red;
            this.incorrectYValue.Location = new System.Drawing.Point(143, 148);
            this.incorrectYValue.Name = "incorrectYValue";
            this.incorrectYValue.Size = new System.Drawing.Size(82, 13);
            this.incorrectYValue.TabIndex = 30;
            this.incorrectYValue.Text = "Incorrect value";
            // 
            // incorrectXValue
            // 
            this.incorrectXValue.AutoSize = true;
            this.incorrectXValue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.incorrectXValue.ForeColor = System.Drawing.Color.Red;
            this.incorrectXValue.Location = new System.Drawing.Point(143, 89);
            this.incorrectXValue.Name = "incorrectXValue";
            this.incorrectXValue.Size = new System.Drawing.Size(82, 13);
            this.incorrectXValue.TabIndex = 29;
            this.incorrectXValue.Text = "Incorrect value";
            // 
            // addPointButton
            // 
            this.addPointButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addPointButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addPointButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addPointButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPointButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addPointButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addPointButton.Location = new System.Drawing.Point(35, 179);
            this.addPointButton.Name = "addPointButton";
            this.addPointButton.Size = new System.Drawing.Size(152, 42);
            this.addPointButton.TabIndex = 28;
            this.addPointButton.Text = "Add Point";
            this.addPointButton.UseVisualStyleBackColor = true;
            this.addPointButton.Click += new System.EventHandler(this.addPointButton_Click);
            // 
            // yValue
            // 
            this.yValue.Location = new System.Drawing.Point(47, 110);
            this.yValue.Name = "yValue";
            this.yValue.Size = new System.Drawing.Size(178, 35);
            this.yValue.TabIndex = 23;
            // 
            // xValue
            // 
            this.xValue.Location = new System.Drawing.Point(47, 51);
            this.xValue.Name = "xValue";
            this.xValue.Size = new System.Drawing.Size(178, 35);
            this.xValue.TabIndex = 22;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.xLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.xLabel.Location = new System.Drawing.Point(6, 49);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(35, 37);
            this.xLabel.TabIndex = 19;
            this.xLabel.Text = "x:";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.yLabel.Location = new System.Drawing.Point(6, 108);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(36, 37);
            this.yLabel.TabIndex = 21;
            this.yLabel.Text = "y:";
            // 
            // CreatePolygonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 465);
            this.Controls.Add(this.addPointGroupBox);
            this.Controls.Add(this.createPolygonButton);
            this.Controls.Add(this.deletePointButton);
            this.Controls.Add(this.pointsListBox);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreatePolygonForm";
            this.Text = "Create Polygon";
            this.Load += new System.EventHandler(this.CreatePolygonForm_Load);
            this.addPointGroupBox.ResumeLayout(false);
            this.addPointGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ListBox pointsListBox;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Button editPointButton;
        private System.Windows.Forms.Button deletePointButton;
        private System.Windows.Forms.Button createPolygonButton;
        private System.Windows.Forms.GroupBox addPointGroupBox;
        private System.Windows.Forms.Button addPointButton;
        private System.Windows.Forms.TextBox yValue;
        private System.Windows.Forms.TextBox xValue;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label incorrectXValue;
        private System.Windows.Forms.Label incorrectYValue;
    }
}