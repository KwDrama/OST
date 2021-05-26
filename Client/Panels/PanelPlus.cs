using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Panels
{
    public partial class PanelPlus : PanelSlider
    {
        public PanelPlus(Form owner, SlidingType type) : base(owner, type)
        {
            InitializeComponent();
            Init();
        }
    }
}
