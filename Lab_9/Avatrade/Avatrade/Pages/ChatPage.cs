using Avatrade.Pages.Base;
using Avatrade.Utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avatrade.Pages
{
    class ChatPage : PageBase
    {
        private By inputChatFieldLocator = By.CssSelector(".sc-bsatvv");
        private By sendChatMessageBtnLocator = By.CssSelector(".sc-gIvpjk path");
        private By sentMessageLocator = By.XPath("//div[@class='sc-kmIPcE eYvuNF']");
        private By chatFrameLocator = By.XPath("//*[@id='ada-chat-frame']");
        public ChatPage(IWebDriver _driver) : base(_driver) { }

        public ChatPage InputChatMessage(string message)
        {
            SwitchToFrame(chatFrameLocator);
            IWebElement inputField = FindElementWithWaitElementIsVisible(inputChatFieldLocator, 10);
            inputField.Click();
            inputField.SendKeys(message);

            Logger.WriteToLog($"Message {message} was written to the chat input field");
            return this;
        }

        public ChatPage SendChatMessage()
        {
            IWebElement sendMessageBtn = FindElementWithWaitElementIsVisible(sendChatMessageBtnLocator, 10);
            sendMessageBtn.Click();

            Logger.WriteToLog($"Message was sent to the chat");
            return this;
        }

        public string GetActualMessage()
        {
            IWebElement sentMessage = FindElementWithWaitElementIsVisible(sentMessageLocator, 10);

            Logger.WriteToLog($"Message was recieved from the chat");
            return sentMessage.Text;
        }
    }
}
