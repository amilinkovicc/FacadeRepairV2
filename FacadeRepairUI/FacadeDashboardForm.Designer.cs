namespace FacadeRepairUI
{
    partial class FacadeDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacadeDashboardForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.createFacadeButton = new System.Windows.Forms.Button();
            this.loadExistingFacadeDropDown = new System.Windows.Forms.ComboBox();
            this.loadExistingFacadeLabel = new System.Windows.Forms.Label();
            this.addPointButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(85, 33);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(417, 50);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "Facade Repair Dashboard";
            // 
            // createFacadeButton
            // 
            this.createFacadeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createFacadeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createFacadeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createFacadeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createFacadeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createFacadeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createFacadeButton.Location = new System.Drawing.Point(181, 327);
            this.createFacadeButton.Name = "createFacadeButton";
            this.createFacadeButton.Size = new System.Drawing.Size(225, 59);
            this.createFacadeButton.TabIndex = 15;
            this.createFacadeButton.Text = "Create Facade";
            this.createFacadeButton.UseVisualStyleBackColor = true;
            // 
            // loadExistingFacadeDropDown
            // 
            this.loadExistingFacadeDropDown.FormattingEnabled = true;
            this.loadExistingFacadeDropDown.Location = new System.Drawing.Point(124, 171);
            this.loadExistingFacadeDropDown.Name = "loadExistingFacadeDropDown";
            this.loadExistingFacadeDropDown.Size = new System.Drawing.Size(338, 38);
            this.loadExistingFacadeDropDown.TabIndex = 17;
            // 
            // loadExistingFacadeLabel
            // 
            this.loadExistingFacadeLabel.AutoSize = true;
            this.loadExistingFacadeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadExistingFacadeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loadExistingFacadeLabel.Location = new System.Drawing.Point(162, 131);
            this.loadExistingFacadeLabel.Name = "loadExistingFacadeLabel";
            this.loadExistingFacadeLabel.Size = new System.Drawing.Size(263, 37);
            this.loadExistingFacadeLabel.TabIndex = 16;
            this.loadExistingFacadeLabel.Text = "Load Existing Facade";
            // 
            // addPointButton
            // 
            this.addPointButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addPointButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addPointButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addPointButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPointButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addPointButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addPointButton.Location = new System.Drawing.Point(204, 215);
            this.addPointButton.Name = "addPointButton";
            this.addPointButton.Size = new System.Drawing.Size(178, 42);
            this.addPointButton.TabIndex = 18;
            this.addPointButton.Text = "Load Facade";
            this.addPointButton.UseVisualStyleBackColor = true;
            // 
            // FacadeDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 410);
            this.Controls.Add(this.addPointButton);
            this.Controls.Add(this.loadExistingFacadeDropDown);
            this.Controls.Add(this.loadExistingFacadeLabel);
            this.Controls.Add(this.createFacadeButton);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FacadeDashboardForm";
            this.Text = "Facade Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button createFacadeButton;
        private System.Windows.Forms.ComboBox loadExistingFacadeDropDown;
        private System.Windows.Forms.Label loadExistingFacadeLabel;
        private System.Windows.Forms.Button addPointButton;
    }
}