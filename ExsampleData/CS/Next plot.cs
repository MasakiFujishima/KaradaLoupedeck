namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Next_plot : PluginDynamicCommand
    {
        public Next_plot()
        : base(displayName: "Next plot", description: "Next plot", groupName: "Plots")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Plots.png")));
                bitmapBuilder.DrawText("Next plot", color: new BitmapColor(4,0,0));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F12, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
