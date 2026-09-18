namespace TransportDB_GUI
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
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.btnAddMechanic = new System.Windows.Forms.Button();
            this.btnDeleteMechanic = new System.Windows.Forms.Button();
            this.btnViewVehicles = new System.Windows.Forms.Button();
            this.btnUpdateVehicle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseLog = new System.Windows.Forms.Button();
            this.btnViewMechanics = new System.Windows.Forms.Button();
            this.btnViewLogs = new System.Windows.Forms.Button();
            this.btnInquiry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVehicle.Location = new System.Drawing.Point(362, 51);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(132, 41);
            this.btnAddVehicle.TabIndex = 0;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVehicle.Location = new System.Drawing.Point(362, 98);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(132, 39);
            this.btnDeleteVehicle.TabIndex = 1;
            this.btnDeleteVehicle.Text = "Delete Vehicle";
            this.btnDeleteVehicle.UseVisualStyleBackColor = true;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // btnAddMechanic
            // 
            this.btnAddMechanic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMechanic.Location = new System.Drawing.Point(362, 143);
            this.btnAddMechanic.Name = "btnAddMechanic";
            this.btnAddMechanic.Size = new System.Drawing.Size(132, 41);
            this.btnAddMechanic.TabIndex = 2;
            this.btnAddMechanic.Text = "Add Mechanic";
            this.btnAddMechanic.UseVisualStyleBackColor = true;
            this.btnAddMechanic.Click += new System.EventHandler(this.btnAddMechanic_Click);
            // 
            // btnDeleteMechanic
            // 
            this.btnDeleteMechanic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMechanic.Location = new System.Drawing.Point(362, 190);
            this.btnDeleteMechanic.Name = "btnDeleteMechanic";
            this.btnDeleteMechanic.Size = new System.Drawing.Size(132, 41);
            this.btnDeleteMechanic.TabIndex = 3;
            this.btnDeleteMechanic.Text = "Delete Mechanic";
            this.btnDeleteMechanic.UseVisualStyleBackColor = true;
            this.btnDeleteMechanic.Click += new System.EventHandler(this.btnDeleteMechanic_Click);
            // 
            // btnViewVehicles
            // 
            this.btnViewVehicles.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewVehicles.Location = new System.Drawing.Point(362, 237);
            this.btnViewVehicles.Name = "btnViewVehicles";
            this.btnViewVehicles.Size = new System.Drawing.Size(132, 40);
            this.btnViewVehicles.TabIndex = 4;
            this.btnViewVehicles.Text = "View Vehicles";
            this.btnViewVehicles.UseVisualStyleBackColor = true;
            this.btnViewVehicles.Click += new System.EventHandler(this.btnViewVehicles_Click);
            // 
            // btnUpdateVehicle
            // 
            this.btnUpdateVehicle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateVehicle.Location = new System.Drawing.Point(362, 283);
            this.btnUpdateVehicle.Name = "btnUpdateVehicle";
            this.btnUpdateVehicle.Size = new System.Drawing.Size(132, 38);
            this.btnUpdateVehicle.TabIndex = 5;
            this.btnUpdateVehicle.Text = "Update Vehicle";
            this.btnUpdateVehicle.UseVisualStyleBackColor = true;
            this.btnUpdateVehicle.Click += new System.EventHandler(this.btnUpdateVehicle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Urban Fleet and Maintainance Hub";
            // 
            // btnCloseLog
            // 
            this.btnCloseLog.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseLog.Location = new System.Drawing.Point(362, 327);
            this.btnCloseLog.Name = "btnCloseLog";
            this.btnCloseLog.Size = new System.Drawing.Size(132, 34);
            this.btnCloseLog.TabIndex = 7;
            this.btnCloseLog.Text = "Close Log";
            this.btnCloseLog.UseVisualStyleBackColor = true;
            this.btnCloseLog.Click += new System.EventHandler(this.btnCloseLog_Click);
            // 
            // btnViewMechanics
            // 
            this.btnViewMechanics.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMechanics.Location = new System.Drawing.Point(362, 367);
            this.btnViewMechanics.Name = "btnViewMechanics";
            this.btnViewMechanics.Size = new System.Drawing.Size(132, 42);
            this.btnViewMechanics.TabIndex = 8;
            this.btnViewMechanics.Text = "View Mechanics";
            this.btnViewMechanics.UseVisualStyleBackColor = true;
            this.btnViewMechanics.Click += new System.EventHandler(this.btnViewMechanics_Click);
            // 
            // btnViewLogs
            // 
            this.btnViewLogs.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLogs.Location = new System.Drawing.Point(362, 415);
            this.btnViewLogs.Name = "btnViewLogs";
            this.btnViewLogs.Size = new System.Drawing.Size(132, 38);
            this.btnViewLogs.TabIndex = 9;
            this.btnViewLogs.Text = "View Logs";
            this.btnViewLogs.UseVisualStyleBackColor = true;
            this.btnViewLogs.Click += new System.EventHandler(this.btnViewLogs_Click);
            // 
            // btnInquiry
            // 
            this.btnInquiry.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInquiry.Location = new System.Drawing.Point(362, 459);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(132, 36);
            this.btnInquiry.TabIndex = 10;
            this.btnInquiry.Text = "Inquiries";
            this.btnInquiry.UseVisualStyleBackColor = true;
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 507);
            this.Controls.Add(this.btnInquiry);
            this.Controls.Add(this.btnViewLogs);
            this.Controls.Add(this.btnViewMechanics);
            this.Controls.Add(this.btnCloseLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateVehicle);
            this.Controls.Add(this.btnViewVehicles);
            this.Controls.Add(this.btnDeleteMechanic);
            this.Controls.Add(this.btnAddMechanic);
            this.Controls.Add(this.btnDeleteVehicle);
            this.Controls.Add(this.btnAddVehicle);
            this.Name = "Form1";
            this.Text = "TransportDB System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.Button btnAddMechanic;
        private System.Windows.Forms.Button btnDeleteMechanic;
        private System.Windows.Forms.Button btnViewVehicles;
        private System.Windows.Forms.Button btnUpdateVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseLog;
        private System.Windows.Forms.Button btnViewMechanics;
        private System.Windows.Forms.Button btnViewLogs;
        private System.Windows.Forms.Button btnInquiry;
    }
}

