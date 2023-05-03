namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Reindent_lines : PluginDynamicCommand
    {
        public Reindent_lines()
        : base(displayName: "Reindent lines", description: "Reindent lines", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Reindent lines", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyI, ModifierKey.Ctrl);
        }
    }
}
