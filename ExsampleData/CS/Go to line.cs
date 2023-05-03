namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Go_to_line : PluginDynamicCommand
    {
        public Go_to_line()
        : base(displayName: "Go to line", description: "Go to line", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Go to line", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyG, ModifierKey.Shift | ModifierKey.Alt);
        }
    }
}
