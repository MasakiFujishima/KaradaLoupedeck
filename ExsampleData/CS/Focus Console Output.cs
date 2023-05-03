namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Focus_Console_Output : PluginDynamicCommand
    {
        public Focus_Console_Output()
        : base(displayName: "Focus Console Output", description: "Focus Console Output", groupName: "Accessibility")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Accessibility.png")));
                bitmapBuilder.DrawText("Focus Console Output", color: new BitmapColor(107,62,29));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(NumPad2, ModifierKey.Alt | ModifierKey.Shift);
        }
    }
}
