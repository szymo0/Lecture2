using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Domain;
using Lecture2.Models;

namespace Lecture2
{
    public partial class MainForm : Form
    {
        private List<ContactInfo> _contactInfos = new List<ContactInfo>();

        public MainForm()
        {
            InitializeComponent();
#if DEBUG
            InitContactInfo();
#endif
            //This don't work properly:( 
            //AddColumnsProgramical();

            //dataGridView1.DataSource = _contactInfos.Select(c => new ContactInfoModel(c)).ToList();

            //This don;t work too :(
            //AddColumnsProgramical();

        }

        private void AddColumnsProgramical()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(
                new DataGridViewTextBoxColumn()
                {
                    Name = "ContactId",
                    HeaderText = "Id",
                    DataPropertyName = "Id",
                    Visible = false,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                    ReadOnly = true
                }
            );
            dataGridView1.Columns.Add(
                new DataGridViewTextBoxColumn()
                {
                    Name = "ContactInfoName",
                    HeaderText = "Name",
                    DataPropertyName = "Name",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                    ReadOnly = true
                }
            );
            dataGridView1.Columns.Add(
                new DataGridViewTextBoxColumn()
                {
                    Name = "ContactInfoPhoneNumber",
                    HeaderText = "Phone number",
                    DataPropertyName = "PhoneNumber",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                    ReadOnly = true
                }
            );
            dataGridView1.Columns.Add(
                new DataGridViewButtonColumn()
                {
                    Name = "Edit",
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                    ReadOnly = true,
                }
            );
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        private async void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsEditButton(e))
            {
                PersonalForm personalForm = new PersonalForm();
                var id = dataGridView1.Rows[e.RowIndex].Cells["ContactId"].Value as Guid?;
                if (id.HasValue)
                {
                    var result = await GetFromDb(id.Value);
                    personalForm.Bind(result);
                    personalForm.ShowDialog();
                }
            }
        }

        private async Task<ContactInfo> GetFromDb(Guid? id)
        {

            return await Task.Run(() =>
            {
                var entity = _contactInfos.FirstOrDefault(c => id.HasValue && c.Id == id.Value);
                Thread.Sleep(3000);
                return entity;
            });
        }

        private bool IsEditButton(DataGridViewCellEventArgs e)
        {
            var column = dataGridView1.Columns[e.ColumnIndex] as DataGridViewButtonColumn;
            if (column != null && e.RowIndex != -1 && column.Text == "Edit")
            {
                return true;
            }
            return false;
        }

        private void InitContactInfo()
        {
            _contactInfos = InitData.GetDebugData().ToList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //This work properly:)
            AddColumnsProgramical();
        }

        private async Task<IEnumerable<ContactInfoModel>> DownloadData()
        {
            var result = Task.Run(
                () =>
                {
                    Thread.Sleep(3000);
                    return _contactInfos.Select(c => new ContactInfoModel(c)).AsEnumerable();
                });

            return await result;

        }

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            var result = await DownloadData();
            dataGridView1.DataSource = result.ToList();
        }
    }
}
