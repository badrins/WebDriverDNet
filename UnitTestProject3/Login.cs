using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;

using OpenQA.Selenium.Support.PageObjects;

namespace CC
{
    public class Login
    {
        private OpenQA.Selenium.IWebDriver _driver;

        public Login(OpenQA.Selenium.IWebDriver driver)
        {
            this._driver = driver;
            OpenQA.Selenium.Support.PageObjects.PageFactory.InitElements(driver, this);
        }

        

       

        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = OpenQA.Selenium.Support.PageObjects.How.Id, Using = "txtAccountNo")]
        private OpenQA.Selenium.IWebElement tb_accountID;
        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = OpenQA.Selenium.Support.PageObjects.How.Id, Using = "txtUserName")]
        private OpenQA.Selenium.IWebElement tb_userID;
        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = OpenQA.Selenium.Support.PageObjects.How.Id, Using = "txtLoginPassword")]
        private OpenQA.Selenium.IWebElement tb_password;
        [OpenQA.Selenium.Support.PageObjects.FindsBy(How = OpenQA.Selenium.Support.PageObjects.How.Id, Using = "ibtnLogin")]
        private OpenQA.Selenium.IWebElement btn_login;
        private OpenQA.Selenium.IWebDriver ff;

        public OpenQA.Selenium.IWebElement get_accountID()
        {
            return this.tb_accountID;
        }

        public void set_accountID(OpenQA.Selenium.IWebElement ele)
        {
            this.tb_accountID = ele;
        }

        public OpenQA.Selenium.IWebElement get_userID()
        {
            return this.tb_userID;
        }

        public void set_userID(OpenQA.Selenium.IWebElement ele)
        {
            this.tb_userID = ele;
        }

        public OpenQA.Selenium.IWebElement get_password()
        {
            return this.tb_password;
        }

        public void set_password(OpenQA.Selenium.IWebElement ele)
        {
            this.tb_password = ele;
        }

        public OpenQA.Selenium.IWebElement get_login()
        {
            return this.btn_login;
        }

        public void set_login(OpenQA.Selenium.IWebElement ele)
        {
            this.btn_login = ele;
        }

        public void loginPage(String username, String password)
        {
            get_userID().SendKeys(username);
            get_password().SendKeys(password);
            get_login().Click();
        }


    }
}
