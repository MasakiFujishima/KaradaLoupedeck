namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Navigate_forward : PluginDynamicCommand
    {
        public Navigate_forward()
        : base(displayName: "Navigate forward", description: "Navigate forward", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Navigate forward", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F10, ModifierKey.Ctrl);
        }
    }
}
