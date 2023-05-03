namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Move_Focus_to_Terminal : PluginDynamicCommand
    {
        public Move_Focus_to_Terminal()
        : base(displayName: "Move Focus to Terminal", description: "Move Focus to Terminal", groupName: "Terminal")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Terminal.png")));
                bitmapBuilder.DrawText("Move Focus to Terminal", color: new BitmapColor(37,26,25));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyM, ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
