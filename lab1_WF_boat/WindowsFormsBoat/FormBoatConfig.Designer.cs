namespace WindowsFormsBoat
{
	partial class FormBoatConfig
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
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.checkBoxStrings = new System.Windows.Forms.CheckBox();
            this.checkBoxLeftFloat = new System.Windows.Forms.CheckBox();
            this.checkBoxRightFloat = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.labelCatamaran = new System.Windows.Forms.Label();
            this.labelBoat = new System.Windows.Forms.Label();
            this.panelBoat = new System.Windows.Forms.Panel();
            this.pictureBoxBoat = new System.Windows.Forms.PictureBox();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelViolet = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelLightPink = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelCoral = new System.Windows.Forms.Panel();
            this.panelBrown = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.groupBoxType.SuspendLayout();
            this.panelBoat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).BeginInit();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.checkBoxStrings);
            this.groupBoxParameters.Controls.Add(this.checkBoxLeftFloat);
            this.groupBoxParameters.Controls.Add(this.checkBoxRightFloat);
            this.groupBoxParameters.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParameters.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParameters.Controls.Add(this.labelWeight);
            this.groupBoxParameters.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParameters.Location = new System.Drawing.Point(15, 259);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(653, 155);
            this.groupBoxParameters.TabIndex = 0;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // checkBoxStrings
            // 
            this.checkBoxStrings.AutoSize = true;
            this.checkBoxStrings.Location = new System.Drawing.Point(427, 71);
            this.checkBoxStrings.Name = "checkBoxStrings";
            this.checkBoxStrings.Size = new System.Drawing.Size(70, 17);
            this.checkBoxStrings.TabIndex = 8;
            this.checkBoxStrings.Text = "Полоски";
            this.checkBoxStrings.UseVisualStyleBackColor = true;
            // 
            // checkBoxLeftFloat
            // 
            this.checkBoxLeftFloat.AutoSize = true;
            this.checkBoxLeftFloat.Location = new System.Drawing.Point(427, 48);
            this.checkBoxLeftFloat.Name = "checkBoxLeftFloat";
            this.checkBoxLeftFloat.Size = new System.Drawing.Size(111, 17);
            this.checkBoxLeftFloat.TabIndex = 5;
            this.checkBoxLeftFloat.Text = "Левый поплавок";
            this.checkBoxLeftFloat.UseVisualStyleBackColor = true;
            // 
            // checkBoxRightFloat
            // 
            this.checkBoxRightFloat.AutoSize = true;
            this.checkBoxRightFloat.Location = new System.Drawing.Point(427, 24);
            this.checkBoxRightFloat.Name = "checkBoxRightFloat";
            this.checkBoxRightFloat.Size = new System.Drawing.Size(117, 17);
            this.checkBoxRightFloat.TabIndex = 4;
            this.checkBoxRightFloat.Text = "Правый поплавок";
            this.checkBoxRightFloat.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(194, 84);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(194, 41);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(22, 91);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(161, 13);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес плавательного средства: ";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(24, 48);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(140, 13);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Максимальная скорость: ";
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.labelCatamaran);
            this.groupBoxType.Controls.Add(this.labelBoat);
            this.groupBoxType.Location = new System.Drawing.Point(19, 41);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(190, 184);
            this.groupBoxType.TabIndex = 1;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Тип кузова";
            // 
            // labelCatamaran
            // 
            this.labelCatamaran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCatamaran.Location = new System.Drawing.Point(15, 104);
            this.labelCatamaran.Name = "labelCatamaran";
            this.labelCatamaran.Size = new System.Drawing.Size(152, 45);
            this.labelCatamaran.TabIndex = 1;
            this.labelCatamaran.Text = "Катамаран";
            this.labelCatamaran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCatamaran.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCatamaran_MouseDown);
            // 
            // labelBoat
            // 
            this.labelBoat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBoat.Location = new System.Drawing.Point(15, 35);
            this.labelBoat.Name = "labelBoat";
            this.labelBoat.Size = new System.Drawing.Size(152, 46);
            this.labelBoat.TabIndex = 0;
            this.labelBoat.Text = "Лодка";
            this.labelBoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBoat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBoat_MouseDown);
            // 
            // panelBoat
            // 
            this.panelBoat.AllowDrop = true;
            this.panelBoat.Controls.Add(this.pictureBoxBoat);
            this.panelBoat.Location = new System.Drawing.Point(269, 48);
            this.panelBoat.Name = "panelBoat";
            this.panelBoat.Size = new System.Drawing.Size(398, 176);
            this.panelBoat.TabIndex = 2;
            this.panelBoat.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelBoat_DragDrop);
            this.panelBoat.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelBoat_DragEnter);
            // 
            // pictureBoxBoat
            // 
            this.pictureBoxBoat.Location = new System.Drawing.Point(21, 13);
            this.pictureBoxBoat.Name = "pictureBoxBoat";
            this.pictureBoxBoat.Size = new System.Drawing.Size(359, 146);
            this.pictureBoxBoat.TabIndex = 0;
            this.pictureBoxBoat.TabStop = false;
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Controls.Add(this.panelViolet);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelLightPink);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.panelPink);
            this.groupBoxColors.Controls.Add(this.panelCoral);
            this.groupBoxColors.Controls.Add(this.panelBrown);
            this.groupBoxColors.Location = new System.Drawing.Point(691, 48);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(223, 176);
            this.groupBoxColors.TabIndex = 3;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(119, 28);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(84, 34);
            this.labelDopColor.TabIndex = 7;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(17, 28);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(94, 34);
            this.labelMainColor.TabIndex = 6;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // panelViolet
            // 
            this.panelViolet.BackColor = System.Drawing.Color.MediumPurple;
            this.panelViolet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelViolet.Location = new System.Drawing.Point(68, 124);
            this.panelViolet.Name = "panelViolet";
            this.panelViolet.Size = new System.Drawing.Size(33, 31);
            this.panelViolet.TabIndex = 3;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(170, 124);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(33, 31);
            this.panelGreen.TabIndex = 5;
            // 
            // panelLightPink
            // 
            this.panelLightPink.BackColor = System.Drawing.Color.Pink;
            this.panelLightPink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLightPink.Location = new System.Drawing.Point(17, 124);
            this.panelLightPink.Name = "panelLightPink";
            this.panelLightPink.Size = new System.Drawing.Size(33, 31);
            this.panelLightPink.TabIndex = 2;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(119, 124);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(33, 31);
            this.panelBlue.TabIndex = 4;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(170, 75);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(33, 31);
            this.panelRed.TabIndex = 3;
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.Salmon;
            this.panelPink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPink.Location = new System.Drawing.Point(119, 75);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(33, 31);
            this.panelPink.TabIndex = 2;
            // 
            // panelCoral
            // 
            this.panelCoral.AllowDrop = true;
            this.panelCoral.BackColor = System.Drawing.Color.OrangeRed;
            this.panelCoral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCoral.Location = new System.Drawing.Point(68, 75);
            this.panelCoral.Name = "panelCoral";
            this.panelCoral.Size = new System.Drawing.Size(33, 31);
            this.panelCoral.TabIndex = 1;
            // 
            // panelBrown
            // 
            this.panelBrown.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelBrown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBrown.Location = new System.Drawing.Point(17, 75);
            this.panelBrown.Name = "panelBrown";
            this.panelBrown.Size = new System.Drawing.Size(33, 31);
            this.panelBrown.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(695, 270);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(218, 49);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(695, 348);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(218, 44);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormBoatConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelBoat);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.groupBoxParameters);
            this.Name = "FormBoatConfig";
            this.Text = "FormBoatConfig";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.groupBoxType.ResumeLayout(false);
            this.panelBoat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoat)).EndInit();
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxParameters;
		private System.Windows.Forms.NumericUpDown numericUpDownWeight;
		private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
		private System.Windows.Forms.Label labelWeight;
		private System.Windows.Forms.Label labelMaxSpeed;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.CheckBox checkBoxStrings;
		private System.Windows.Forms.CheckBox checkBoxLeftFloat;
		private System.Windows.Forms.CheckBox checkBoxRightFloat;
		private System.Windows.Forms.GroupBox groupBoxType;
		private System.Windows.Forms.Label labelCatamaran;
		private System.Windows.Forms.Label labelBoat;
		private System.Windows.Forms.Panel panelBoat;
		private System.Windows.Forms.PictureBox pictureBoxBoat;
		private System.Windows.Forms.GroupBox groupBoxColors;
		private System.Windows.Forms.Label labelDopColor;
		private System.Windows.Forms.Label labelMainColor;
		private System.Windows.Forms.Panel panelViolet;
		private System.Windows.Forms.Panel panelGreen;
		private System.Windows.Forms.Panel panelLightPink;
		private System.Windows.Forms.Panel panelBlue;
		private System.Windows.Forms.Panel panelRed;
		private System.Windows.Forms.Panel panelPink;
		private System.Windows.Forms.Panel panelCoral;
		private System.Windows.Forms.Panel panelBrown;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonCancel;
	}
}