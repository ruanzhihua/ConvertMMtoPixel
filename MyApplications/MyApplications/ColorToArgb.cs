using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplications
{
    public partial class ColorToArgb : MyControls.ContainerControls.UserBaseControl
    {
        public ColorToArgb()
        {
            InitializeComponent();
        }
        private void ControlInit()
        {
            this.panel2.Controls.Clear();
            int i = 1;

            foreach (var item in typeof(Color).GetMembers())
            {
                if (item.MemberType == System.Reflection.MemberTypes.Property && System.Drawing.Color.FromName(item.Name).IsKnownColor == true)//只取属性且为属性中的已知Color，剔除byte属性以及一些布尔属性等（A B G R IsKnownColor Name等）
                {
                    Label myLable = new Label();
                    myLable.AutoSize = true;
                    myLable.Location = new Point(15,i*20);
                    myLable.BackColor = System.Drawing.Color.FromName(item.Name);
                    myLable.Text = System.Drawing.Color.FromName(item.Name).Name+ System.Drawing.Color.FromName(item.Name).ToArgb().ToString();
                    panel2.Controls.Add(myLable);
                    //newPanel.GetFlowBreak(myLable);

                    i++;
                }
            }
        }

        private void ColorToArgb_Load(object sender, EventArgs e)
        {
            ControlInit();
        }
    }
}
