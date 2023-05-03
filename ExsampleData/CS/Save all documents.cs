namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Save_all_documents : PluginDynamicCommand
    {
        public Save_all_documents()
        : base(displayName: "Save all documents", description: "Save all documents", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Save all documents", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyS, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
