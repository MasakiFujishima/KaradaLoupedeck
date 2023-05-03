namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Zoom_Plots : PluginDynamicCommand
    {
        public Zoom_Plots()
        : base(displayName: "Zoom Plots", description: "Zoom Plots", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Zoom Plots", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(NumPad6, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
