namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Zoom_Packages : PluginDynamicCommand
    {
        public Zoom_Packages()
        : base(displayName: "Zoom Packages", description: "Zoom Packages", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Zoom Packages", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(NumPad7, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
