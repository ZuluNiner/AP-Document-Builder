namespace APDocumentBuilder
{
	partial class RestrictionsForm
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
			label1 = new Label();
			label2 = new Label();
			restrictionTypeBox = new ComboBox();
			label3 = new Label();
			restrictionIdBox = new TextBox();
			label4 = new Label();
			restrictionGradesBox = new TextBox();
			resetButton = new Button();
			submitButton = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Dock = DockStyle.Top;
			label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(399, 33);
			label1.TabIndex = 0;
			label1.Text = "Restrictions Form";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.Dock = DockStyle.Top;
			label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(0, 33);
			label2.Name = "label2";
			label2.Size = new Size(399, 33);
			label2.TabIndex = 1;
			label2.Text = "Restriction Type";
			label2.TextAlign = ContentAlignment.BottomCenter;
			// 
			// restrictionTypeBox
			// 
			restrictionTypeBox.Dock = DockStyle.Top;
			restrictionTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
			restrictionTypeBox.FormattingEnabled = true;
			restrictionTypeBox.Items.AddRange(new object[] { "Job", "Gang", "Citizen" });
			restrictionTypeBox.Location = new Point(0, 66);
			restrictionTypeBox.Name = "restrictionTypeBox";
			restrictionTypeBox.Size = new Size(399, 23);
			restrictionTypeBox.TabIndex = 2;
			restrictionTypeBox.SelectedIndexChanged += restrictionTypeBox_SelectedIndexChanged;
			// 
			// label3
			// 
			label3.Dock = DockStyle.Top;
			label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(0, 89);
			label3.Name = "label3";
			label3.Size = new Size(399, 33);
			label3.TabIndex = 4;
			label3.Text = "Restriction Job/ID";
			label3.TextAlign = ContentAlignment.BottomCenter;
			// 
			// restrictionIdBox
			// 
			restrictionIdBox.Dock = DockStyle.Top;
			restrictionIdBox.Location = new Point(0, 122);
			restrictionIdBox.Name = "restrictionIdBox";
			restrictionIdBox.Size = new Size(399, 23);
			restrictionIdBox.TabIndex = 5;
			// 
			// label4
			// 
			label4.Dock = DockStyle.Top;
			label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(0, 145);
			label4.Name = "label4";
			label4.Size = new Size(399, 33);
			label4.TabIndex = 6;
			label4.Text = "Restriction Grade(s)";
			label4.TextAlign = ContentAlignment.BottomCenter;
			// 
			// restrictionGradesBox
			// 
			restrictionGradesBox.Dock = DockStyle.Top;
			restrictionGradesBox.Location = new Point(0, 178);
			restrictionGradesBox.Name = "restrictionGradesBox";
			restrictionGradesBox.Size = new Size(399, 23);
			restrictionGradesBox.TabIndex = 7;
			// 
			// resetButton
			// 
			resetButton.Dock = DockStyle.Bottom;
			resetButton.Location = new Point(0, 253);
			resetButton.Name = "resetButton";
			resetButton.Size = new Size(399, 23);
			resetButton.TabIndex = 8;
			resetButton.Text = "Reset";
			resetButton.UseVisualStyleBackColor = true;
			resetButton.Click += resetButton_Click;
			// 
			// submitButton
			// 
			submitButton.Dock = DockStyle.Bottom;
			submitButton.Location = new Point(0, 230);
			submitButton.Name = "submitButton";
			submitButton.Size = new Size(399, 23);
			submitButton.TabIndex = 9;
			submitButton.Text = "Submit";
			submitButton.UseVisualStyleBackColor = true;
			submitButton.Click += submitButton_Click;
			// 
			// RestrictionsForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(399, 276);
			Controls.Add(submitButton);
			Controls.Add(resetButton);
			Controls.Add(restrictionGradesBox);
			Controls.Add(label4);
			Controls.Add(restrictionIdBox);
			Controls.Add(label3);
			Controls.Add(restrictionTypeBox);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "RestrictionsForm";
			Text = "RestrictionsForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private ComboBox restrictionTypeBox;
		private Label label3;
		private TextBox restrictionIdBox;
		private Label label4;
		private TextBox restrictionGradesBox;
		private Button resetButton;
		private Button submitButton;
	}
}