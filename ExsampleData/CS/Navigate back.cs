namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Navigate_back : PluginDynamicCommand
    {
        public Navigate_back()
        : base(displayName: "Navigate back", description: "Navigate back", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Navigate back", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F9, ModifierKey.Ctrl);
        }
    }
}
