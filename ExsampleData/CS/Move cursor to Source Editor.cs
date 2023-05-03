namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Move_cursor_to_Source_Editor : PluginDynamicCommand
    {
        public Move_cursor_to_Source_Editor()
        : base(displayName: "Move cursor to Source Editor", description: "Move cursor to Source Editor", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Move cursor to Source Editor", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(NumPad1, ModifierKey.Ctrl);
        }
    }
}
