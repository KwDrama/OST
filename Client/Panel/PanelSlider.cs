using MetroFramework.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using Transitions;

namespace Client.Panel
{
    public partial class PanelSlider : MetroUserControl
    {
        public event EventHandler Shown;
        public event EventHandler Closed;
        public Form Owner;
        public bool loaded;

        public PanelSlider()
        {
            InitializeComponent();
        }
        public PanelSlider(Form owner) : this()
        {
            Visible = false;
            Owner = owner;
            Owner.Controls.Add(this);
            Owner.Resize += parent_Resize;
            Owner.Click += (sender, e) => Swipe(false);
            BringToFront();
        }

        protected virtual void handleShown(EventArgs e)
        {
            if (Shown != null)
                Shown(this, e);
        }
        protected virtual void handleClosed(EventArgs e)
        {
            if (Closed != null)
                Closed(this, e);
        }
        void parent_Resize(object sender, EventArgs e)
        {
            Width = Owner.Width;
            Height = Owner.Height;
            Location = new Point(loaded ? 0 : Owner.Width, 0);
        }
        private void Panel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Swipe(false);
        }

        public void Swipe(bool show = true)
        {
            Visible = true;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(400));
            t.add(this, "Left", show ? 0 : Width);
            t.run();

            while (Left != (show ? 0 : Width))
                Application.DoEvents();

            if (show)
            {
                loaded = true;
                parent_Resize(null, null);
                handleShown(new EventArgs());
            }
            else
            {
                handleClosed(new EventArgs());
                Owner.Resize -= parent_Resize;
                Owner.Controls.Remove(this);
                Dispose();
            }
        }
    }
}
