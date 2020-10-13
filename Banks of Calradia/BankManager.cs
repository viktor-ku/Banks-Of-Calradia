using HarmonyLib;
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

        public int Total(Town town)
        {
            int total = 0;
            _book.TryGetValue(town, out total);
            return total;
        }

        public void Lend(Town town, int amount)
        {
            if (_book.ContainsKey(town))
            {
                _book[town] += amount;
            }
            else
            {
                _book.Add(town, amount);
            }
        }

        [SaveableField(0)]
        private Dictionary<Town, int> _book;
    }
}
