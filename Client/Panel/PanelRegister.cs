using System.Windows.Forms;

namespace Client.Panel
{
    public partial class PanelRegister : PanelSlider
    {
        public PanelRegister(Form owner) : base(owner)
        {
            InitializeComponent();
            StyleManager.Update();
        }
    }
}
