namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Zoom_Files : PluginDynamicCommand
    {
        public Zoom_Files()
        : base(displayName: "Zoom Files", description: "Zoom Files", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Zoom Files", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(NumPad5, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
