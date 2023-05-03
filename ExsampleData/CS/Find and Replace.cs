namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Find_and_Replace : PluginDynamicCommand
    {
        public Find_and_Replace()
        : base(displayName: "Find and Replace", description: "Find and Replace", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Find and Replace", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyF, ModifierKey.Ctrl);
        }
    }
}
