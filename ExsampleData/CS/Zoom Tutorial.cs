namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Zoom_Tutorial : PluginDynamicCommand
    {
        public Zoom_Tutorial()
        : base(displayName: "Zoom Tutorial", description: "Zoom Tutorial", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Zoom Tutorial", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F6, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
