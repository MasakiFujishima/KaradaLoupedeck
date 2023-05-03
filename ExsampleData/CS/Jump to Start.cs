namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Jump_to_Start : PluginDynamicCommand
    {
        public Jump_to_Start()
        : base(displayName: "Jump to Start", description: "Jump to Start", groupName: "Editing (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Editing (Console and Source).png")));
                bitmapBuilder.DrawText("Jump to Start", color: new BitmapColor(241,228,240));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Home, ModifierKey.Ctrl);
        }
    }
}
