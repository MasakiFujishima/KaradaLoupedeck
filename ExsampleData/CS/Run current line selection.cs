namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Run_current_line_selection : PluginDynamicCommand
    {
        public Run_current_line_selection()
        : base(displayName: "Run current line selection", description: "Run current line selection", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Run current line selection", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Enter, ModifierKey.Ctrl);
        }
    }
}
