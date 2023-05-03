namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Focus_Previous_Pane : PluginDynamicCommand
    {
        public Focus_Previous_Pane()
        : base(displayName: "Focus Previous Pane", description: "Focus Previous Pane", groupName: "Accessibility")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Accessibility.png")));
                bitmapBuilder.DrawText("Focus Previous Pane", color: new BitmapColor(107,62,29));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F6, ModifierKey.Shift);
        }
    }
}
