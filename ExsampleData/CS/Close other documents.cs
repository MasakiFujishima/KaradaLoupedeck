namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Close_other_documents : PluginDynamicCommand
    {
        public Close_other_documents()
        : base(displayName: "Close other documents", description: "Close other documents", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Close other documents", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyW, ModifierKey.Ctrl | ModifierKey.Shift | ModifierKey.Alt);
        }
    }
}
