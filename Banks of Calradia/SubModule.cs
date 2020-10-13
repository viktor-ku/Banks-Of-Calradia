using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BanksOfCalradia
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnGameStart(Game game, IGameStarter gameStarter)
        {
            base.OnGameStart(game, gameStarter);

            CampaignGameStarter campaignStarter = (CampaignGameStarter)gameStarter;
            campaignStarter.AddBehavior(new BorrowMoneyBehavior());
        }
    }
}
