using Bannerlord.ButterLib;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem;

namespace BanksOfCalradia
{
    class MySaveableTypeDefiner : ButterLibSaveableTypeDefiner
    {
        public MySaveableTypeDefiner() : base(101001) { }

        protected override void DefineClassTypes()
        {
            base.AddClassDefinition(typeof(BankManager), 101);
        }

        protected override void DefineContainerDefinitions()
        {
            base.ConstructContainerDefinition(typeof(Dictionary<Town, int>));
        }
    }
}
