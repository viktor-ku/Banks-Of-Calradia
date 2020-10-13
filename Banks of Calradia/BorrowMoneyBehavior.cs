using Bannerlord.ButterLib.SaveSystem.Extensions;
using System;
using TaleWorlds.CampaignSystem;

namespace BanksOfCalradia
{
    class BorrowMoneyBehavior : CampaignBehaviorBase
    {
        private BankManager _bankManager;

        public BorrowMoneyBehavior()
        {
            _bankManager = new BankManager();
        }

        public override void RegisterEvents()
        {
            CampaignEvents.DailyTickTownEvent.AddNonSerializedListener(this, new Action<Town>(DailyTickTown));
        }

        public override void SyncData(IDataStore store)
        {
            store.SyncDataAsJson("_bankManager", ref _bankManager);
        }

        public int Threshold = 20_000;
        public int Amount = 1_000;

        void DailyTickTown(Town town)
        {
            if (ShouldBorrowMoney(town))
            {
                town.ChangeGold(Amount);
                _bankManager.Lend(town, Amount);
                Message.Olive($"{town.Name} borrowed {Amount} denars");
            }
        }

        bool ShouldBorrowMoney(Town town)
        {
            return town.Gold < Threshold;
        }
    }
}
