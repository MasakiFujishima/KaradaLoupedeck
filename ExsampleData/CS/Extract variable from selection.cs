namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Extract_variable_from_selection : PluginDynamicCommand
    {
        public Extract_variable_from_selection()
        : base(displayName: "Extract variable from selection", description: "Extract variable from selection", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Extract variable from selection", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyV, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
