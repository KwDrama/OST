using System.Windows.Forms;

namespace Client.Panel
{
    public partial class PanelRegister : Panel
    {
        public PanelRegister(Form owner) : base(owner)
        {
            InitializeComponent();
            StyleManager.Update();
        }
    }
}
