namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Zoom_Build : PluginDynamicCommand
    {
        public Zoom_Build()
        : base(displayName: "Zoom Build", description: "Zoom Build", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Zoom Build", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F2, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
