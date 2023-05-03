namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Continue : PluginDynamicCommand
    {
        public Continue()
        : base(displayName: "Continue", description: "Continue", groupName: "Debug")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Debug.png")));
                bitmapBuilder.DrawText("Continue", color: new BitmapColor(211,223,242));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F5, ModifierKey.Shift);
        }
    }
}
