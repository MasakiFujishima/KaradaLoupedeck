namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Show_Plots : PluginDynamicCommand
    {
        public Show_Plots()
        : base(displayName: "Show Plots", description: "Show Plots", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Show Plots", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(NumPad6, ModifierKey.Ctrl);
        }
    }
}
