namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Previous_plot : PluginDynamicCommand
    {
        public Previous_plot()
        : base(displayName: "Previous plot", description: "Previous plot", groupName: "Plots")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Plots.png")));
                bitmapBuilder.DrawText("Previous plot", color: new BitmapColor(4,0,0));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F11, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
