namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Document_Package : PluginDynamicCommand
    {
        public Document_Package()
        : base(displayName: "Document Package", description: "Document Package", groupName: "Build")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Build.png")));
                bitmapBuilder.DrawText("Document Package", color: new BitmapColor(4,0,0));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyD, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
