namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Debug_Menu : PluginDynamicCommand
    {
        public Debug_Menu()
        : base(displayName: "Debug Menu", description: "Debug Menu", groupName: "Main Menu (Server)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Main Menu (Server).png")));
                bitmapBuilder.DrawText("Debug Menu", color: new BitmapColor(247,249,230));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyU, ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
