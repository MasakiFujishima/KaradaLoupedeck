namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Send_current_line_selection_to_terminal : PluginDynamicCommand
    {
        public Send_current_line_selection_to_terminal()
        : base(displayName: "Send current line selection to terminal", description: "Send current line selection to terminal", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Send current line selection to terminal", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Enter, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
