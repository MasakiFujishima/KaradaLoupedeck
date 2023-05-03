namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Accept_selected_candidate : PluginDynamicCommand
    {
        public Accept_selected_candidate()
        : base(displayName: "Accept selected candidate", description: "Accept selected candidate", groupName: "Completions (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Completions (Console and Source).png")));
                bitmapBuilder.DrawText("Accept selected candidate", color: new BitmapColor(23,42,19));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Tab, );
        }
    }
}
