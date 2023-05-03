namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Toggle_Visual_Editor : PluginDynamicCommand
    {
        public Toggle_Visual_Editor()
        : base(displayName: "Toggle Visual Editor", description: "Toggle Visual Editor", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Toggle Visual Editor", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F4, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
