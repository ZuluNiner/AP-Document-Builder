using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APDocumentBuilder
{
	public partial class TermsForm : Form
	{
		private MainForm parent;
		public TermsForm(MainForm prnt)
		{
			parent = prnt;
			InitializeComponent();
		}

		private void TermsForm_Load(object sender, EventArgs e)
		{

		}

		private void submitFormButton_Click(object sender, EventArgs e)
		{
			parent.addTerms(termsBox.Text);
			this.Close();
		}

		private void resetFormButton_Click(object sender, EventArgs e)
		{
			termsBox.Clear();
		}
	}
}
