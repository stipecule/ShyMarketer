namespace ShyMarketerAddin
{
    partial class ShyMarketer : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public ShyMarketer()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnStart = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.ControlId.OfficeId = "TabMail";
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabMail";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnStart);
            this.group1.Label = "ShyMarketer";
            this.group1.Name = "group1";
            // 
            // btnStart
            // 
            this.btnStart.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnStart.Label = "Start";
            this.btnStart.Name = "btnStart";
            this.btnStart.ShowImage = true;
            this.btnStart.SuperTip = "Start ShyMarketer add-in";
            this.btnStart.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnStart_Click);
            // 
            // ShyMarketer
            // 
            this.Name = "ShyMarketer";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.AddinRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        public Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        public Microsoft.Office.Tools.Ribbon.RibbonButton btnStart;
    }

    partial class ThisRibbonCollection
    {
        internal ShyMarketer AddinRibbon
        {
            get { return this.GetRibbon<ShyMarketer>(); }
        }
    }
}
