namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Replace_and_Find : PluginDynamicCommand
    {
        public Replace_and_Find()
        : base(displayName: "Replace and Find", description: "Replace and Find", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Replace and Find", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyJ, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
