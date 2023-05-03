namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Show_Command_Palette : PluginDynamicCommand
    {
        public Show_Command_Palette()
        : base(displayName: "Show Command Palette", description: "Show Command Palette", groupName: "Help")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Help.png")));
                bitmapBuilder.DrawText("Show Command Palette", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyP, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
