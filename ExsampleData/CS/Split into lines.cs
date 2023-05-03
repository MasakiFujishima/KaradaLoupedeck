namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Split_into_lines : PluginDynamicCommand
    {
        public Split_into_lines()
        : base(displayName: "Split into lines", description: "Split into lines", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Split into lines", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyA, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
