namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Show_Files : PluginDynamicCommand
    {
        public Show_Files()
        : base(displayName: "Show Files", description: "Show Files", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Show Files", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(NumPad5, ModifierKey.Ctrl);
        }
    }
}
