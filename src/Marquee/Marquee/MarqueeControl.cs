using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace Marquee
{
    [Designer(typeof(Marquee.MarqueeControlRootDesigner), typeof(IRootDesigner))]
    [ToolboxItemFilter("MarqueeText")]
    public class MarqueeControl : UserControl
    {

        // Required designer variable. 
        private System.ComponentModel.Container components = null;

        public MarqueeControl()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            // Minimize flickering during animation by enabling  
            // double buffering.
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        /// <summary>  
        /// Clean up any resources being used. 
        /// </summary> 
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        public void Start()
        {
            // The MarqueeControl may contain any number of  
            // controls that implement IMarqueeWidget, so  
            // find each IMarqueeWidget child and call its 
            // StartMarquee method. 
            foreach (Control cntrl in this.Controls)
            {
                if (cntrl is IMarqueeWidget)
                {
                    IMarqueeWidget widget = cntrl as IMarqueeWidget;
                    widget.StartMarquee();
                }
            }
        }

        public void Stop()
        {
            // The MarqueeControl may contain any number of  
            // controls that implement IMarqueeWidget, so find 
            // each IMarqueeWidget child and call its StopMarquee 
            // method. 
            foreach (Control cntrl in this.Controls)
            {
                if (cntrl is IMarqueeWidget)
                {
                    IMarqueeWidget widget = cntrl as IMarqueeWidget;
                    widget.StopMarquee();
                }
            }
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);

            // Repaint all IMarqueeWidget children if the layout  
            // has changed. 
            foreach (Control cntrl in this.Controls)
            {
                if (cntrl is IMarqueeWidget)
                {
                    Control control = cntrl as Control;

                    control.PerformLayout();
                }
            }
        }

        #region Component Designer generated code
        /// <summary>  
        /// Required method for Designer support - do not modify  
        /// the contents of this method with the code editor. 
        /// </summary> 
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
        }
        #endregion
    }
}
