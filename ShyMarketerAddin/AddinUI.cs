using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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

        private void btnCallAPI_Click(object sender, EventArgs e)
        {

            Article article = new Article();
            article.CompanyName= txtBoxCompanyName.Text;
            article.ArticleTitle = textBoxArticleTitle.Text;
            article.ArticleText = textBoxArticleText.Text;
            article.ArticlePunchLine = textBoxArticlePunchLine.Text;
            article.CompanyLink = textBoxCompanyLink.Text;
            article.AboutCompanyText = textBoxAboutCompanyText.Text;
            article.CompanySector = comboBoxCompanySector.SelectedText;
            article.ArticleTargetAudience = comboBoxTargetAudience.SelectedItem.ToString();
            var jsonFormatedObj = Newtonsoft.Json.JsonConvert.SerializeObject(article);
            string url = String.Format("https://localhost:7172/api/Articles");
            WebRequest requestObjPost = WebRequest.Create(url);
            requestObjPost.Method = "POST";
            requestObjPost.ContentType = "application/json";
            using (var streamWriter = new StreamWriter(requestObjPost.GetRequestStream()))
            {
                streamWriter.Write(jsonFormatedObj);
                streamWriter.Flush();
                streamWriter.Close();
                var httpResponse = (HttpWebResponse)requestObjPost.GetResponse();
                MessageBox.Show(httpResponse.ToString());
            }
            MessageBox.Show("Saved");
        }
        public class Article
        {
            public int id { get; set; }
            public string CompanyName { get; set; }
            public string CompanySector { get; set; }
            public string AboutCompanyText { get; set; }
            public string CompanyLink { get; set; }
            public string ArticleTitle { get; set; }
            public string ArticlePunchLine { get; set; }
            public string ArticleText { get; set; }
            public string ArticleTargetAudience { get; set; }
            public string ArticleImage { get; set; }

        }
    }
}
