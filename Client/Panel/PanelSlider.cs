using MetroFramework.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using Transitions;

namespace Client.Panel
{
    public enum SlidingType
    {
        Left, Right
    }
    public partial class PanelSlider : MetroUserControl
    {
        public SlidingType type;
        public event EventHandler Shown;
        public event EventHandler Closed;
        public Form owner;
        public bool loaded;

        int endY = 0;

        public PanelSlider()
        {
            InitializeComponent();
        }
        public PanelSlider(Form owner, SlidingType type) : this()
        {
            this.type = type;
            this.owner = owner;

            Visible = false;
            owner.Controls.Add(this);
            owner.Resize += ownerResize;
            owner.Click += (sender, e) => Swipe(false);

            Left = endY = type == SlidingType.Left ? owner.Width : -Width;
            BringToFront();
        }

        void ownerResize(object sender, EventArgs e)
        {
            Left = loaded ? 0 : endY;
        }

        public void Swipe(bool show = true)
        {
            Visible = true;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(400));
            t.add(this, "Left", show ? 0 : endY);
            t.run();

            while (Left != (show ? 0 : endY))
                Application.DoEvents();

            if (show)
            {
                loaded = true;
                ownerResize(null, null);

                if (Shown != null)
                    Shown(this, new EventArgs());
            }
            else
            {
                if (Closed != null)
                    Closed(this, new EventArgs());

                owner.Resize -= ownerResize;
                owner.Controls.Remove(this);
                Dispose();
            }
        }
    }
}
