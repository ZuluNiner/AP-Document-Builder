namespace APDocumentBuilder
{
	public partial class MainForm : Form
	{

		//Variables
		private List<InformationItem> informationItems;
		private List<InformationItem> extendedItems;
		private List<string> termsItems;
		private Dictionary<string, string> jobRestrictions;
		private Dictionary<string, string> gangRestrictions;
		private List<string> citizenRestrictions;

		//Functions
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			informationItems = new List<InformationItem>();
			extendedItems = new List<InformationItem>();
			termsItems = new List<string>();

			jobRestrictions = new Dictionary<string, string>();
			gangRestrictions = new Dictionary<string, string>();
			citizenRestrictions = new List<string>();
		}

		private void addInformationButton_Click(object sender, EventArgs e)
		{
			ItemForm frm = new ItemForm(this);
			frm.Show();
		}

		private void deleteInformationButton_Click(object sender, EventArgs e)
		{
			if (informationBox.SelectedIndex == -1)
				return;
			string id = informationBox.Items[informationBox.SelectedIndex].ToString().Split(" - ")[0].Trim();
			informationItems.Remove(informationItems.Find(x => x.id == id));
			informationBox.Items.Remove(informationBox.Items[informationBox.SelectedIndex].ToString());
		}

		private void addExtendedButton_Click(object sender, EventArgs e)
		{
			ItemForm frm = new ItemForm(this);
			frm.isExtended = true;
			frm.Show();
		}

		private void deleteExtendedButton_Click(object sender, EventArgs e)
		{
			if (extendedInformationBox.SelectedIndex == -1)
				return;
			string id = informationBox.Items[extendedInformationBox.SelectedIndex].ToString().Split(" - ")[0].Trim();
			extendedItems.Remove(extendedItems.Find(x => x.id == id));
			extendedInformationBox.Items.Remove(extendedInformationBox.Items[extendedInformationBox.SelectedIndex].ToString());
		}

		private void addTermsButton_Click(object sender, EventArgs e)
		{
			TermsForm frm = new TermsForm(this);
			frm.Show();
		}

		private void deleteTermsButton_Click(object sender, EventArgs e)
		{
			if (termsAndConditionsBox.SelectedIndex == -1)
				return;
			termsItems.Remove(termsAndConditionsBox.Items[termsAndConditionsBox.SelectedIndex].ToString());
			termsAndConditionsBox.Items.Remove(termsAndConditionsBox.Items[termsAndConditionsBox.SelectedIndex].ToString());
		}

		public void addInformation(InformationItem item)
		{
			item.id = "i" + (informationItems.Count + 1).ToString();
			informationItems.Add(item);
			informationBox.Items.Add(StructureItemLine(item));
		}

		public void addExtended(InformationItem item)
		{
			item.id = "e" + (extendedItems.Count + 1).ToString();
			extendedItems.Add(item);
			extendedInformationBox.Items.Add(StructureItemLine(item));
		}

		public void addTerms(string item)
		{
			termsItems.Add(item);
			termsAndConditionsBox.Items.Add(item);
		}

		public void addCitizenRestriction(string id)
		{
			citizenRestrictions.Add(id);
			citizenRestrictionListbox.Items.Add(id);
		}

		public void addGangRestrictions(string job, string grades)
		{
			gangRestrictions.Add(job, grades);
			gangRestrictionListBox.Items.Add(job + " - " + grades);
		}

		public void addJobRestrictions(string job, string grades)
		{
			jobRestrictions.Add(job, grades);
			jobRestrictionListbox.Items.Add(job + " - " + grades);
		}

		public void removeJobRestrictions(string job)
		{
			citizenRestrictionListbox.Items.Remove(job + " - " + jobRestrictions[job]);
			jobRestrictions.Remove(job);

		}

		public void removeGangRestrictions(string job)
		{
			gangRestrictionListBox.Items.Remove(job + " - " + gangRestrictions[job]);
			gangRestrictions.Remove(job);
		}

		public void removeCitizenRestrictions(string id)
		{
			citizenRestrictionListbox.Items.Remove(id);
			citizenRestrictions.Remove(id);
		}

		private void generateDocumentButton_Click(object sender, EventArgs e)
		{
			string results = "[\"" + titleBox.Text + "\"] = {" + Environment.NewLine + "\ttype=\"create\"," + Environment.NewLine + "\trestriction = {" + Environment.NewLine + "\t\tjob = {" + Environment.NewLine + "\t\t\t";
			if (jobRestrictions.Count == 0)
				results += "enable = false, jobs={}},";
			else
			{
				results += "enable = true," + Environment.NewLine + "\t\t\t jobs={" + Environment.NewLine;
				foreach (KeyValuePair<string, string> restriction in jobRestrictions)
				{
					string[] grades = null;
					if (restriction.Value.Contains(','))
					{
						grades = restriction.Value.Split(',');
					}
					results += "\t\t\t\t[\"" + restriction.Key + "\"] = ";
					if (grades != null)
					{
						results += "{";
						string gradeResults = "";
						foreach (string grade in grades)
						{
							gradeResults += grade + ",";
						}
						gradeResults = gradeResults.Trim(',');
						results += gradeResults + "}," + Environment.NewLine;
					}
					if (restriction.Value.ToLower() == "all")
					{
						results += "\"all\"," + Environment.NewLine;
					}
				}
				results += "\t\t}}," + Environment.NewLine;
			}

			results += "\t\tgang = {" + Environment.NewLine + "\t\t\tenable = ";

			if (gangRestrictions.Count == 0)
				results += "false, gangs={}},";
			else
			{
				results += "true," + Environment.NewLine + "\t\t\tgangs={" + Environment.NewLine;
				foreach (KeyValuePair<string, string> restriction in gangRestrictions)
				{
					string[] grades = null;
					if (restriction.Value.Contains(','))
					{
						grades = restriction.Value.Split(',');
					}
					results += "\t\t\t\t[\"" + restriction.Key + "\"] = ";
					if (grades != null)
					{
						results += "{";
						string gradeResults = "";
						foreach (string grade in grades)
						{
							gradeResults += grade + ",";
						}
						gradeResults = gradeResults.Trim(',');
						results += gradeResults + "}," + Environment.NewLine;
					}
					if (restriction.Value.ToLower() == "all")
					{
						results += "\"all\"," + Environment.NewLine;
					}
				}
				results += "\t\t\t}" + Environment.NewLine + "\t\t},";
			}

			results += Environment.NewLine + "\t\t" + "citizenid = ";
			if (citizenRestrictions.Count == 0)
				results += "{enable = false, id = {}}" + Environment.NewLine + "\t\t},";
			else
			{
				results += "{" + Environment.NewLine + "\t\t\tenable = true," + Environment.NewLine + "\t\t\tid = {";
				string citResults = "";
				foreach (string restriction in citizenRestrictions)
				{
					citResults += "\t\t\t\t\"" + restriction + "\"," + Environment.NewLine;
				}
				citResults = citResults.Trim().Trim(',');
				results += citResults + "}" + Environment.NewLine + "\t\t}" + Environment.NewLine + "\t},";
			}


			results += Environment.NewLine + "\ttitle = \"" + titleBox.Text + "\"," + Environment.NewLine + "\tlogo = \"" + logoBox.Text + "\"," + Environment.NewLine + "\tfrom=\"" + fromBox.Text + "\"," + Environment.NewLine + "\tdescription = \"" + descriptionBox.Text + "\"," + Environment.NewLine + "\tdisclaimer = \"" + disclaimerBox.Text + "\"," + Environment.NewLine + "\tinformation = {" + Environment.NewLine;
			int ai = 1;
			foreach (InformationItem item in informationItems)
			{
				results += "\t\t{ id = \"i" + ai.ToString() + "\", label = \"" + item.label + "\", type = \"" + item.type + "\", placement = \"" + item.placement + "\", required = \"" + item.required + "\", value = \"\"}," + Environment.NewLine;
				ai++;
			}
			results = results.Trim();
			results = results.Trim(',') + Environment.NewLine + "\t}," + Environment.NewLine + "\textended_information = {" + Environment.NewLine;
			ai = 1;
			foreach (InformationItem item in extendedItems)
			{
				results += "\t\t{ id = \"e" + ai.ToString() + "\", label = \"" + item.label + "\", type = \"" + item.type + "\", placement = \"" + item.placement + "\", required = \"" + item.required + "\", value = \"\"}," + Environment.NewLine;
				ai++;
			}
			results = results.Trim();
			results = results.Trim(',') + Environment.NewLine + "\t}," + Environment.NewLine + "\tterms_and_conditions = {" + Environment.NewLine;
			foreach (string item in termsItems)
			{
				results += "\t\t{label = \"" + item + "\"},";
			}
			results = results.Trim(',') + Environment.NewLine + "\t}," + Environment.NewLine + "\tsign = \"\"" + Environment.NewLine + "},";
			Clipboard.SetText(results);

			MessageBox.Show("The results have been copied to your clipboard");
		}

		private void resetFormButton_Click(object sender, EventArgs e)
		{
			var conf = MessageBox.Show("Are you sure you want to reset the form?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (conf == DialogResult.No)
				return;

			titleBox.Clear();
			logoBox.Clear();
			fromBox.Clear();
			descriptionBox.Clear();
			disclaimerBox.Clear();
			informationItems.Clear();
			informationBox.Items.Clear();
			extendedItems.Clear();
			extendedInformationBox.Items.Clear();
			termsItems.Clear();
			termsAndConditionsBox.Items.Clear();

			tabControl1.SelectedIndex = 0;
		}

		private string StructureItemLine(InformationItem item)
		{
			return item.id + " - " + item.label + " - " + item.type + " - " + item.placement + " - " + item.required;
		}

		private void addRestrictionButton_Click(object sender, EventArgs e)
		{
			RestrictionsForm frm = new RestrictionsForm(this);
			frm.Show();
		}

		private void jobRestrictionListbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (jobRestrictionListbox.SelectedIndex == -1)
				return;

			gangRestrictionListBox.SelectedIndex = -1;
			citizenRestrictionListbox.SelectedIndex = -1;
		}

		private void gangRestrictionListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (gangRestrictionListBox.SelectedIndex == -1)
				return;

			jobRestrictionListbox.SelectedIndex = -1;
			citizenRestrictionListbox.SelectedIndex = -1;
		}

		private void citizenRestrictionListbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (citizenRestrictionListbox.SelectedIndex == -1)
				return;

			jobRestrictionListbox.SelectedIndex = -1;
			gangRestrictionListBox.SelectedIndex = -1;
		}

		private void deleteRestrictionButton_Click(object sender, EventArgs e)
		{
			if(jobRestrictionListbox.SelectedIndex != -1)
			{
				string selected = jobRestrictionListbox.Items[jobRestrictionListbox.SelectedIndex].ToString();
				jobRestrictionListbox.Items.Remove(selected);
				string job = selected.Split(" - ")[0];
				jobRestrictions.Remove(job);
			}
			if(gangRestrictionListBox.SelectedIndex != -1)
			{
				string selected = gangRestrictionListBox.Items[gangRestrictionListBox.SelectedIndex].ToString();
				gangRestrictionListBox.Items.Remove(selected);
				string job = selected.Split(" - ")[0];
				gangRestrictions.Remove(job);
			}
			if(citizenRestrictionListbox.SelectedIndex != -1)
			{
				string selected = citizenRestrictionListbox.Items[citizenRestrictionListbox.SelectedIndex].ToString();
				citizenRestrictions.Remove(selected);
				citizenRestrictionListbox.Items.Remove(selected);
			}
		}
	}
}