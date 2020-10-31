namespace WindowsFormsBoat
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
			this.bParkBoat = new System.Windows.Forms.Button();
			this.bParkCatamaran = new System.Windows.Forms.Button();
			this.groupBox_taking = new System.Windows.Forms.GroupBox();
			this.bTake = new System.Windows.Forms.Button();
			this.maskedTextBox_placing = new System.Windows.Forms.MaskedTextBox();
			this.labelPlace = new System.Windows.Forms.Label();
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
			// bParkBoat
			// 
			this.bParkBoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bParkBoat.Location = new System.Drawing.Point(959, 27);
			this.bParkBoat.Name = "bParkBoat";
			this.bParkBoat.Size = new System.Drawing.Size(159, 54);
			this.bParkBoat.TabIndex = 1;
			this.bParkBoat.Text = "Park the boat";
			this.bParkBoat.UseVisualStyleBackColor = true;
			this.bParkBoat.Click += new System.EventHandler(this.bParkBoat_Click);
			// 
			// bParkCatamaran
			// 
			this.bParkCatamaran.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bParkCatamaran.Location = new System.Drawing.Point(962, 103);
			this.bParkCatamaran.Name = "bParkCatamaran";
			this.bParkCatamaran.Size = new System.Drawing.Size(156, 59);
			this.bParkCatamaran.TabIndex = 2;
			this.bParkCatamaran.Text = "Park the catamaran";
			this.bParkCatamaran.UseVisualStyleBackColor = true;
			this.bParkCatamaran.Click += new System.EventHandler(this.bParkCatamaran_Click);
			// 
			// groupBox1
			// 
			this.groupBox_taking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox_taking.Controls.Add(this.bTake);
			this.groupBox_taking.Controls.Add(this.maskedTextBox_placing);
			this.groupBox_taking.Controls.Add(this.labelPlace);
			this.groupBox_taking.Location = new System.Drawing.Point(966, 185);
			this.groupBox_taking.Name = "groupBox1";
			this.groupBox_taking.Size = new System.Drawing.Size(152, 170);
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
			this.labelPlace.AutoSize = true;
			this.labelPlace.Location = new System.Drawing.Point(5, 31);
			this.labelPlace.Name = "label1";
			this.labelPlace.Size = new System.Drawing.Size(40, 13);
			this.labelPlace.TabIndex = 0;
			this.labelPlace.Text = "Place: ";
			// 
			// FormParking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1134, 681);
			this.Controls.Add(this.groupBox_taking);
			this.Controls.Add(this.bParkCatamaran);
			this.Controls.Add(this.bParkBoat);
			this.Controls.Add(this.boxParking);
			this.Name = "FormParking";
			this.Text = "FormParking";
			((System.ComponentModel.ISupportInitialize)(this.boxParking)).EndInit();
			this.groupBox_taking.ResumeLayout(false);
			this.groupBox_taking.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox boxParking;
		private System.Windows.Forms.Button bParkBoat;
		private System.Windows.Forms.Button bParkCatamaran;
		private System.Windows.Forms.GroupBox groupBox_taking;
		private System.Windows.Forms.Button bTake;
		private System.Windows.Forms.MaskedTextBox maskedTextBox_placing;
		private System.Windows.Forms.Label labelPlace;
	}
}