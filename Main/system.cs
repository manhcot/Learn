using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Drawing;
using System.Text;
using System.Threading;


namespace Tools
{
    internal class system
    {
        //  04/02/2022
        //  update
        //  04/02/2022
        public system(int if1, string tk, string mk, string Did, int Rid,int xpts)
        {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            var driver = new ChromeDriver(driverService, new ChromeOptions());

            driver.Manage().Window.Size = new Size(220, 480);
            driver.Manage().Window.Position = new Point(xpts-20, xpts-25);
            driver.Navigate().GoToUrl("https://www.facebook.com/");

            driver.FindElement(By.Id("email")).SendKeys(tk);
            driver.FindElement(By.Id("pass")).SendKeys(mk + Keys.Return);
            string llink = $"https://mbasic.facebook.com/ixt/trigger/nfx/msite/?trigger%5Btrigger_event_type%5D=nfx_action_executed&trigger%5Bnfx_context%5D=%7B%22session_id%22%3A%2239d7f8a4-fdbf-4d05-ac44-3e68f705a86b%22%2C%22type%22%3A2%2C%22initial_action_name%22%3A%22RESOLVE_PROBLEM%22%2C%22story_location%22%3A%22profile_someone_else%22%2C%22entry_point%22%3A%22profile_report_button%22%2C%22actions_taken%22%3A%22RESOLVE_PROBLEM%22%2C%22reportable_ent_token%22%3A%22{Did}%22%7D&trigger%5Btrigger_session_id%5D=caeae43f-55f7-449a-b017-308293ee4dd1&_rdr";
            try
            {
                switch (if1)
                {
                    case 1:// auto-surf
                        Actions action = new Actions(driver);
                        action.SendKeys(Keys.Escape);
                        while (true)
                        {
                            Random rnd = new Random();
                            int num = rnd.Next(4500);
                            action.SendKeys(Keys.Down).Perform();
                            Thread.Sleep(num);
                        }

                    case 2:// repost nick fb -- update ( lười quá nên mai làm ) :3
                        switch (Rid)
                        {
                            ///html/body/div/div/div/div/table/tbody/tr/td/form/section/fieldset/label[1]/div/table/tbody/tr/td[1]/input
                            case 1:
                                Console.WriteLine("1");
                                break;
                            case 2:
                                Console.WriteLine("2");
                                break;
                            case 3:
                                Console.WriteLine("3");
                                break;
                            case 4:
                                Console.WriteLine("4");
                                break;
                            case 5:
                                Console.WriteLine("5");
                                break;
                            case 6:
                                Console.WriteLine("6");
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

            }
        }

    }
}
