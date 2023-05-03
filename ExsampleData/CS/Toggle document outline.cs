namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Toggle_document_outline : PluginDynamicCommand
    {
        public Toggle_document_outline()
        : base(displayName: "Toggle document outline", description: "Toggle document outline", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Toggle document outline", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyO, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
