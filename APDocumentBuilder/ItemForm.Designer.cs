namespace APDocumentBuilder
{
	partial class ItemForm
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
			mainLabel = new Label();
			label2 = new Label();
			labelBox = new TextBox();
			label1 = new Label();
			typeBox = new ComboBox();
			placementBox = new TextBox();
			label3 = new Label();
			label4 = new Label();
			requiredCheckbox = new CheckBox();
			resetFormButton = new Button();
			submitFormButton = new Button();
			SuspendLayout();
			// 
			// mainLabel
			// 
			mainLabel.Dock = DockStyle.Top;
			mainLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			mainLabel.Location = new Point(0, 0);
			mainLabel.Name = "mainLabel";
			mainLabel.Size = new Size(348, 30);
			mainLabel.TabIndex = 0;
			mainLabel.Text = "Information Item";
			mainLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.Dock = DockStyle.Top;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(0, 30);
			label2.Name = "label2";
			label2.Size = new Size(348, 30);
			label2.TabIndex = 1;
			label2.Text = "Label";
			label2.TextAlign = ContentAlignment.BottomCenter;
			// 
			// labelBox
			// 
			labelBox.Dock = DockStyle.Top;
			labelBox.Location = new Point(0, 60);
			labelBox.Name = "labelBox";
			labelBox.Size = new Size(348, 23);
			labelBox.TabIndex = 2;
			// 
			// label1
			// 
			label1.Dock = DockStyle.Top;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(0, 83);
			label1.Name = "label1";
			label1.Size = new Size(348, 30);
			label1.TabIndex = 3;
			label1.Text = "Type";
			label1.TextAlign = ContentAlignment.BottomCenter;
			// 
			// typeBox
			// 
			typeBox.Dock = DockStyle.Top;
			typeBox.DropDownStyle = ComboBoxStyle.DropDownList;
			typeBox.FormattingEnabled = true;
			typeBox.Items.AddRange(new object[] { "text_input" });
			typeBox.Location = new Point(0, 113);
			typeBox.Name = "typeBox";
			typeBox.Size = new Size(348, 23);
			typeBox.TabIndex = 4;
			// 
			// placementBox
			// 
			placementBox.Dock = DockStyle.Top;
			placementBox.Location = new Point(0, 166);
			placementBox.Name = "placementBox";
			placementBox.Size = new Size(348, 23);
			placementBox.TabIndex = 6;
			// 
			// label3
			// 
			label3.Dock = DockStyle.Top;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.Location = new Point(0, 136);
			label3.Name = "label3";
			label3.Size = new Size(348, 30);
			label3.TabIndex = 5;
			label3.Text = "Placement";
			label3.TextAlign = ContentAlignment.BottomCenter;
			// 
			// label4
			// 
			label4.Dock = DockStyle.Top;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label4.Location = new Point(0, 189);
			label4.Name = "label4";
			label4.Size = new Size(348, 30);
			label4.TabIndex = 7;
			label4.Text = "Required";
			label4.TextAlign = ContentAlignment.BottomCenter;
			// 
			// requiredCheckbox
			// 
			requiredCheckbox.CheckAlign = ContentAlignment.TopCenter;
			requiredCheckbox.Dock = DockStyle.Top;
			requiredCheckbox.Location = new Point(0, 219);
			requiredCheckbox.Name = "requiredCheckbox";
			requiredCheckbox.Size = new Size(348, 17);
			requiredCheckbox.TabIndex = 8;
			requiredCheckbox.UseVisualStyleBackColor = true;
			// 
			// resetFormButton
			// 
			resetFormButton.Dock = DockStyle.Bottom;
			resetFormButton.Location = new Point(0, 267);
			resetFormButton.Name = "resetFormButton";
			resetFormButton.Size = new Size(348, 23);
			resetFormButton.TabIndex = 9;
			resetFormButton.Text = "Reset";
			resetFormButton.UseVisualStyleBackColor = true;
			resetFormButton.Click += resetFormButton_Click;
			// 
			// submitFormButton
			// 
			submitFormButton.Dock = DockStyle.Bottom;
			submitFormButton.Location = new Point(0, 244);
			submitFormButton.Name = "submitFormButton";
			submitFormButton.Size = new Size(348, 23);
			submitFormButton.TabIndex = 10;
			submitFormButton.Text = "Submit";
			submitFormButton.UseVisualStyleBackColor = true;
			submitFormButton.Click += submitFormButton_Click;
			// 
			// ItemForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(348, 290);
			Controls.Add(submitFormButton);
			Controls.Add(resetFormButton);
			Controls.Add(requiredCheckbox);
			Controls.Add(label4);
			Controls.Add(placementBox);
			Controls.Add(label3);
			Controls.Add(typeBox);
			Controls.Add(label1);
			Controls.Add(labelBox);
			Controls.Add(label2);
			Controls.Add(mainLabel);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "ItemForm";
			Text = "Item Form";
			Load += ItemForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		public Label mainLabel;
		private Label label2;
		private TextBox labelBox;
		private Label label1;
		private ComboBox typeBox;
		private TextBox placementBox;
		private Label label3;
		private Label label4;
		private CheckBox requiredCheckbox;
		private Button resetFormButton;
		private Button submitFormButton;
	}
}