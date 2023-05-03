namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Yank_line_after_cursor : PluginDynamicCommand
    {
        public Yank_line_after_cursor()
        : base(displayName: "Yank line after cursor", description: "Yank line after cursor", groupName: "Editing (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Editing (Console and Source).png")));
                bitmapBuilder.DrawText("Yank line after cursor", color: new BitmapColor(241,228,240));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyK, ModifierKey.Ctrl);
        }
    }
}
