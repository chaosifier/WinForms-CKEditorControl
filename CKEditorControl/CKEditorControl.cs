using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CKEditorBrowserControls
{
    [ComVisible(true)]
    public partial class CKEditorControl : WebBrowser
    {
        private Uri _ckEditorIndexPath;
        public CKEditorControl(Uri ckEditorIndexPath)
        {
            _ckEditorIndexPath = ckEditorIndexPath;

            Url = ckEditorIndexPath;
            ScriptErrorsSuppressed = true;
            IsWebBrowserContextMenuEnabled = false;
            AllowWebBrowserDrop = false;
            ObjectForScripting = this;
            WebBrowserShortcutsEnabled = false;
        }

        public void SetContent(string content)
        {
            Document.InvokeScript("setContent",
               new String[] { content });
        }

        public string GetContent()
        {
            return Document.InvokeScript("getContent").ToString();
        }
    }
}