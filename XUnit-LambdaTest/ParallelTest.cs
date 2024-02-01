using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace XUnit_LambdaTest
{
    public abstract class ParallelBaseTest
    {
        private readonly BaseFixture baseFixture;

        public ParallelBaseTest(BaseFixture baseFixture)
        {
            this.baseFixture = baseFixture;
        }

        public void BaseTest(string platform)
        {
            try
            {
                RemoteWebDriver driver = baseFixture.GetDriver(platform, "parallel");
                WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(2000));
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://lambdatest.github.io/sample-todo-app/");


                 Assert.Equal("Sample page - lambdatest.com", driver.Title);
                // Click on First Check box
                IWebElement firstCheckBox = driver.FindElement(By.Name("li1"));
                firstCheckBox.Click();

                // Click on Second Check box
                IWebElement secondCheckBox = driver.FindElement(By.Name("li2"));
                secondCheckBox.Click();

                // Enter Item name
                IWebElement textfield = driver.FindElement(By.Id("sampletodotext"));

                String itemName = "Yey, Let's add it to list";
                textfield.SendKeys(itemName);

                // Click on Add button
                IWebElement addButton = driver.FindElement(By.Id("addbutton"));
                addButton.Click();

                // Verified Added Item name
                IWebElement itemtext = driver.FindElement(By.XPath("/html/body/div/div/div/ul/li[6]/span"));
                String getText = itemtext.Text;
                Assert.True(itemName.Contains(getText));

                /* Perform wait to check the output */
                System.Threading.Thread.Sleep(2000);

                Console.WriteLine("LT_ToDo_Test Passed");
                baseFixture.SetStatus(true);
            }
            catch (Exception)
            {
                baseFixture.SetStatus(false);
                throw;
            }
        }
    }

    public class ChromeTest : ParallelBaseTest, IClassFixture<BaseFixture>
    {
        public ChromeTest(BaseFixture baseFixture) : base(baseFixture) { }

        [Fact]
        [Trait("profile", "parallel")]
        public void Test()
        {
            BaseTest("chrome");
        }
    }

    public class FirefoxTest : ParallelBaseTest, IClassFixture<BaseFixture>
    {
        public FirefoxTest(BaseFixture baseFixture) : base(baseFixture) { }

        [Fact]
        [Trait("profile", "parallel")]
        public void Test()
        {
            BaseTest("firefox");
        }
    }

    public class SafariTest : ParallelBaseTest, IClassFixture<BaseFixture>
    {
        public SafariTest(BaseFixture baseFixture) : base(baseFixture) { }

        [Fact]
        [Trait("profile", "parallel")]
        public void Test()
        {
            BaseTest("safari");
        }
    }

}
