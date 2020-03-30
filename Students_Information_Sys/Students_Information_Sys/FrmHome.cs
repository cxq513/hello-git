using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Students_Information_Sys
{
    public partial class FrmHome : DockContent
    {
        public FrmHome()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("shanmai.jpg");
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
