using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;

namespace MonopoliTests.Pages
{
    public class FormMap
    {

        public HtmlContainerControl NumberOfPlayers
        {
            get
            {
                //*[@id="PlayerName2_wrapper"]
                //*[@id="RadPageView4"]/table/tbody/tr[2]/td[2]
                Manager.Current.ActiveBrowser.RefreshDomTree();
                var element = Manager.Current.ActiveBrowser.Find.ByXPath<HtmlContainerControl>("//*[@id='RadPageView4']/table/tbody/tr[2]/td[2]");
                return element;
            }
        }

        public HtmlInputText BankBudget
        {
            get
            {
                Manager.Current.ActiveBrowser.RefreshDomTree();
                var element = Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("BankMoney");
                return element;
            }
        }

        public HtmlInputText PlayerBudget
        {
            get
            {
                Manager.Current.ActiveBrowser.RefreshDomTree();
                var element = Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("MoneyPerPlayer");
                return element;
            }
        }

        public HtmlInputText PlayersCount
        {
            get
            {
                var element = Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("PlayerCount");
                return element;
            }
        }

        public HtmlSpan Settings
        {
            get
            {
                var element = Manager.Current.ActiveBrowser.Find.ByXPath<HtmlSpan>("//*[@id='RadTabStrip1']/div/ul/li[2]/a/span/span/span");
                return element;
            }
        }
    }
}
