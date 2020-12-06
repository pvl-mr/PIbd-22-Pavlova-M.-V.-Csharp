namespace WindowsFormsBoat
{
	partial class FormBoat
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoat));
			this.buttonCreateBoat = new System.Windows.Forms.Button();
			this.buttonLeft = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonRight = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			this.pictureBoxBoat = new System.Windows.Forms.PictureBox();
			this.buttonCreateCatamaran = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonCreateBoat
			// 
			this.buttonCreateBoat.Location = new System.Drawing.Point(904, 12);
			this.buttonCreateBoat.Name = "buttonCreateBoat";
			this.buttonCreateBoat.Size = new System.Drawing.Size(215, 91);
			this.buttonCreateBoat.TabIndex = 5;
			this.buttonCreateBoat.Text = "Create boat";
			this.buttonCreateBoat.UseVisualStyleBackColor = true;
			this.buttonCreateBoat.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// buttonLeft
			// 
			this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
			this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonLeft.Location = new System.Drawing.Point(907, 620);
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size(40, 40);
			this.buttonLeft.TabIndex = 6;
			this.buttonLeft.UseVisualStyleBackColor = true;
			this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonDown
			// 
			this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
			this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonDown.Location = new System.Drawing.Point(987, 621);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(40, 40);
			this.buttonDown.TabIndex = 7;
			this.buttonDown.UseVisualStyleBackColor = true;
			this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonRight
			// 
			this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
			this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonRight.Location = new System.Drawing.Point(1064, 621);
			this.buttonRight.Name = "buttonRight";
			this.buttonRight.Size = new System.Drawing.Size(40, 40);
			this.buttonRight.TabIndex = 8;
			this.buttonRight.UseVisualStyleBackColor = true;
			this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonUp
			// 
			this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
			this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonUp.Location = new System.Drawing.Point(987, 561);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(40, 40);
			this.buttonUp.TabIndex = 9;
			this.buttonUp.UseVisualStyleBackColor = true;
			this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// pictureBoxBoat
			// 
			this.pictureBoxBoat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxBoat.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxBoat.Name = "pictureBoxBoat";
			this.pictureBoxBoat.Size = new System.Drawing.Size(1134, 681);
			this.pictureBoxBoat.TabIndex = 4;
			this.pictureBoxBoat.TabStop = false;
			// 
			// buttonCreateCatamaran
			// 
			this.buttonCreateCatamaran.Location = new System.Drawing.Point(904, 119);
			this.buttonCreateCatamaran.Name = "buttonCreateCatamaran";
			this.buttonCreateCatamaran.Size = new System.Drawing.Size(214, 103);
			this.buttonCreateCatamaran.TabIndex = 10;
			this.buttonCreateCatamaran.Text = "Create catamaran";
			this.buttonCreateCatamaran.UseVisualStyleBackColor = true;
			this.buttonCreateCatamaran.Click += new System.EventHandler(this.buttonCreateCatamaran_Click);
			// 
			// FormBoat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1134, 681);
			this.Controls.Add(this.buttonCreateCatamaran);
			this.Controls.Add(this.buttonUp);
			this.Controls.Add(this.buttonRight);
			this.Controls.Add(this.buttonDown);
			this.Controls.Add(this.buttonLeft);
			this.Controls.Add(this.buttonCreateBoat);
			this.Controls.Add(this.pictureBoxBoat);
			this.Name = "FormBoat";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonCreateBoat;
		private System.Windows.Forms.Button buttonLeft;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Button buttonRight;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.PictureBox pictureBoxBoat;
		private System.Windows.Forms.Button buttonCreateCatamaran;
	}
}

