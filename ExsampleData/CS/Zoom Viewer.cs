namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Zoom_Viewer : PluginDynamicCommand
    {
        public Zoom_Viewer()
        : base(displayName: "Zoom Viewer", description: "Zoom Viewer", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Zoom Viewer", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(NumPad9, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
