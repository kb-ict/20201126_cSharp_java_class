using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var driver = new ChromeDriver())
            {
                int count = 1;
                string allPostUrl = $"https://cafe.naver.com/deadbydaylight?iframe_url=/ArticleList.nhn?search.clubid=28631521&search.boardtype=L&search.totalCount=151&search.page={count}";
                string dbdUrl = @"https://cafe.naver.com/deadbydaylight";
                driver.Url = allPostUrl;
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(2000);

                //*[@id="menuLink10"]
                //var tag = driver.FindElementsByXPath("//*[@id=\"menuLink10\"]");
                //*[@id="cafe-data"]/div[1]/div[1]/div/table/tbody/tr[3]/td[1]/div[2]/div/a/span
                //*[@id="cafe-data"]/div[1]/div[1]/div/table/tbody/tr[4]/td[1]/div[2]/div/a/span
                // board-notice type_main               
                try
                {
                    driver.SwitchTo().Frame("cafe_main");
                    //var tags = driver.FindElementsByXPath("//*[@id='cafe-data']/div[1]/div[1]/div/table/tbody/tr[not(self::tr[@class='board-notice type_main'])]/td[1]/div[2]/div/a/span");
                    //*[@id="main-area"]/div[4]/table/tbody/tr[1]/td[1]/div[2]/div/a
                    //*[@id="main-area"]/div[4]/table/tbody/tr[2]/td[1]/div[2]/div/a
                    //var tags = driver.FindElementsByXPath("//*[@id='cafe-data']/div[1]/div[1]/div/table/tbody/tr[not(@class='board-notice type_main')]/td[1]/div[2]/div/a/span");
                    var tags = driver.FindElementsByXPath("//*[@id='main-area']/div[4]/table/tbody/tr/td[1]/div[2]/div/a[1]");
                    Console.WriteLine("----------------------");
                    for (int i = 0; i < tags.Count; i++)
                    {
                        Console.WriteLine(tags[i].Text);
                    }
                }
                catch (Exception)
                {

                }

                //tag[0].Click();

                Console.ReadKey();
            }

        }
    }
}
