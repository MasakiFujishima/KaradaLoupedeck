namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Dismiss_completion_popup : PluginDynamicCommand
    {
        public Dismiss_completion_popup()
        : base(displayName: "Dismiss completion popup", description: "Dismiss completion popup", groupName: "Completions (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Completions (Console and Source).png")));
                bitmapBuilder.DrawText("Dismiss completion popup", color: new BitmapColor(23,42,19));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Esc, );
        }
    }
}
