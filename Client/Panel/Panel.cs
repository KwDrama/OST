using MetroFramework.Controls;
using System;
using System.Windows.Forms;
using Transitions;

namespace Client.Panel
{
    public partial class Panel : MetroUserControl
    {
        public event EventHandler shown;
        public event EventHandler closed;

        Panel()
        {
            InitializeComponent();

            Visible = false;

            BringToFront();
            ParentForm.Resize += parent_Resize;
        }

        protected virtual void Shown(EventArgs e)
        {
            if (shown != null)
                shown(this, e);
        }
        protected virtual void Closed(EventArgs e)
        {
            if (closed != null)
                closed(this, e);
        }
        void parent_Resize(object sender, EventArgs e)
        {

        }
        private void Panel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Swipe(false);
        }

        void Swipe(bool show = true)
        {
            Visible = true;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(1000));
            t.add(this, "Left", show ? 0 : Width);
            t.run();

            while (Left != (show ? 0 : Width))
                Application.DoEvents();

            if (!show)
            {
                Closed(new EventArgs());
                ParentForm.Resize -= parent_Resize;
                ParentForm.Controls.Remove(this);
            }
            
        }
    }
}
