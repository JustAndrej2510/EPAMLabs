using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Threading;
using Avatrade.Pages;
[assembly: Parallelizable(ParallelScope.Fixtures)]

namespace Avatrade.Tests
{
    [TestFixture]
    public class DealPageTest : CommonConditions
    {

        [TestCase("BTCUSD", "Куплено"), Order(0)]
        public void CreateDealToBuyBTCUSDTest(string expectedDealName, string expectedDealDirection)
        {
            DealPage actualDeal = _startPage.SearchCurrencyInput(expectedDealName)
                .SelectCurrency()
                .CreateDeal()
                .SwitchToDealPage();
            string dealDirection = actualDeal.GetDealBuyDirection()[0].Text;
            string dealName = actualDeal.GetExistedDealNames()[0].Text;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedDealName, dealName);
                Assert.AreEqual(expectedDealDirection, dealDirection);
            });
        }

        [TestCase("BTCUSD", "Продано"), Order(1)]
        public void CreateDealToSellBTCUSDTest(string expectedDealName, string expectedDealDirection)
        {
            DealPage actualDeal = _startPage.SearchCurrencyInput(expectedDealName)
               .SelectCurrency()
               .SelectSellDeal()
               .CreateDeal()
               .SwitchToDealPage();
            string dealDirection = actualDeal.GetDealSellDirection()[0].Text;
            string dealName = actualDeal.GetExistedDealNames()[0].Text;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedDealName, dealName);
                Assert.AreEqual(expectedDealDirection, dealDirection);
            });
        }

        [Test, Order(2)]
        public void CloseLastCreatedDealTest()
        {
            DealPage dealPage = _startPage.SwitchToDealPage();
            int countDealsBeforeClose = dealPage.GetExistedDealNames().Count;
            dealPage.OpenCloseDealPanel()
                .CloseLastCreatedDeal();
            Thread.Sleep(1500);
            int countDealsAfterClose = dealPage.GetExistedDealNames().Count;

            Assert.That(countDealsAfterClose, Is.Not.EqualTo(countDealsBeforeClose));
        }

        

        [Test, Order(3)]
        public void AddStopLossForLastDealTest()
        {
            string stopLoss = _startPage.SwitchToDealPage()
                .OpenStopLossAndTakeProfitPanel()
                .AddStopLossAndTakeProfitToDeal()
                .GetStopLoss();
            Assert.That(stopLoss, Is.Not.Null);
        }

        [Test, Order(4)]
        public void AddTakeProfitForLastDealTest()
        {
            string takeProfit = _startPage.SwitchToDealPage()
                .OpenStopLossAndTakeProfitPanel()
                .AddStopLossAndTakeProfitToDeal()
                .GetTakeProfit();
            Assert.That(takeProfit, Is.Not.Null);
        }

        [Test, Order(5)]
        public void AggregateDealsTest()
        {
            bool isAggregated = _startPage.SwitchToDealPage()
                .AggregateDeals()
                .HasAggregatedDealsRow();

            Assert.That(isAggregated, Is.True);
        }

        //[TestCase("BTCUSD")]
        //public void CreateOrderToDealTest(string expectedDeal)
        //{
        //    string createdOrder = _startPage.SearchCurrencyInput(expectedDeal)
        //        .SelectCurrency()
        //        .CreateOrderForDeal()
        //        .CreateDeal()
        //        .SwitchToOrderPage()
        //        .GetListOfExistedOrders()[0].Text;

        //    Assert.That(createdOrder, Is.EqualTo(expectedDeal));
        //}

    }

    [TestFixture]
    public class ChatPageTest : CommonConditions
    {
        [Test]
        public void SendMessageToChatTest()
        {
            string actualSentMessage = _startPage.SwitchToChatPage()
                .InputChatMessage(_randomMessage)
                .SendChatMessage()
                .GetActualMessage();

            Assert.That(actualSentMessage, Is.EqualTo(_randomMessage));

        }
    }
}