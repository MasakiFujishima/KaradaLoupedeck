namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Zoom_Help : PluginDynamicCommand
    {
        public Zoom_Help()
        : base(displayName: "Zoom Help", description: "Zoom Help", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Zoom Help", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(NumPad3, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
