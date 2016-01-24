using System;
using ArtOfTest.WebAii.Core;
using System.Windows.Forms;
using System.Threading;

namespace MonopoliTests.Pages
{
    public class NewGameFormPage
    {
        private FormMap map;
        private FormAsserter asserter;

        public NewGameFormPage()
        {
            this.map = new FormMap();
            this.asserter = new FormAsserter();
        }

        public Browser Browser
        {
            get
            {
                return Manager.Current.ActiveBrowser;
            }
        }

        public FormMap Map
        {
            get
            {
                return this.map;
            }
        }

        public FormAsserter Assrter
        {
            get
            {
                return this.asserter;
            }
        }

        private void Navigate()
        {
            this.Browser.NavigateTo(@"http://localhost:49573/Default.aspx");
            this.Map.Settings.MouseClick();
        }

        internal void SetPlayers(int players)
        {
            this.Navigate();
            this.Map.PlayersCount.MouseClick();
            this.Map.PlayersCount.Text = players.ToString();
            Manager.Current.ActiveBrowser.Desktop.KeyBoard.KeyPress(Keys.Enter);
        }

        internal void SetBudget(decimal budgetPerPlayer)
        {
            this.Navigate();
            this.Map.PlayerBudget.MouseClick();
            this.Map.PlayerBudget.Text = budgetPerPlayer.ToString();
            Manager.Current.ActiveBrowser.Desktop.KeyBoard.KeyPress(Keys.Enter);
            Manager.Current.ActiveBrowser.WaitForAjax(20000);
        }
    }
}

