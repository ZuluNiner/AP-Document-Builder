namespace APDocumentBuilder
{
	partial class TermsForm
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
			termsBox = new RichTextBox();
			submitFormButton = new Button();
			resetFormButton = new Button();
			SuspendLayout();
			// 
			// mainLabel
			// 
			mainLabel.Dock = DockStyle.Top;
			mainLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			mainLabel.Location = new Point(0, 0);
			mainLabel.Name = "mainLabel";
			mainLabel.Size = new Size(309, 30);
			mainLabel.TabIndex = 1;
			mainLabel.Text = "Terms And Conditions Item";
			mainLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// termsBox
			// 
			termsBox.Dock = DockStyle.Top;
			termsBox.Location = new Point(0, 30);
			termsBox.Name = "termsBox";
			termsBox.Size = new Size(309, 89);
			termsBox.TabIndex = 2;
			termsBox.Text = "";
			// 
			// submitFormButton
			// 
			submitFormButton.Dock = DockStyle.Bottom;
			submitFormButton.Location = new Point(0, 142);
			submitFormButton.Name = "submitFormButton";
			submitFormButton.Size = new Size(309, 23);
			submitFormButton.TabIndex = 12;
			submitFormButton.Text = "Submit";
			submitFormButton.UseVisualStyleBackColor = true;
			submitFormButton.Click += submitFormButton_Click;
			// 
			// resetFormButton
			// 
			resetFormButton.Dock = DockStyle.Bottom;
			resetFormButton.Location = new Point(0, 165);
			resetFormButton.Name = "resetFormButton";
			resetFormButton.Size = new Size(309, 23);
			resetFormButton.TabIndex = 11;
			resetFormButton.Text = "Reset";
			resetFormButton.UseVisualStyleBackColor = true;
			resetFormButton.Click += resetFormButton_Click;
			// 
			// TermsForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(309, 188);
			Controls.Add(submitFormButton);
			Controls.Add(resetFormButton);
			Controls.Add(termsBox);
			Controls.Add(mainLabel);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "TermsForm";
			Text = "Terms Form";
			Load += TermsForm_Load;
			ResumeLayout(false);
		}

		#endregion

		public Label mainLabel;
		private RichTextBox termsBox;
		private Button submitFormButton;
		private Button resetFormButton;
	}
}