namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Show_Find_in_Files_Results : PluginDynamicCommand
    {
        public Show_Find_in_Files_Results()
        : base(displayName: "Show Find in Files Results", description: "Show Find in Files Results", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Show Find in Files Results", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F6, ModifierKey.Ctrl);
        }
    }
}
