namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Transpose_Letters : PluginDynamicCommand
    {
        public Transpose_Letters()
        : base(displayName: "Transpose Letters", description: "Transpose Letters", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Transpose Letters", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(No Shortcut, );
        }
    }
}
