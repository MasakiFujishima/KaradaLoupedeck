namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Source_the_current_document_with_echo : PluginDynamicCommand
    {
        public Source_the_current_document_with_echo()
        : base(displayName: "Source the current document with echo", description: "Source the current document with echo", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Source the current document with echo", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Enter, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
