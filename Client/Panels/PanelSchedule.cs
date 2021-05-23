using System.Windows.Forms;

namespace Client.Panels
{
    public partial class PanelSchedule : PanelSlider
    {
        public PanelSchedule(Form owner, SlidingType type) : base(owner, type)
        {
            InitializeComponent();
            Init();
        }
    }
}