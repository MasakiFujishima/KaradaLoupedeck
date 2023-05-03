namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Save_active_document : PluginDynamicCommand
    {
        public Save_active_document()
        : base(displayName: "Save active document", description: "Save active document", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Save active document", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyS, ModifierKey.Ctrl);
        }
    }
}
