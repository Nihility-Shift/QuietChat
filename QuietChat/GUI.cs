using VoidManager.CustomGUI;
using VoidManager.Utilities;

namespace QuietChat
{
    internal class GUI : ModSettingsMenu
    {
        public override string Name() => MyPluginInfo.USERS_PLUGIN_NAME;

        public override void Draw()
        {
            bool quiet = Configs.TemporaryChatConfig.Value;
            if (GUITools.DrawCheckbox("Temporary game messages", ref quiet))
            {
                Configs.TemporaryChatConfig.Value = quiet;
            }
            bool disable = !Configs.TemporaryChatConfig.Value;
            if (GUITools.DrawCheckbox("No game messages", ref disable))
            {
                Configs.TemporaryChatConfig.Value = !disable;
            }
        }
    }
}
