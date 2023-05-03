namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Show_Connections : PluginDynamicCommand
    {
        public Show_Connections()
        : base(displayName: "Show Connections", description: "Show Connections", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Show Connections", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F5, ModifierKey.Ctrl);
        }
    }
}
