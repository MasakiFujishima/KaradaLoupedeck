namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Run_from_document_beginning_to_current_line : PluginDynamicCommand
    {
        public Run_from_document_beginning_to_current_line()
        : base(displayName: "Run from document beginning to current line", description: "Run from document beginning to current line", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Run from document beginning to current line", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyB, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
