using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace ShyMarketerAddin
{
    public partial class AddinUI : UserControl
    {
        public bool explorerCheck { get; set; } = true;
        public AddinUI()
        {
            InitializeComponent();
            var addIn = Globals.ThisAddIn;
            addIn.currentExplorer = addIn.Application.ActiveExplorer();
            addIn.currentExplorer.SelectionChange += new Microsoft.Office.Interop.Outlook
                .ExplorerEvents_10_SelectionChangeEventHandler
                (CurrentExplorer_Event);
        }
        private void CurrentExplorer_Event()
        {
            var addIn = Globals.ThisAddIn;
            if (explorerCheck == false)
            {
                explorerCheck = true;
                return;
            }
            explorerCheck = false;
            addIn.myCustomTaskPane.Dispose();
            

        }

        
    }
}
