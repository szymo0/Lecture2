using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Marquee
{
    [ToolboxItemFilter("MarqueeBorder", ToolboxItemFilterType.Require)]
    [ToolboxItemFilter("MarqueeText", ToolboxItemFilterType.Require)]
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
    public class MarqueeControlRootDesigner : DocumentDesigner
    {

        public MarqueeControlRootDesigner()
        {
            Trace.WriteLine("MarqueeControlRootDesigner ctor");
        }

        public override void Initialize(IComponent component)
        {
            base.Initialize(component);

            IComponentChangeService cs =
                GetService(typeof(IComponentChangeService))
                    as IComponentChangeService;

            if (cs != null)
            {
                cs.ComponentChanged +=
                    new ComponentChangedEventHandler(OnComponentChanged);
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
        private void OnComponentChanged(
            object sender,
            ComponentChangedEventArgs e)
        {
            if (e.Component is IMarqueeWidget)
            {
                this.Control.Refresh();
            }
        }

        public override bool CanBeParentedTo(IDesigner parentDesigner)
        {
            return base.CanBeParentedTo(parentDesigner);
        }

        public override bool CanParent(ControlDesigner controlDesigner)
        {
            return base.CanParent(controlDesigner);
        }

        public override bool CanParent(Control control)
        {
            return base.CanParent(control);
        }

        private void OnVerbRunTest(object sender, EventArgs e)
        {
            MarqueeControl c = this.Control as MarqueeControl;

            c.Start();
        }

        private void OnVerbStopTest(object sender, EventArgs e)
        {
            MarqueeControl c = this.Control as MarqueeControl;

            c.Stop();
        }

    }
}
