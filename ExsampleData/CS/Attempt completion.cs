namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Attempt_completion : PluginDynamicCommand
    {
        public Attempt_completion()
        : base(displayName: "Attempt completion", description: "Attempt completion", groupName: "Completions (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Completions (Console and Source).png")));
                bitmapBuilder.DrawText("Attempt completion", color: new BitmapColor(23,42,19));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Space, ModifierKey.Ctrl);
        }
    }
}
