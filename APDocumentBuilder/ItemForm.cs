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
	public partial class ItemForm : Form
	{
		public bool isExtended = false;
		private MainForm parent;
		public ItemForm(MainForm prnt)
		{
			parent = prnt;
			InitializeComponent();
		}

		private void ItemForm_Load(object sender, EventArgs e)
		{
			if (isExtended)
			{
				typeBox.Items.Add("text_area");
			}
		}

		private void submitFormButton_Click(object sender, EventArgs e)
		{
			InformationItem itm = new InformationItem();
			itm.type = typeBox.Text;
			itm.label = labelBox.Text;
			itm.required = requiredCheckbox.Checked.ToString();
			itm.placement = placementBox.Text;
			if (isExtended)
				parent.addExtended(itm);
			else
				parent.addInformation(itm);

			this.Close();
		}

		private void resetFormButton_Click(object sender, EventArgs e)
		{
			requiredCheckbox.Checked = false;
			labelBox.Clear();
			typeBox.SelectedIndex = -1;
			placementBox.Clear();
		}
	}
}
