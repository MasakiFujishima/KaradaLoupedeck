namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Code_Menu : PluginDynamicCommand
    {
        public Code_Menu()
        : base(displayName: "Code Menu", description: "Code Menu", groupName: "Main Menu (Server)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Main Menu (Server).png")));
                bitmapBuilder.DrawText("Code Menu", color: new BitmapColor(247,249,230));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyC, ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
