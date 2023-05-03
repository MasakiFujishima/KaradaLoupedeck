namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Jump_to : PluginDynamicCommand
    {
        public Jump_to()
        : base(displayName: "Jump to", description: "Jump to", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Jump to", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyJ, ModifierKey.Shift | ModifierKey.Alt);
        }
    }
}
