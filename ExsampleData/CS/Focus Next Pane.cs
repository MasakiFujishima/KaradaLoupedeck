namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Focus_Next_Pane : PluginDynamicCommand
    {
        public Focus_Next_Pane()
        : base(displayName: "Focus Next Pane", description: "Focus Next Pane", groupName: "Accessibility")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Accessibility.png")));
                bitmapBuilder.DrawText("Focus Next Pane", color: new BitmapColor(107,62,29));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F6, );
        }
    }
}
