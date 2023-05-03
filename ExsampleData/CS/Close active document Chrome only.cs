namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Close_active_document_Chrome_only : PluginDynamicCommand
    {
        public Close_active_document_Chrome_only()
        : base(displayName: "Close active document Chrome only", description: "Close active document Chrome only", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Close active document Chrome only", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyW, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
