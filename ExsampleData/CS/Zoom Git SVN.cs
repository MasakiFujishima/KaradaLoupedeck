namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Zoom_Git_SVN : PluginDynamicCommand
    {
        public Zoom_Git_SVN()
        : base(displayName: "Zoom Git SVN", description: "Zoom Git SVN", groupName: "Views")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Views.png")));
                bitmapBuilder.DrawText("Zoom Git SVN", color: new BitmapColor(238,205,225));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F1, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
