using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShyMarketerAddin
{
    public partial class ShyMarketer
    {
      
        private void AddinRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnStart_Click(object sender, RibbonControlEventArgs e)
        {

            
            var addIn = Globals.ThisAddIn;
            if (addIn.myCustomTaskPane != null) addIn.myCustomTaskPane.Dispose();
            addIn.addinUI = new AddinUI();
            addIn.myCustomTaskPane = addIn.CustomTaskPanes.Add(addIn.addinUI, "Shy Marketer ");
            addIn.myCustomTaskPane.Visible = true;
            addIn.myCustomTaskPane.Width = 1000;
        }
    }
}
