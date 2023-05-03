namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Session_Menu : PluginDynamicCommand
    {
        public Session_Menu()
        : base(displayName: "Session Menu", description: "Session Menu", groupName: "Main Menu (Server)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Main Menu (Server).png")));
                bitmapBuilder.DrawText("Session Menu", color: new BitmapColor(247,249,230));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyS, ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
