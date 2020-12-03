﻿namespace WindowsFormsBoat
{
	partial class FormParking
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
			this.boxParking = new System.Windows.Forms.PictureBox();
			this.groupBox_taking = new System.Windows.Forms.GroupBox();
			this.bTake = new System.Windows.Forms.Button();
			this.maskedTextBox_placing = new System.Windows.Forms.MaskedTextBox();
			this.label_place = new System.Windows.Forms.Label();
			this.label_parking = new System.Windows.Forms.Label();
			this.buttonAddParking_Click = new System.Windows.Forms.Button();
			this.listBoxParkings = new System.Windows.Forms.ListBox();
			this.buttonDelParking_Click = new System.Windows.Forms.Button();
			this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
			this.bParkBoat = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.boxParking)).BeginInit();
			this.groupBox_taking.SuspendLayout();
			this.SuspendLayout();
			// 
			// boxParkimg
			// 
			this.boxParking.Dock = System.Windows.Forms.DockStyle.Fill;
			this.boxParking.Location = new System.Drawing.Point(0, 0);
			this.boxParking.Name = "boxParkimg";
			this.boxParking.Size = new System.Drawing.Size(1134, 681);
			this.boxParking.TabIndex = 0;
			this.boxParking.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox_taking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox_taking.Controls.Add(this.bTake);
			this.groupBox_taking.Controls.Add(this.maskedTextBox_placing);
			this.groupBox_taking.Controls.Add(this.label_place);
			this.groupBox_taking.Location = new System.Drawing.Point(966, 516);
			this.groupBox_taking.Name = "groupBox1";
			this.groupBox_taking.Size = new System.Drawing.Size(152, 153);
			this.groupBox_taking.TabIndex = 3;
			this.groupBox_taking.TabStop = false;
			this.groupBox_taking.Text = "Take transport";
			// 
			// bTake
			// 
			this.bTake.Location = new System.Drawing.Point(8, 54);
			this.bTake.Name = "bTake";
			this.bTake.Size = new System.Drawing.Size(124, 20);
			this.bTake.TabIndex = 2;
			this.bTake.Text = "Take";
			this.bTake.UseVisualStyleBackColor = true;
			this.bTake.Click += new System.EventHandler(this.bTake_Click);
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox_placing.Location = new System.Drawing.Point(51, 28);
			this.maskedTextBox_placing.Mask = "0";
			this.maskedTextBox_placing.Name = "maskedTextBox1";
			this.maskedTextBox_placing.Size = new System.Drawing.Size(63, 20);
			this.maskedTextBox_placing.TabIndex = 1;
			// 
			// label1
			// 
			this.label_place.AutoSize = true;
			this.label_place.Location = new System.Drawing.Point(5, 31);
			this.label_place.Name = "label1";
			this.label_place.Size = new System.Drawing.Size(40, 13);
			this.label_place.TabIndex = 0;
			this.label_place.Text = "Place: ";
			// 
			// label2
			// 
			this.label_parking.AutoSize = true;
			this.label_parking.Location = new System.Drawing.Point(1000, 22);
			this.label_parking.Name = "label2";
			this.label_parking.Size = new System.Drawing.Size(46, 13);
			this.label_parking.TabIndex = 4;
			this.label_parking.Text = "Parking:";
			// 
			// buttonAddParking_Click
			// 
			this.buttonAddParking_Click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAddParking_Click.Location = new System.Drawing.Point(959, 73);
			this.buttonAddParking_Click.Name = "buttonAddParking_Click";
			this.buttonAddParking_Click.Size = new System.Drawing.Size(159, 35);
			this.buttonAddParking_Click.TabIndex = 6;
			this.buttonAddParking_Click.Text = "Add the parking";
			this.buttonAddParking_Click.UseVisualStyleBackColor = true;
			this.buttonAddParking_Click.Click += new System.EventHandler(this.buttonAddParking_Click_Click);
			// 
			// listBoxParkings
			// 
			this.listBoxParkings.FormattingEnabled = true;
			this.listBoxParkings.Location = new System.Drawing.Point(961, 130);
			this.listBoxParkings.Name = "listBoxParkings";
			this.listBoxParkings.Size = new System.Drawing.Size(154, 134);
			this.listBoxParkings.TabIndex = 7;
			this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged_1);
			// 
			// buttonDelParking_Click
			// 
			this.buttonDelParking_Click.Location = new System.Drawing.Point(965, 281);
			this.buttonDelParking_Click.Name = "buttonDelParking_Click";
			this.buttonDelParking_Click.Size = new System.Drawing.Size(150, 26);
			this.buttonDelParking_Click.TabIndex = 8;
			this.buttonDelParking_Click.Text = "Delete Parking";
			this.buttonDelParking_Click.UseVisualStyleBackColor = true;
			this.buttonDelParking_Click.Click += new System.EventHandler(this.buttonDelParking_Click_Click);
			// 
			// textBoxNewLevelName
			// 
			this.textBoxNewLevelName.Location = new System.Drawing.Point(961, 47);
			this.textBoxNewLevelName.Name = "textBoxNewLevelName";
			this.textBoxNewLevelName.Size = new System.Drawing.Size(154, 20);
			this.textBoxNewLevelName.TabIndex = 9;
			// 
			// bParkBoat
			// 
			this.bParkBoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bParkBoat.Location = new System.Drawing.Point(956, 359);
			this.bParkBoat.Name = "bParkBoat";
			this.bParkBoat.Size = new System.Drawing.Size(159, 54);
			this.bParkBoat.TabIndex = 1;
			this.bParkBoat.Text = "Park the boat";
			this.bParkBoat.UseVisualStyleBackColor = true;
			this.bParkBoat.Click += new System.EventHandler(this.bParkBoat_Click);
			// 
			// FormParking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1134, 681);
			this.Controls.Add(this.textBoxNewLevelName);
			this.Controls.Add(this.buttonDelParking_Click);
			this.Controls.Add(this.listBoxParkings);
			this.Controls.Add(this.buttonAddParking_Click);
			this.Controls.Add(this.label_parking);
			this.Controls.Add(this.groupBox_taking);
			this.Controls.Add(this.bParkBoat);
			this.Controls.Add(this.boxParking);
			this.Name = "FormParking";
			this.Text = "FormParking";
			this.Load += new System.EventHandler(this.FormParking_Load);
			((System.ComponentModel.ISupportInitialize)(this.boxParking)).EndInit();
			this.groupBox_taking.ResumeLayout(false);
			this.groupBox_taking.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox boxParking;
		private System.Windows.Forms.GroupBox groupBox_taking;
		private System.Windows.Forms.Button bTake;
		private System.Windows.Forms.MaskedTextBox maskedTextBox_placing;
		private System.Windows.Forms.Label label_place;
		private System.Windows.Forms.Label label_parking;
		private System.Windows.Forms.Button buttonAddParking_Click;
		private System.Windows.Forms.ListBox listBoxParkings;
		private System.Windows.Forms.Button buttonDelParking_Click;
		private System.Windows.Forms.TextBox textBoxNewLevelName;
		private System.Windows.Forms.Button bParkBoat;
	}
}