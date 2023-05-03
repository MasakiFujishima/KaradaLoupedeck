namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Next_Terminal : PluginDynamicCommand
    {
        public Next_Terminal()
        : base(displayName: "Next Terminal", description: "Next Terminal", groupName: "Terminal")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Terminal.png")));
                bitmapBuilder.DrawText("Next Terminal", color: new BitmapColor(37,26,25));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F12, ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
