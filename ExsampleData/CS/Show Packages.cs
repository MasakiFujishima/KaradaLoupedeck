namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Show_Packages : PluginDynamicCommand
    {
        public Show_Packages()
        : base(displayName: "Show Packages", description: "Show Packages", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Show Packages", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(NumPad7, ModifierKey.Ctrl);
        }
    }
}
