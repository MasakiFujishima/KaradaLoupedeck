namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Toggle_Tab_Key_Always_Moves_Focus : PluginDynamicCommand
    {
        public Toggle_Tab_Key_Always_Moves_Focus()
        : base(displayName: "Toggle Tab Key Always Moves Focus", description: "Toggle Tab Key Always Moves Focus", groupName: "Accessibility")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Accessibility.png")));
                bitmapBuilder.DrawText("Toggle Tab Key Always Moves Focus", color: new BitmapColor(107,62,29));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyT, ModifierKey.Ctrl | ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
