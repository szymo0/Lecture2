using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lecture2.Infrastucture;
using Lecture2.Models;

namespace Lecture2
{
    public partial class ContactPreview : Form, IBindable<ContactInfoModel>
    {
        private ContactInfoModel _bindingContext;
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
    }
}
