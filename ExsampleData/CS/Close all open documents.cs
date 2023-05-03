namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Close_all_open_documents : PluginDynamicCommand
    {
        public Close_all_open_documents()
        : base(displayName: "Close all open documents", description: "Close all open documents", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Close all open documents", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyW, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
