using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace Marquee
{
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class MarqueeBorderDesigner : ParentControlDesigner
    {

        public MarqueeBorderDesigner()
        {
            Trace.WriteLine("MarqueeBorderDesigner");
        }

        public bool Visible
        {
            get
            {
                return (bool)ShadowProperties["Visible"];
            }
            set
            {
                this.ShadowProperties["Visible"] = value;
            }
        }
        DesignerVerbCollection m_Verbs;

        public override DesignerVerbCollection Verbs
        {
            get
            {
                if (m_Verbs == null)
                {
                    // Create and initialize the collection of verbs
                    m_Verbs = new DesignerVerbCollection();

                    m_Verbs.Add(
                        new DesignerVerb("Run Test",
                            new EventHandler(OnVerbRunTest)));
                    m_Verbs.Add(
                        new DesignerVerb("Stop Test",
                            new EventHandler(OnVerbStopTest)));
                }
                return m_Verbs;
            }
        }
        public bool Enabled
        {
            get
            {
                return (bool)ShadowProperties["Enabled"];
            }
            set
            {
                this.ShadowProperties["Enabled"] = value;
            }
        }



        protected override void PreFilterProperties(IDictionary properties)
        {
            base.PreFilterProperties(properties);

            if (properties.Contains("Padding"))
            {
                properties.Remove("Padding");
            }

            properties["Visible"] = TypeDescriptor.CreateProperty(
                typeof(MarqueeBorderDesigner),
                (PropertyDescriptor)properties["Visible"],
                new Attribute[0]);

            properties["Enabled"] = TypeDescriptor.CreateProperty(
                typeof(MarqueeBorderDesigner),
                (PropertyDescriptor)properties["Enabled"],
                new Attribute[0]);
        }

        private void OnVerbRunTest(object sender, EventArgs e)
        {
            IMarqueeWidget widget = this.Control as IMarqueeWidget;

            widget.StartMarquee();
        }

        private void OnVerbStopTest(object sender, EventArgs e)
        {
            IMarqueeWidget widget = this.Control as IMarqueeWidget;

            widget.StopMarquee();
        }
    }
}
