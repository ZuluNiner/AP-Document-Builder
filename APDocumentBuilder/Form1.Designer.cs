namespace APDocumentBuilder
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			label1 = new Label();
			resetFormButton = new Button();
			generateDocumentButton = new Button();
			panel2 = new Panel();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			informationBox = new ListBox();
			toolStrip1 = new ToolStrip();
			addInformationButton = new ToolStripButton();
			deleteInformationButton = new ToolStripButton();
			tabPage2 = new TabPage();
			extendedInformationBox = new ListBox();
			addExtendedInformationButton = new ToolStrip();
			addExtendedButton = new ToolStripButton();
			deleteExtendedButton = new ToolStripButton();
			tabPage3 = new TabPage();
			termsAndConditionsBox = new ListBox();
			toolStrip3 = new ToolStrip();
			addTermsButton = new ToolStripButton();
			deleteTermsButton = new ToolStripButton();
			tabPage4 = new TabPage();
			citizenRestrictionListbox = new ListBox();
			label9 = new Label();
			gangRestrictionListBox = new ListBox();
			label8 = new Label();
			jobRestrictionListbox = new ListBox();
			label7 = new Label();
			toolStrip4 = new ToolStrip();
			addRestrictionButton = new ToolStripButton();
			deleteRestrictionButton = new ToolStripButton();
			panel1 = new Panel();
			disclaimerBox = new RichTextBox();
			label6 = new Label();
			descriptionBox = new RichTextBox();
			label5 = new Label();
			fromBox = new TextBox();
			label4 = new Label();
			logoBox = new TextBox();
			label3 = new Label();
			titleBox = new TextBox();
			label2 = new Label();
			panel2.SuspendLayout();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			toolStrip1.SuspendLayout();
			tabPage2.SuspendLayout();
			addExtendedInformationButton.SuspendLayout();
			tabPage3.SuspendLayout();
			toolStrip3.SuspendLayout();
			tabPage4.SuspendLayout();
			toolStrip4.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Dock = DockStyle.Top;
			label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(719, 36);
			label1.TabIndex = 2;
			label1.Text = "AP Document Builder";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// resetFormButton
			// 
			resetFormButton.Dock = DockStyle.Bottom;
			resetFormButton.Location = new Point(0, 372);
			resetFormButton.Name = "resetFormButton";
			resetFormButton.Size = new Size(719, 23);
			resetFormButton.TabIndex = 20;
			resetFormButton.Text = "Reset Form";
			resetFormButton.UseVisualStyleBackColor = true;
			resetFormButton.Click += resetFormButton_Click;
			// 
			// generateDocumentButton
			// 
			generateDocumentButton.Dock = DockStyle.Bottom;
			generateDocumentButton.Location = new Point(0, 349);
			generateDocumentButton.Name = "generateDocumentButton";
			generateDocumentButton.Size = new Size(719, 23);
			generateDocumentButton.TabIndex = 12;
			generateDocumentButton.Text = "Generate Document";
			generateDocumentButton.UseVisualStyleBackColor = true;
			generateDocumentButton.Click += generateDocumentButton_Click;
			// 
			// panel2
			// 
			panel2.BorderStyle = BorderStyle.FixedSingle;
			panel2.Controls.Add(tabControl1);
			panel2.Dock = DockStyle.Right;
			panel2.Location = new Point(302, 36);
			panel2.Name = "panel2";
			panel2.Size = new Size(417, 313);
			panel2.TabIndex = 6;
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Controls.Add(tabPage3);
			tabControl1.Controls.Add(tabPage4);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(415, 311);
			tabControl1.TabIndex = 6;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(informationBox);
			tabPage1.Controls.Add(toolStrip1);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(407, 283);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Information";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// informationBox
			// 
			informationBox.Dock = DockStyle.Fill;
			informationBox.FormattingEnabled = true;
			informationBox.ItemHeight = 15;
			informationBox.Location = new Point(3, 28);
			informationBox.Name = "informationBox";
			informationBox.Size = new Size(401, 252);
			informationBox.TabIndex = 7;
			// 
			// toolStrip1
			// 
			toolStrip1.Items.AddRange(new ToolStripItem[] { addInformationButton, deleteInformationButton });
			toolStrip1.Location = new Point(3, 3);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(401, 25);
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			// 
			// addInformationButton
			// 
			addInformationButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
			addInformationButton.Image = (Image)resources.GetObject("addInformationButton.Image");
			addInformationButton.ImageTransparentColor = Color.Magenta;
			addInformationButton.Name = "addInformationButton";
			addInformationButton.Size = new Size(60, 22);
			addInformationButton.Text = "Add Item";
			addInformationButton.Click += addInformationButton_Click;
			// 
			// deleteInformationButton
			// 
			deleteInformationButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
			deleteInformationButton.Image = (Image)resources.GetObject("deleteInformationButton.Image");
			deleteInformationButton.ImageTransparentColor = Color.Magenta;
			deleteInformationButton.Name = "deleteInformationButton";
			deleteInformationButton.Size = new Size(71, 22);
			deleteInformationButton.Text = "Delete Item";
			deleteInformationButton.Click += deleteInformationButton_Click;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(extendedInformationBox);
			tabPage2.Controls.Add(addExtendedInformationButton);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(407, 283);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Extended Information";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// extendedInformationBox
			// 
			extendedInformationBox.Dock = DockStyle.Fill;
			extendedInformationBox.FormattingEnabled = true;
			extendedInformationBox.ItemHeight = 15;
			extendedInformationBox.Location = new Point(3, 28);
			extendedInformationBox.Name = "extendedInformationBox";
			extendedInformationBox.Size = new Size(401, 252);
			extendedInformationBox.TabIndex = 8;
			// 
			// addExtendedInformationButton
			// 
			addExtendedInformationButton.Items.AddRange(new ToolStripItem[] { addExtendedButton, deleteExtendedButton });
			addExtendedInformationButton.Location = new Point(3, 3);
			addExtendedInformationButton.Name = "addExtendedInformationButton";
			addExtendedInformationButton.Size = new Size(401, 25);
			addExtendedInformationButton.TabIndex = 1;
			addExtendedInformationButton.Text = "toolStrip2";
			// 
			// addExtendedButton
			// 
			addExtendedButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
			addExtendedButton.Image = (Image)resources.GetObject("addExtendedButton.Image");
			addExtendedButton.ImageTransparentColor = Color.Magenta;
			addExtendedButton.Name = "addExtendedButton";
			addExtendedButton.Size = new Size(60, 22);
			addExtendedButton.Text = "Add Item";
			addExtendedButton.Click += addExtendedButton_Click;
			// 
			// deleteExtendedButton
			// 
			deleteExtendedButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
			deleteExtendedButton.Image = (Image)resources.GetObject("deleteExtendedButton.Image");
			deleteExtendedButton.ImageTransparentColor = Color.Magenta;
			deleteExtendedButton.Name = "deleteExtendedButton";
			deleteExtendedButton.Size = new Size(71, 22);
			deleteExtendedButton.Text = "Delete Item";
			deleteExtendedButton.Click += deleteExtendedButton_Click;
			// 
			// tabPage3
			// 
			tabPage3.Controls.Add(termsAndConditionsBox);
			tabPage3.Controls.Add(toolStrip3);
			tabPage3.Location = new Point(4, 24);
			tabPage3.Name = "tabPage3";
			tabPage3.Padding = new Padding(3);
			tabPage3.Size = new Size(407, 283);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "Terms & Conditions";
			tabPage3.UseVisualStyleBackColor = true;
			// 
			// termsAndConditionsBox
			// 
			termsAndConditionsBox.Dock = DockStyle.Fill;
			termsAndConditionsBox.FormattingEnabled = true;
			termsAndConditionsBox.ItemHeight = 15;
			termsAndConditionsBox.Location = new Point(3, 28);
			termsAndConditionsBox.Name = "termsAndConditionsBox";
			termsAndConditionsBox.Size = new Size(401, 252);
			termsAndConditionsBox.TabIndex = 9;
			// 
			// toolStrip3
			// 
			toolStrip3.Items.AddRange(new ToolStripItem[] { addTermsButton, deleteTermsButton });
			toolStrip3.Location = new Point(3, 3);
			toolStrip3.Name = "toolStrip3";
			toolStrip3.Size = new Size(401, 25);
			toolStrip3.TabIndex = 1;
			toolStrip3.Text = "toolStrip3";
			// 
			// addTermsButton
			// 
			addTermsButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
			addTermsButton.Image = (Image)resources.GetObject("addTermsButton.Image");
			addTermsButton.ImageTransparentColor = Color.Magenta;
			addTermsButton.Name = "addTermsButton";
			addTermsButton.Size = new Size(60, 22);
			addTermsButton.Text = "Add Item";
			addTermsButton.Click += addTermsButton_Click;
			// 
			// deleteTermsButton
			// 
			deleteTermsButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
			deleteTermsButton.Image = (Image)resources.GetObject("deleteTermsButton.Image");
			deleteTermsButton.ImageTransparentColor = Color.Magenta;
			deleteTermsButton.Name = "deleteTermsButton";
			deleteTermsButton.Size = new Size(71, 22);
			deleteTermsButton.Text = "Delete Item";
			deleteTermsButton.Click += deleteTermsButton_Click;
			// 
			// tabPage4
			// 
			tabPage4.Controls.Add(citizenRestrictionListbox);
			tabPage4.Controls.Add(label9);
			tabPage4.Controls.Add(gangRestrictionListBox);
			tabPage4.Controls.Add(label8);
			tabPage4.Controls.Add(jobRestrictionListbox);
			tabPage4.Controls.Add(label7);
			tabPage4.Controls.Add(toolStrip4);
			tabPage4.Location = new Point(4, 24);
			tabPage4.Name = "tabPage4";
			tabPage4.Padding = new Padding(3);
			tabPage4.Size = new Size(407, 283);
			tabPage4.TabIndex = 3;
			tabPage4.Text = "Restrictions";
			tabPage4.UseVisualStyleBackColor = true;
			// 
			// citizenRestrictionListbox
			// 
			citizenRestrictionListbox.Dock = DockStyle.Top;
			citizenRestrictionListbox.FormattingEnabled = true;
			citizenRestrictionListbox.ItemHeight = 15;
			citizenRestrictionListbox.Location = new Point(3, 201);
			citizenRestrictionListbox.Name = "citizenRestrictionListbox";
			citizenRestrictionListbox.Size = new Size(401, 64);
			citizenRestrictionListbox.TabIndex = 8;
			citizenRestrictionListbox.SelectedIndexChanged += citizenRestrictionListbox_SelectedIndexChanged;
			// 
			// label9
			// 
			label9.Dock = DockStyle.Top;
			label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label9.Location = new Point(3, 186);
			label9.Name = "label9";
			label9.Size = new Size(401, 15);
			label9.TabIndex = 7;
			label9.Text = "Citizen Restrictions";
			label9.TextAlign = ContentAlignment.BottomCenter;
			// 
			// gangRestrictionListBox
			// 
			gangRestrictionListBox.Dock = DockStyle.Top;
			gangRestrictionListBox.FormattingEnabled = true;
			gangRestrictionListBox.ItemHeight = 15;
			gangRestrictionListBox.Location = new Point(3, 122);
			gangRestrictionListBox.Name = "gangRestrictionListBox";
			gangRestrictionListBox.Size = new Size(401, 64);
			gangRestrictionListBox.TabIndex = 6;
			gangRestrictionListBox.SelectedIndexChanged += gangRestrictionListBox_SelectedIndexChanged;
			// 
			// label8
			// 
			label8.Dock = DockStyle.Top;
			label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label8.Location = new Point(3, 107);
			label8.Name = "label8";
			label8.Size = new Size(401, 15);
			label8.TabIndex = 5;
			label8.Text = "Gang Restrictions";
			label8.TextAlign = ContentAlignment.BottomCenter;
			// 
			// jobRestrictionListbox
			// 
			jobRestrictionListbox.Dock = DockStyle.Top;
			jobRestrictionListbox.FormattingEnabled = true;
			jobRestrictionListbox.ItemHeight = 15;
			jobRestrictionListbox.Location = new Point(3, 43);
			jobRestrictionListbox.Name = "jobRestrictionListbox";
			jobRestrictionListbox.Size = new Size(401, 64);
			jobRestrictionListbox.TabIndex = 4;
			jobRestrictionListbox.SelectedIndexChanged += jobRestrictionListbox_SelectedIndexChanged;
			// 
			// label7
			// 
			label7.Dock = DockStyle.Top;
			label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label7.Location = new Point(3, 28);
			label7.Name = "label7";
			label7.Size = new Size(401, 15);
			label7.TabIndex = 3;
			label7.Text = "Job Restrictions";
			label7.TextAlign = ContentAlignment.BottomCenter;
			// 
			// toolStrip4
			// 
			toolStrip4.Items.AddRange(new ToolStripItem[] { addRestrictionButton, deleteRestrictionButton });
			toolStrip4.Location = new Point(3, 3);
			toolStrip4.Name = "toolStrip4";
			toolStrip4.Size = new Size(401, 25);
			toolStrip4.TabIndex = 2;
			toolStrip4.Text = "toolStrip4";
			// 
			// addRestrictionButton
			// 
			addRestrictionButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
			addRestrictionButton.Image = (Image)resources.GetObject("addRestrictionButton.Image");
			addRestrictionButton.ImageTransparentColor = Color.Magenta;
			addRestrictionButton.Name = "addRestrictionButton";
			addRestrictionButton.Size = new Size(60, 22);
			addRestrictionButton.Text = "Add Item";
			addRestrictionButton.Click += addRestrictionButton_Click;
			// 
			// deleteRestrictionButton
			// 
			deleteRestrictionButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
			deleteRestrictionButton.Image = (Image)resources.GetObject("deleteRestrictionButton.Image");
			deleteRestrictionButton.ImageTransparentColor = Color.Magenta;
			deleteRestrictionButton.Name = "deleteRestrictionButton";
			deleteRestrictionButton.Size = new Size(71, 22);
			deleteRestrictionButton.Text = "Delete Item";
			deleteRestrictionButton.Click += deleteRestrictionButton_Click;
			// 
			// panel1
			// 
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(disclaimerBox);
			panel1.Controls.Add(label6);
			panel1.Controls.Add(descriptionBox);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(fromBox);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(logoBox);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(titleBox);
			panel1.Controls.Add(label2);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(0, 36);
			panel1.Name = "panel1";
			panel1.Size = new Size(297, 313);
			panel1.TabIndex = 5;
			// 
			// disclaimerBox
			// 
			disclaimerBox.Dock = DockStyle.Top;
			disclaimerBox.Location = new Point(0, 252);
			disclaimerBox.Name = "disclaimerBox";
			disclaimerBox.Size = new Size(295, 56);
			disclaimerBox.TabIndex = 5;
			disclaimerBox.Text = "";
			// 
			// label6
			// 
			label6.Dock = DockStyle.Top;
			label6.Location = new Point(0, 227);
			label6.Name = "label6";
			label6.Size = new Size(295, 25);
			label6.TabIndex = 9;
			label6.Text = "Document Disclaimer";
			label6.TextAlign = ContentAlignment.BottomCenter;
			// 
			// descriptionBox
			// 
			descriptionBox.Dock = DockStyle.Top;
			descriptionBox.Location = new Point(0, 169);
			descriptionBox.Name = "descriptionBox";
			descriptionBox.Size = new Size(295, 58);
			descriptionBox.TabIndex = 4;
			descriptionBox.Text = "";
			// 
			// label5
			// 
			label5.Dock = DockStyle.Top;
			label5.Location = new Point(0, 144);
			label5.Name = "label5";
			label5.Size = new Size(295, 25);
			label5.TabIndex = 7;
			label5.Text = "Document Description";
			label5.TextAlign = ContentAlignment.BottomCenter;
			// 
			// fromBox
			// 
			fromBox.Dock = DockStyle.Top;
			fromBox.Location = new Point(0, 121);
			fromBox.Name = "fromBox";
			fromBox.Size = new Size(295, 23);
			fromBox.TabIndex = 3;
			// 
			// label4
			// 
			label4.Dock = DockStyle.Top;
			label4.Location = new Point(0, 96);
			label4.Name = "label4";
			label4.Size = new Size(295, 25);
			label4.TabIndex = 5;
			label4.Text = "Document From";
			label4.TextAlign = ContentAlignment.BottomCenter;
			// 
			// logoBox
			// 
			logoBox.Dock = DockStyle.Top;
			logoBox.Location = new Point(0, 73);
			logoBox.Name = "logoBox";
			logoBox.Size = new Size(295, 23);
			logoBox.TabIndex = 2;
			// 
			// label3
			// 
			label3.Dock = DockStyle.Top;
			label3.Location = new Point(0, 48);
			label3.Name = "label3";
			label3.Size = new Size(295, 25);
			label3.TabIndex = 3;
			label3.Text = "Document Logo";
			label3.TextAlign = ContentAlignment.BottomCenter;
			// 
			// titleBox
			// 
			titleBox.Dock = DockStyle.Top;
			titleBox.Location = new Point(0, 25);
			titleBox.Name = "titleBox";
			titleBox.Size = new Size(295, 23);
			titleBox.TabIndex = 1;
			// 
			// label2
			// 
			label2.Dock = DockStyle.Top;
			label2.Location = new Point(0, 0);
			label2.Name = "label2";
			label2.Size = new Size(295, 25);
			label2.TabIndex = 1;
			label2.Text = "Document Title";
			label2.TextAlign = ContentAlignment.BottomCenter;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(719, 395);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Controls.Add(generateDocumentButton);
			Controls.Add(resetFormButton);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "MainForm";
			Text = "AP Document Builder";
			Load += MainForm_Load;
			panel2.ResumeLayout(false);
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			addExtendedInformationButton.ResumeLayout(false);
			addExtendedInformationButton.PerformLayout();
			tabPage3.ResumeLayout(false);
			tabPage3.PerformLayout();
			toolStrip3.ResumeLayout(false);
			toolStrip3.PerformLayout();
			tabPage4.ResumeLayout(false);
			tabPage4.PerformLayout();
			toolStrip4.ResumeLayout(false);
			toolStrip4.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private Button resetFormButton;
		private Button generateDocumentButton;
		private Panel panel2;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private ListBox informationBox;
		private ToolStrip toolStrip1;
		private ToolStripButton addInformationButton;
		private ToolStripButton deleteInformationButton;
		private TabPage tabPage2;
		private ListBox extendedInformationBox;
		private ToolStrip addExtendedInformationButton;
		private ToolStripButton addExtendedButton;
		private ToolStripButton deleteExtendedButton;
		private TabPage tabPage3;
		private ListBox termsAndConditionsBox;
		private ToolStrip toolStrip3;
		private ToolStripButton addTermsButton;
		private ToolStripButton deleteTermsButton;
		private Panel panel1;
		private RichTextBox disclaimerBox;
		private Label label6;
		private RichTextBox descriptionBox;
		private Label label5;
		private TextBox fromBox;
		private Label label4;
		private TextBox logoBox;
		private Label label3;
		private TextBox titleBox;
		private Label label2;
		private RichTextBox richTextBox2;
		private RichTextBox richTextBox1;
		private TextBox textBox3;
		private TextBox textBox2;
		private TextBox textBox1;
		private ToolStrip toolStrip2;
		private ToolStripButton toolStripButton4;
		private ToolStripButton toolStripButton5;
		private ToolStripButton toolStripButton6;
		private ListBox listBox1;
		private TabPage tabPage4;
		private ListBox citizenRestrictionListbox;
		private Label label9;
		private ListBox gangRestrictionListBox;
		private Label label8;
		private ListBox jobRestrictionListbox;
		private Label label7;
		private ToolStrip toolStrip4;
		private ToolStripButton addRestrictionButton;
		private ToolStripButton deleteRestrictionButton;
	}
}