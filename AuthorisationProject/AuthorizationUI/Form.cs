using AuthorizationData;
using AuthorizationData.Entities;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Collections;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using static System.String;

namespace AuthorizationUI
{
    public partial class AuthorizationForm : Form
    {
        private AuthorizationDbContext _dbContext;

        public AuthorizationForm()
        {
            InitializeComponent();
            _dbContext = new AuthorizationDbContext();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture =
                System.Globalization.CultureInfo.CreateSpecificCulture("ro");
            SetActivityProfiles();
            SetSubdivisions();
        }

        private void SubdivisionNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_dbContext.Subdivisions.Any(s => s.Name == SubdivisionNameTextBox.Text))
            {
                SubdivisionNameTextBox.Text = Empty;
                MessageBox.Show("Subdiviziunea exista deja", "Eroare");
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (!IsInputDataNull())
            {
                InsertDataToDataBase();
                // Refresh the Subdivisions.
                SetSubdivisions();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Completati toate spatiile libere", "Eroare",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = GetFilteredData();
        }

        #region HelperMothods

        private void SetSubdivisions()
        {
            var subdivisions = _dbContext.Subdivisions.Select(s => s.Name).ToList();
            subdivisions.Insert(0, Empty);
            SubdivisionsComboBoxInsertTab.DataSource = subdivisions;
            SubdivisionsComboBoxISearchTab.DataSource = subdivisions;
        }

        private void ClearTextBoxes()
        {
            foreach (GroupBox gb in InsertTab.Controls.OfType<GroupBox>())
            {
                foreach (TextBox tb in gb.Controls.OfType<TextBox>())
                {
                    tb.Text = Empty;
                }
            }
        }

        private void SetActivityProfiles()
        {
            var activities = _dbContext.ActivityProfiles.ToList();

            foreach (var item in activities)
            {
                ActivityListInsertTab.Items.Add(item.Activity);
            }
        }

        private bool IsInputDataNull()
        {
            var result = IsNullOrEmpty(ASVFTextBox.Text)
            && IsNullOrEmpty(AgentNameTextBox.Text)
            && IsNullOrEmpty(AgentAddressTextBox.Text)
            && IsNullOrEmpty(AgentPhoneTextBox.Text)
            && IsNullOrEmpty(ObjectNameTextBox.Text)
            && IsNullOrEmpty(ObjectPhoneTextBox.Text)
            && IsNullOrEmpty(ObjectAddressTextBox.Text);

            if (SubdivisionsComboBoxInsertTab.Text == Empty)
            {
                result = result && IsNullOrEmpty(SubdivisionNameTextBox.Text)
                && IsNullOrEmpty(SubdivizionPhoneTextBox.Text)
                && IsNullOrEmpty(LeaderFirstNameTextbox.Text)
                && IsNullOrEmpty(LeaderLastNameTextBox.Text);
            }
            if (ActivityListInsertTab.SelectedItems.Count == 0)
            {
                result = result && true;
            }

            return result;
        }

        private void InsertDataToDataBase()
        {
            Subdivision subdivision;

            if (SubdivisionsComboBoxInsertTab.Text != Empty)
            {
                var existingSubdivision = _dbContext
                    .Subdivisions
                    .SingleOrDefault(s => s.Name == SubdivisionsComboBoxInsertTab.Text);

                subdivision = existingSubdivision;
            }
            else
            {
                var newSubdivision = new Subdivision
                {
                    Name = SubdivisionNameTextBox.Text,
                    Phone = SubdivizionPhoneTextBox.Text,
                    LeaderFirstName = LeaderFirstNameTextbox.Text,
                    LeaderLastName = LeaderLastNameTextBox.Text
                };
                subdivision = _dbContext.Subdivisions.Add(newSubdivision);
            }

            var agent = new Agent
            {
                Name = AgentNameTextBox.Text,
                Address = AgentAddressTextBox.Text,
                Phone = AgentPhoneTextBox.Text
            };
            var addesAgent = _dbContext.Agents.Add(agent);

            var authorization = new Authorization
            {
                ASVF = ASVFTextBox.Text,
                EliberationDate = EliberationDateTime.Value.Date,
                ExpireDate = ExpirationDateTime.Value.Date,
                AuthorizatedObjectName = ObjectNameTextBox.Text,
                AuthorizatedObjectAddress = ObjectAddressTextBox.Text,
                AuthorizatedObjectPhone = ObjectPhoneTextBox.Text,
                SubdivisionId = subdivision.Id,
                AgentId = addesAgent.Id,

            };

            var addedAuthorization = _dbContext.Authorizations.Add(authorization);
            var checkedActivities = ActivityListInsertTab.CheckedItems;

            foreach (string item in checkedActivities)
            {
                var activity = _dbContext.ActivityProfiles.Where(ap => ap.Activity == item).SingleOrDefault();
                _dbContext.Authorizations.Find(addedAuthorization.Id).ActivityProfiles.Add(activity);
            }

            _dbContext.SaveChanges();
        }

        private ICollection GetFilteredData()
        {
            var result = _dbContext.Authorizations.Include(ap => ap.ActivityProfiles)
                                                 .Include(ap => ap.Agent)
                                                 .Include(ap => ap.Subdivision)
                                                 .ToList()
                                                 .Select(at => new AuthorisationModel
                                                 {
                                                     ASVF = at.ASVF,
                                                     AgentName = at.Agent.Name,
                                                     AgentAddress = at.Agent.Address,
                                                     AgentPhone = at.Agent.Phone,
                                                     AuthorzatedObjectName = at.AuthorizatedObjectName,
                                                     AuthorizatedObjectAddress = at.AuthorizatedObjectAddress,
                                                     AuthorizatedObjectPhone = at.AuthorizatedObjectPhone,
                                                     SubdivisionName = at.Subdivision.Name,
                                                     EliberationDate = at.EliberationDate,
                                                     ExpirationDate = at.ExpireDate,
                                                     Activities = at.ActivityProfiles.Select(ac => ac.Activity).ToList()
                                                                                     .Aggregate((current, next) => Concat(current, ",  ", next))

                                                 });
            

            if (EliberationDateSearch.Value.Date < ExpirationDateSearch.Value.Date)
            {
                result = result.Where(at => at.EliberationDate >= EliberationDateSearch.Value.Date)
                               .Where(at => at.ExpirationDate <= ExpirationDateSearch.Value.Date);
            }

            if (ASVFSearchBox.Text != Empty)
            {
                result = result.Where(a => a.ASVF.ToLower().Contains(ASVFSearchBox.Text.ToLower()));
            }

            if (ObjectSearchBox.Text != Empty)
            {
                result = result.Where(a => a.AuthorzatedObjectName.ToLower().Contains(ObjectSearchBox.Text.ToLower()));
            }

            if (AgentSearchBox.Text != Empty)
            {
                result = result.Where(a => a.AgentName.ToLower().Contains(AgentSearchBox.Text.ToLower()));
            }
            if (SubdivisionsComboBoxISearchTab.Text != Empty)
            {
                result = result.Where(a => a.SubdivisionName.ToLower().Contains(SubdivisionsComboBoxISearchTab.Text.ToLower()));
            }

            return result.ToList();
        }

        #endregion

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = @"Salveaza in format Excel";
            saveFileDialog.Filter = @"Excel |*.xlsx";


            if ( saveFileDialog.ShowDialog() != DialogResult.Cancel )
            {
                Excel.Application excelFile = new Excel.Application();
                excelFile.Application.Workbooks.Add(Type.Missing);
                excelFile.Columns.ColumnWidth = 25;

                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    excelFile.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                }

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        excelFile.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();           
                    }
                }
                excelFile.ActiveWorkbook.SaveCopyAs(saveFileDialog.FileName);
                excelFile.ActiveWorkbook.Saved = true;
                excelFile.Quit();

            }
        }

    }

}
