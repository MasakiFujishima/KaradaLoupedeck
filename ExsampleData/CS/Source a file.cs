namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Source_a_file : PluginDynamicCommand
    {
        public Source_a_file()
        : base(displayName: "Source a file", description: "Source a file", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Source a file", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyG, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
