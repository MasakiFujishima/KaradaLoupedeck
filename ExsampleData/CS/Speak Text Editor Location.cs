namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Speak_Text_Editor_Location : PluginDynamicCommand
    {
        public Speak_Text_Editor_Location()
        : base(displayName: "Speak Text Editor Location", description: "Speak Text Editor Location", groupName: "Accessibility")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Accessibility.png")));
                bitmapBuilder.DrawText("Speak Text Editor Location", color: new BitmapColor(107,62,29));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyB, ModifierKey.Ctrl | ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
