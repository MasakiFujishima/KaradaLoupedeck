namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Extract_function_from_selection : PluginDynamicCommand
    {
        public Extract_function_from_selection()
        : base(displayName: "Extract function from selection", description: "Extract function from selection", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Extract function from selection", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyX, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
