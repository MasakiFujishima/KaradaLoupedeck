namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Help_Menu : PluginDynamicCommand
    {
        public Help_Menu()
        : base(displayName: "Help Menu", description: "Help Menu", groupName: "Main Menu (Server)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Main Menu (Server).png")));
                bitmapBuilder.DrawText("Help Menu", color: new BitmapColor(247,249,230));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyH, ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
