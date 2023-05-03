namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Search_R_Help : PluginDynamicCommand
    {
        public Search_R_Help()
        : base(displayName: "Search R Help", description: "Search R Help", groupName: "Help")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Help.png")));
                bitmapBuilder.DrawText("Search R Help", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F1, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
