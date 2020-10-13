using System.Collections.Generic;
using TaleWorlds.CampaignSystem;
using TaleWorlds.SaveSystem;

namespace BanksOfCalradia
{
    [SaveableClass(101)]
    class BankManager
    {
        public BankManager()
        {
            this._book = new Dictionary<Town, int>();
        }

        public void Lend(Town town, int amount)
        {
            _book.Add(town, amount);
        }

        [SaveableField(0)]
        private Dictionary<Town, int> _book;
    }
}
