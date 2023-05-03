namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Run_from_current_line_to_document_end : PluginDynamicCommand
    {
        public Run_from_current_line_to_document_end()
        : base(displayName: "Run from current line to document end", description: "Run from current line to document end", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Run from current line to document end", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyE, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
