namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class New_Terminal : PluginDynamicCommand
    {
        public New_Terminal()
        : base(displayName: "New Terminal", description: "New Terminal", groupName: "Terminal")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Terminal.png")));
                bitmapBuilder.DrawText("New Terminal", color: new BitmapColor(37,26,25));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyR, ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
