namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Move_cursor_to_beginning_of_line : PluginDynamicCommand
    {
        public Move_cursor_to_beginning_of_line()
        : base(displayName: "Move cursor to beginning of line", description: "Move cursor to beginning of line", groupName: "Console")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Console.png")));
                bitmapBuilder.DrawText("Move cursor to beginning of line", color: new BitmapColor(4,0,1));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Home, );
        }
    }
}
