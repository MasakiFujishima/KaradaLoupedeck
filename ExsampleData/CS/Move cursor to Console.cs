namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Move_cursor_to_Console : PluginDynamicCommand
    {
        public Move_cursor_to_Console()
        : base(displayName: "Move cursor to Console", description: "Move cursor to Console", groupName: "Console")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Console.png")));
                bitmapBuilder.DrawText("Move cursor to Console", color: new BitmapColor(4,0,1));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(NumPad2, ModifierKey.Ctrl);
        }
    }
}
