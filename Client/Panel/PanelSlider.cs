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

        int visibleX = 0, invisibleX = 0;

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
            BringToFront();
        }
        protected void Init()
        {
            visibleX = type == SlidingType.Left ? owner.Width - Width - 1 : 1;
            Left = invisibleX = type == SlidingType.Left ? owner.Width : -Width;
        }

        void ownerResize(object sender, EventArgs e)
        {
            Left = loaded ? visibleX : invisibleX;
        }

        public void Swipe(bool show = true)
        {
            Visible = true;

            Transition.run(this, "Left", show ? visibleX : invisibleX, new TransitionType_EaseInEaseOut(400));

            while (Left != (show ? visibleX : invisibleX))
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

        public void EnterShadow(object sender, EventArgs e)
        {
            Control c = sender as Control;
            c.BackColor = Color.FromArgb(238, 238, 238);
        }
        public void LeaveShadow(object sender, EventArgs e)
        {
            Control c = sender as Control;
            c.BackColor = Color.Transparent;
        }
    }
}
