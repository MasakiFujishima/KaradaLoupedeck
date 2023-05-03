namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Tools_Menu : PluginDynamicCommand
    {
        public Tools_Menu()
        : base(displayName: "Tools Menu", description: "Tools Menu", groupName: "Main Menu (Server)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Main Menu (Server).png")));
                bitmapBuilder.DrawText("Tools Menu", color: new BitmapColor(247,249,230));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyT, ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
