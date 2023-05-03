namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Comment_uncomment_current_line_selection : PluginDynamicCommand
    {
        public Comment_uncomment_current_line_selection()
        : base(displayName: "Comment uncomment current line selection", description: "Comment uncomment current line selection", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Comment uncomment current line selection", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyC, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
