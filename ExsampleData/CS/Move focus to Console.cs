namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Move_focus_to_Console : PluginDynamicCommand
    {
        public Move_focus_to_Console()
        : base(displayName: "Move focus to Console", description: "Move focus to Console", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Move focus to Console", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(NumPad2, ModifierKey.Ctrl);
        }
    }
}
