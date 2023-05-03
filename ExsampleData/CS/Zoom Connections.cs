namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Zoom_Connections : PluginDynamicCommand
    {
        public Zoom_Connections()
        : base(displayName: "Zoom Connections", description: "Zoom Connections", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Zoom Connections", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F5, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
