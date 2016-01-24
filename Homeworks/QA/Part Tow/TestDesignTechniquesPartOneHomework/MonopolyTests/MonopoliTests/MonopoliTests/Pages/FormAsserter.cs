namespace MonopoliTests.Pages
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class FormAsserter
    {
        public void AssertNumberOfFields(NewGameFormPage page, int players)
        {
            //I am looking for how many input fields are displayed, 
            //but there is two more ChieldNodes in <td> 
            //spans for validation result, validator name and <br>
            //This is the reason for players + 2
            if (players < 2)
            {
                Assert.AreEqual(5, page.Map.NumberOfPlayers.ChildNodes.Count);
            }
            else if (players > 6)
            {
                Assert.AreEqual(9, page.Map.NumberOfPlayers.ChildNodes.Count);
            }
            else
            {
                Assert.AreEqual(players + 3, page.Map.NumberOfPlayers.ChildNodes.Count);
            }
        }

        internal void AssertPlayerBudget(NewGameFormPage page, int budget)
        {
            var expected = budget.ToString() + ",00 лв.";
            var actual = page.Map.PlayerBudget.Value.ToString();
            if (budget <= 1200)
            {
                Assert.AreEqual("1 200,00 лв.", actual);
            }
            else if (budget >= 1500)
            {
                Assert.AreEqual("1 500,00 лв.", actual);
            }
            else
            {
                actual = actual.Remove(1, 1);
                Assert.AreEqual(expected, actual);
            }
        }

        //Like you see tests for budgets are made with defaul number of players,
        //Thats the reason to just multiply player budget for  this assert
        // I know that here is code duplicate but after 3 hours with fuckin space in "1 200,00 лв." i dont care!!!!!
        internal void AssertBankBudget(NewGameFormPage page, int budget)
        {
            var bankBudget = 12000 - budget * 2;
            var expected = bankBudget.ToString() + ",00 лв.";
            if (budget <= 1200)
            {
                Assert.AreEqual("9 600,00 лв.", page.Map.BankBudget.Value.ToString());
            }
            else if (budget >= 1500)
            {
                Assert.AreEqual("9 000,00 лв.", page.Map.BankBudget.Value.ToString());
            }
            else
            {
                var actual = page.Map.BankBudget.Value.ToString();
                actual = actual.Remove(1, 1);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
