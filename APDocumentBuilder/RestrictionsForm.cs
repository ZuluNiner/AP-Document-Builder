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
	public partial class RestrictionsForm : Form
	{
		private MainForm parent;
		public RestrictionsForm(MainForm prnt)
		{
			parent = prnt;
			InitializeComponent();
		}

		private void restrictionTypeBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (restrictionTypeBox.SelectedIndex != -1 && restrictionTypeBox.Items[restrictionTypeBox.SelectedIndex] == "Citizen")
				restrictionGradesBox.Enabled = false;
			else
				restrictionGradesBox.Enabled = true;
		}

		private void submitButton_Click(object sender, EventArgs e)
		{
			switch (restrictionTypeBox.Items[restrictionTypeBox.SelectedIndex].ToString())
			{
				case "Job":
					parent.addJobRestrictions(restrictionIdBox.Text,restrictionGradesBox.Text);
					break;
				case "Gang":
					parent.addGangRestrictions(restrictionIdBox.Text, restrictionGradesBox.Text);
					break;
				case "Citizen":
					parent.addCitizenRestriction(restrictionIdBox.Text);
					break;
			}
			this.Close();
		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			restrictionTypeBox.SelectedIndex = -1;
			restrictionIdBox.Clear();
			restrictionGradesBox.Clear();
		}
	}
}
