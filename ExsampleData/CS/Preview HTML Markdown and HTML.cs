namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Preview_HTML_Markdown_and_HTML : PluginDynamicCommand
    {
        public Preview_HTML_Markdown_and_HTML()
        : base(displayName: "Preview HTML Markdown and HTML", description: "Preview HTML Markdown and HTML", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Preview HTML Markdown and HTML", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyK, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
