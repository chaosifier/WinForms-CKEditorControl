using CKEditorBrowserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CkEditorControlSample
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var tabCtrl = new TabControl()
            {
                Dock = DockStyle.Fill
            };

            var curDir = Directory.GetCurrentDirectory();
            var ckEditorUri = new Uri(String.Format("file:///{0}/Resources/CkEditor/index.html", curDir));

            for (int i = 0; i < 8; i++)
            {
                var tabPg = new TabPage($"Tab {i}");
                var ckEditorCtrl = new CKEditorControl(ckEditorUri)
                {
                    Dock = DockStyle.Fill
                };

                tabPg.Controls.Add(ckEditorCtrl);

                int indx = i;
                ckEditorCtrl.DocumentCompleted+= (sss,ee)=> {
                    ckEditorCtrl.SetContent($"Tab {indx} Content");
                };

                tabCtrl.Controls.Add(tabPg);
            }

            Controls.Add(tabCtrl);
        }
    }
}
