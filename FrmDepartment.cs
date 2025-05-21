using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace Department.WinForms
{
    public partial class FrmDepartment : Form
    {
        private readonly HttpClient client;
        private readonly string baseUrl = "https://localhost:7035/api/Departments/";
        public FrmDepartment()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            LoadDepartments().ConfigureAwait(false);
        }

        //private void FrmDepartment_Load(object sender, EventArgs e)
        //{
        //    this.tblDepartmentsTableAdapter.Fill(this.departmentDbDataSet.tblDepartments);
        //}
        private async Task LoadDepartments()
        {
            try
            {
                var response = await client.GetAsync("GetAll");
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var departments = JsonConvert.DeserializeObject<List<Models.Department>>(jsonResponse);
                    grdDisplay.DataSource = null;
                    grdDisplay.DataSource = departments;
                    grdDisplay.Columns[0].HeaderText = "Dept ID";
                    grdDisplay.Columns[1].HeaderText = "Dept Name";
                    grdDisplay.Columns[2].HeaderText = "Is Active";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task InsertDepartment()
        {
            try
            {
                var department = new Models.Department
                {
                    Name = txtDeptNameVal.Text.Trim(),
                    IsActive = chkIsActiveVal.Checked
                };

                var json = JsonConvert.SerializeObject(department);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("Add", content);
                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Department added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDepartments();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeptNameVal.Text))
            {
                MessageBox.Show("Please enter a department name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await InsertDepartment();
        }

        private async Task UpdateDepartment()
        {
            try
            {
                var department = new Models.Department
                {
                    Sno = int.Parse(lblDeptIdVal.Text),
                    Name = txtDeptNameVal.Text.Trim(),
                    IsActive = chkIsActiveVal.Checked
                };

                var json = JsonConvert.SerializeObject(department);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"Update/{department.Sno}", content);  
                response.EnsureSuccessStatusCode(); 

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Department updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDepartments();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeptNameVal.Text))
            {
                MessageBox.Show("Please enter a department name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            await UpdateDepartment();
        }
        private async Task DeleteDepartment()
        {
            try
            {
                var departmentId = int.Parse(lblDeptIdVal.Text);

                var result = MessageBox.Show("Are you sure you want to delete this department?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var response = await client.DeleteAsync($"Delete/{departmentId}");  
                    response.EnsureSuccessStatusCode(); 

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Department deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadDepartments(); 
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e) => await DeleteDepartment();
        private void grdDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                else
                {
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    DataGridViewRow row = grdDisplay.Rows[e.RowIndex];
                    lblDeptIdVal.Text = row.Cells[0].Value.ToString();
                    txtDeptNameVal.Text = row.Cells[1].Value.ToString();
                    bool isActive = (bool)row.Cells[2].Value;
                    chkIsActiveVal.Checked = isActive;
                    chkIsActiveVal.Text = isActive ? "Active" : "Inactive";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearForm();
        private void ClearForm()
        {
            lblDeptIdVal.Text = string.Empty;
            txtDeptNameVal.Text = string.Empty;
            chkIsActiveVal.Checked = true;
            chkIsActiveVal.Text = string.Empty;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}
