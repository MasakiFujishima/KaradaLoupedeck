namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Clear_console : PluginDynamicCommand
    {
        public Clear_console()
        : base(displayName: "Clear console", description: "Clear console", groupName: "Console")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Console.png")));
                bitmapBuilder.DrawText("Clear console", color: new BitmapColor(4,0,1));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyL, ModifierKey.Ctrl);
        }
    }
}
