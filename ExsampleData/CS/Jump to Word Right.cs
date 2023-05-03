namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Jump_to_Word_Right : PluginDynamicCommand
    {
        public Jump_to_Word_Right()
        : base(displayName: "Jump to Word Right", description: "Jump to Word Right", groupName: "Editing (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Editing (Console and Source).png")));
                bitmapBuilder.DrawText("Jump to Word Right", color: new BitmapColor(241,228,240));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Arrowright, ModifierKey.Ctrl);
        }
    }
}
