using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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
            //get data for article from UI textboxes and comboboxes
            Article article = new Article();
            article = createNewArticle(article);
            //communicate with API
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
                if (httpResponse.StatusCode.ToString() == "OK") MessageBox.Show("Saved");
                else MessageBox.Show("Please check input fields...");
            }
            //fetch the last article id by timestamp to show from database, in the sector that the company is in
            string apiUrl = "https://localhost:7172/api/Articles/" + comboBoxCompanySector.SelectedItem.ToString();
            HttpClient client = new HttpClient();
            HttpResponseMessage responseis = client.PostAsync(apiUrl,null).Result;
            //MessageBox.Show(responseis.Content.ReadAsStringAsync().Result);
           
        }
        private Article createNewArticle(Article article)
        {
           
            article.CompanyName = txtBoxCompanyName.Text;
            article.ArticleTitle = textBoxArticleTitle.Text;
            article.ArticleText = textBoxArticleText.Text;
            article.ArticlePunchLine = textBoxArticlePunchLine.Text;
            article.CompanyLink = textBoxCompanyLink.Text;
            article.AboutCompanyText = textBoxAboutCompanyText.Text;
            article.CompanySector = comboBoxCompanySector.SelectedItem.ToString(); ;
            article.ArticleTargetAudience = comboBoxTargetAudience.SelectedItem.ToString();
            FileStream fs;
            BinaryReader br;
            string FileName = textBoxImage.Text;
            byte[] ImageData;
            fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);
            article.ArticleImage = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            return article;
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
            public byte[] ArticleImage { get; set; }

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBoxImage.Text = openFileDialog1.FileName;
                    pictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
