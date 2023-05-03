namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Navigate_candidates_Up : PluginDynamicCommand
    {
        public Navigate_candidates_Up()
        : base(displayName: "Navigate candidates Up", description: "Navigate candidates Up", groupName: "Completions (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Completions (Console and Source).png")));
                bitmapBuilder.DrawText("Navigate candidates Up", color: new BitmapColor(23,42,19));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Arrowup, );
        }
    }
}
