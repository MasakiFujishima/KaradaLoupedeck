namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Toggle_Screen_Reader_Support : PluginDynamicCommand
    {
        public Toggle_Screen_Reader_Support()
        : base(displayName: "Toggle Screen Reader Support", description: "Toggle Screen Reader Support", groupName: "Accessibility")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Accessibility.png")));
                bitmapBuilder.DrawText("Toggle Screen Reader Support", color: new BitmapColor(107,62,29));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Oem2, ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
