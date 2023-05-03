namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Zoom_Environment : PluginDynamicCommand
    {
        public Zoom_Environment()
        : base(displayName: "Zoom Environment", description: "Zoom Environment", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Zoom Environment", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(NumPad8, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
