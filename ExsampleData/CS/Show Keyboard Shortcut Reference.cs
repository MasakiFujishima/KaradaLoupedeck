namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Show_Keyboard_Shortcut_Reference : PluginDynamicCommand
    {
        public Show_Keyboard_Shortcut_Reference()
        : base(displayName: "Show Keyboard Shortcut Reference", description: "Show Keyboard Shortcut Reference", groupName: "Help")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Help.png")));
                bitmapBuilder.DrawText("Show Keyboard Shortcut Reference", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyK, ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
