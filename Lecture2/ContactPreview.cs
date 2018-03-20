using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Domain.Events;
using ContactsApp.Domain.Repositories;
using Lecture2.Infrastucture;
using Lecture2.Models;

namespace Lecture2
{
    public partial class ContactPreview : Form, IBindable<ContactInfoModel>
    {
        private ContactInfoModel _bindingContext;
        private IContactInfoRepository _contactInfoRepository=new ContactInfoRepository();
        public ContactPreview()
        {
            InitializeComponent();
        }

        public Task<bool> Bind(ContactInfoModel bindContext)
        {
            _bindingContext = bindContext;
            lblName.DataBindings.Add("Text", _bindingContext, "Name");
            lblPrimaryPhone.DataBindings.Add("Text", _bindingContext, "PhoneNumber");
            lblAddress.DataBindings.Add("Text", _bindingContext, "AddressDisplay");
            lblBirthDate.DataBindings.Add("Text", _bindingContext, "DateOfBirthDisplay");
            lblFirstNames.DataBindings.Add("Text", _bindingContext, "FirstName");
            lblSurnames.DataBindings.Add("Text", _bindingContext, "LastName");
            lblSex.DataBindings.Add("Text", _bindingContext, "SexDisplay");
            lblRelation.DataBindings.Add("Text", _bindingContext, "RelationshipDisplay");

            if (_bindingContext.AlterantePhonse!=null)
            {
                foreach (var phone in _bindingContext.AlterantePhonse)
                {
                    panel1.Controls.Add(new Label()
                    {
                        Text = phone,
                        AutoSize = true
                    });
                }
            }

            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            if (_bindingContext.Emails != null)
            {
                foreach (var email in _bindingContext.Emails)
                {
                    flowLayoutPanel1.Controls.Add(new Label()
                    {
                        Text = email,
                        AutoSize = true
                    });
                }
            }

            return Task.FromResult(true);
        }

        private async void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog uploadPhoto=new OpenFileDialog();
            uploadPhoto.CheckFileExists = true;
            uploadPhoto.Filter= "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";
            if (uploadPhoto.ShowDialog() == DialogResult.OK)
            {
                await Dispatchers.RiseCommand(
                    new PhotoChanging(_bindingContext.Id.Value
                        , File.ReadAllBytes(uploadPhoto.FileName)
                        , uploadPhoto.FileName));
                await Bind(new ContactInfoModel(_contactInfoRepository.GetById(_bindingContext.Id.Value)));
            }
        }
    }
}
