namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Quit_Session_desktop_only : PluginDynamicCommand
    {
        public Quit_Session_desktop_only()
        : base(displayName: "Quit Session desktop only", description: "Quit Session desktop only", groupName: "Session")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Session.png")));
                bitmapBuilder.DrawText("Quit Session desktop only", color: new BitmapColor(4,0,0));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyQ, ModifierKey.Ctrl);
        }
    }
}
