namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Move_Active_Cursor_Up : PluginDynamicCommand
    {
        public Move_Active_Cursor_Up()
        : base(displayName: "Move Active Cursor Up", description: "Move Active Cursor Up", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Move Active Cursor Up", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Arrowup, ModifierKey.Ctrl | ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
