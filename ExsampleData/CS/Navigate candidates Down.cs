namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Navigate_candidates_Down : PluginDynamicCommand
    {
        public Navigate_candidates_Down()
        : base(displayName: "Navigate candidates Down", description: "Navigate candidates Down", groupName: "Completions (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Completions (Console and Source).png")));
                bitmapBuilder.DrawText("Navigate candidates Down", color: new BitmapColor(23,42,19));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Arrowdown, );
        }
    }
}
