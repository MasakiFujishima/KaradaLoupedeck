namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Toggle_Breakpoint : PluginDynamicCommand
    {
        public Toggle_Breakpoint()
        : base(displayName: "Toggle Breakpoint", description: "Toggle Breakpoint", groupName: "Debug")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Debug.png")));
                bitmapBuilder.DrawText("Toggle Breakpoint", color: new BitmapColor(211,223,242));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F9, ModifierKey.Shift);
        }
    }
}
