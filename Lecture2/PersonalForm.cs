using System.Windows.Forms;
using ContactsApp.Domain;
using Lecture2.Models;

namespace Lecture2
{
    public partial class PersonalForm : Form
    {
        private ContactInfoModel _entityModel;

        public PersonalForm()
        {
            InitializeComponent();
        }

        public void Bind(ContactInfo model)
        {
            _entityModel=new ContactInfoModel(model);
            txtName.DataBindings.Add("Text", _entityModel, "FirstName");
            txtSurname.DataBindings.Add("Text", _entityModel, "LastName");
        }
    }
}
