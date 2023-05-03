namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Restart_R_Session : PluginDynamicCommand
    {
        public Restart_R_Session()
        : base(displayName: "Restart R Session", description: "Restart R Session", groupName: "Session")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Session.png")));
                bitmapBuilder.DrawText("Restart R Session", color: new BitmapColor(4,0,0));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F10, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
