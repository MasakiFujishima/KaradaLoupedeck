namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Yank_line_up_to_cursor : PluginDynamicCommand
    {
        public Yank_line_up_to_cursor()
        : base(displayName: "Yank line up to cursor", description: "Yank line up to cursor", groupName: "Editing (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Editing (Console and Source).png")));
                bitmapBuilder.DrawText("Yank line up to cursor", color: new BitmapColor(241,228,240));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyU, ModifierKey.Ctrl);
        }
    }
}
