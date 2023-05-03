namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Move_Active_Cursor_Down : PluginDynamicCommand
    {
        public Move_Active_Cursor_Down()
        : base(displayName: "Move Active Cursor Down", description: "Move Active Cursor Down", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Move Active Cursor Down", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Arrowdown, ModifierKey.Ctrl | ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
