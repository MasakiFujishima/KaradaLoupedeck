namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Popup_command_history : PluginDynamicCommand
    {
        public Popup_command_history()
        : base(displayName: "Popup command history", description: "Popup command history", groupName: "Console")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Console.png")));
                bitmapBuilder.DrawText("Popup command history", color: new BitmapColor(4,0,1));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Arrowup, ModifierKey.Ctrl);
        }
    }
}
