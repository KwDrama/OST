using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FormTree : MetroFramework.Forms.MetroForm
    {
        FormChat formChat;

        public FormTree()
        {
            InitializeComponent();

            //this.Load += FormTree_Load;
        }

        public void FormTree_Load(object sender, EventArgs e)
        {
            SetTreeViewData();
        }

        public void SetTreeViewData()
        {
            tv_viewer.Nodes.Add("원인터내셔널");

            tv_viewer.Nodes[0].Nodes.Add("자원본부");
            tv_viewer.Nodes[0].Nodes[0].Nodes.Add("자원1팀");
            tv_viewer.Nodes[0].Nodes[0].Nodes.Add("자원2팀");
            tv_viewer.Nodes[0].Nodes[0].Nodes.Add("자원3팀");

            tv_viewer.Nodes[0].Nodes.Add("철강본부");
            tv_viewer.Nodes[0].Nodes[1].Nodes.Add("철강1팀");
            tv_viewer.Nodes[0].Nodes[1].Nodes.Add("철강2팀");
            tv_viewer.Nodes[0].Nodes[1].Nodes.Add("철강3팀");

            tv_viewer.Nodes[0].Nodes.Add("섬유본부");
            tv_viewer.Nodes[0].Nodes[2].Nodes.Add("섬유1팀");
            tv_viewer.Nodes[0].Nodes[2].Nodes.Add("섬유2팀");
            tv_viewer.Nodes[0].Nodes[2].Nodes.Add("섬유3팀");

            tv_viewer.Nodes[0].Nodes.Add("영업본부");
            tv_viewer.Nodes[0].Nodes[3].Nodes.Add("영업1팀");
            tv_viewer.Nodes[0].Nodes[3].Nodes.Add("영업2팀");
            tv_viewer.Nodes[0].Nodes[3].Nodes.Add("영업3팀");

            tv_viewer.ExpandAll();
        }

        private void tv_viewer_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //더블클릭 시 채팅방 이동(후에 내용이 있다면 저장된 내용 불러오기, 없다면 새 채팅방으로 구현)
            
            formChat = new FormChat();
            formChat.Location = new Point(500, 500);

            //각 노드 클릭 시 채팅방 이름 다른 것 구현

            formChat.Show();
        }

        private void pic_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
