//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace _Banker
//{
//    public class WebScraper
//    {

//        //public IWebDriver driver;

//        //------>>>> ***************************** https://en.wikipedia.org/wiki/List_of_supermarket_chains_in_the_United_States
//        //---> collect all of the store names on this page ^ and store the output in a .txt then comment this code out again


//        public void Open_Browser()
//        {
//            var driver = new ChromeDriver("C:\\Users\\NEO\\source\\repos\\_Banker\\_Banker");
//            var service = ChromeDriverService.CreateDefaultService("C:\\Users\\NEO\\source\\repos\\_Banker\\_Banker", "chromedriver.exe");
//            //service.HideCommandPromptWindow = true;


//            try
//            {
//                driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/List_of_department_stores_of_the_United_States");
//            }
//            catch
//            {
//                throw;
//            }
//            Find_Data(driver);
//        }

//        public List<string> Find_Data(ChromeDriver driver)
//        {
//            List<string> stationNames = new List<string>();
//            IList<IWebElement> searchElements = driver.FindElements(By.ClassName(".mw-parser-output"));
//            IList<IWebElement> listItems = driver.FindElements(By.XPath(".//li"));

//            foreach (IWebElement x in listItems)
//            {
//                Console.WriteLine(x.Text);
//            }


//            //# mw-content-text > div > ul:nth-child(4)
//            //IList<IWebElement> searchElements = driver.FindElements(By.TagName("li"));

//            foreach (IWebElement i in searchElements)
//            {
//                string iText = i.Text;
//                Console.WriteLine(iText);

//                //THIS CODE WILL:
//                /*
//                Open Chrome
//                Go to website
//                Select the elements listed in line 38
//                Take the text from each element of that type

//            This code will allow you to scrape at least Wikipedia - it is unfinished because I realized I didn't need it.
//            I got far enough for the code to tell me what was in the iText string, which is the list I needed
//                so I just added it to a .txt file in the solution rather than querying the website every time this runs



//                */



//            }
//            return stationNames;
//        }
//    }

//}







///*
// * http://softvernow.com/2018/09/28/how-to-web-scraping-using-c/
// * https://saucelabs.com/resources/articles/getting-started-with-webdriver-in-c-using-visual-studio
//    public partial class Form1 : Form
//    {
//        public IWebDriver driver;
//        public Form1()
//        {
//            InitializeComponent();
//        }
//        private void Form1_Load(object sender, EventArgs e)
//        {
//        }
//        public void Open_Browser()
//        {

//            var driverService = ChromeDriverService.CreateDefaultService();
//            driverService.HideCommandPromptWindow = true;
//            //var options = new ChromeOptions();
//            //options.AddArgument("headless");
//            driver = new ChromeDriver(driverService);
//            try
//            {
//                driver.Navigate().GoToUrl("https://money.cnn.com/data/hotstocks/index.html");
//            }
//            catch
//            {
//                throw;
//            }

//        }
//        private void BtnOpen_Click(object sender, EventArgs e)
//        {
//            Open_Browser();
//        }
//        private void Find_Data()
//        {
//            IList<IWebElement> searchElements = driver.FindElements(By.TagName("tbody"));
//            foreach (IWebElement i in searchElements)
//            {
//                HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
//                var text = i.GetAttribute("innerHTML");
//                htmlDocument.LoadHtml(text);
//                var inputs = htmlDocument.DocumentNode.Descendants("tr").ToList();
//                foreach (var items in inputs)
//                {
//                    HtmlAgilityPack.HtmlDocument htmlDocument1 = new HtmlAgilityPack.HtmlDocument();
//                    htmlDocument1.LoadHtml(items.InnerHtml);
//                    var tds = htmlDocument1.DocumentNode.Descendants("td").ToList();
//                    if(tds.Count != 0)
//                        txtResults.AppendText(tds[0].InnerText + " " + tds[1].InnerText +" " + tds[2].InnerText + " " + tds[3].InnerText + "\t\r");
//                }
//                txtResults.AppendText("\t\r");
//            }
//        }
//        private void btnExit_Click(object sender, EventArgs e)
//        {
//            if(driver!= null)
//                driver.Quit();
//        }
//        private void btnScrap_Click(object sender, EventArgs e)
//        {
//            Find_Data();
//        }
//    }

////    -----------------------------------------------

////    /////////---->>>      line Find_Data() backups
////                    //HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
////                //var text = i.GetAttribute("innerHTML");
////                //htmlDocument.LoadHtml(text);
////                //var inputs = htmlDocument.DocumentNode.Descendants("li").ToList();
////                //foreach (var items in inputs)
////                //{
////                //    HtmlAgilityPack.HtmlDocument htmlDocument1 = new HtmlAgilityPack.HtmlDocument();
////                //    htmlDocument1.LoadHtml(items.InnerHtml);
////                //    var tds = htmlDocument1.DocumentNode.Descendants("td").ToList();



////                //The below is probably not needed
////                    //if (tds.Count != 0)
////                        //txtResults.AppendText(tds[0].InnerText + " " + tds[1].InnerText + " " + tds[2].InnerText + " " + tds[3].InnerText + "\t\r");



////    */
