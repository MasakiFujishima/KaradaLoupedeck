namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Zoom_Console : PluginDynamicCommand
    {
        public Zoom_Console()
        : base(displayName: "Zoom Console", description: "Zoom Console", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Zoom Console", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(NumPad2, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
