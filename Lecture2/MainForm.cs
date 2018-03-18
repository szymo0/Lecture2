using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Domain;

namespace Lecture2
{
    public partial class MainForm : Form
    {
        private List<ContactInfo> _contactInfos=new List<ContactInfo>();

        public MainForm()
        {
            InitializeComponent();
#if DEBUG
            InitContactInfo();
#endif

            dataGridView1.DataSource = _contactInfos;

        }

        private void InitContactInfo()
        {
            _contactInfos = InitData.GetDebugData().ToList();
        }

    }
}
