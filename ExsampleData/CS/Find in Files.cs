namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Find_in_Files : PluginDynamicCommand
    {
        public Find_in_Files()
        : base(displayName: "Find in Files", description: "Find in Files", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Find in Files", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyF, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
