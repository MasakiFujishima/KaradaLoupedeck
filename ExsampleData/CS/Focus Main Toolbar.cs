namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Focus_Main_Toolbar : PluginDynamicCommand
    {
        public Focus_Main_Toolbar()
        : base(displayName: "Focus Main Toolbar", description: "Focus Main Toolbar", groupName: "Accessibility")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Accessibility.png")));
                bitmapBuilder.DrawText("Focus Main Toolbar", color: new BitmapColor(107,62,29));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyY, ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
