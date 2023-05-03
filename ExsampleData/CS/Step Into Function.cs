namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Step_Into_Function : PluginDynamicCommand
    {
        public Step_Into_Function()
        : base(displayName: "Step Into Function", description: "Step Into Function", groupName: "Debug")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Debug.png")));
                bitmapBuilder.DrawText("Step Into Function", color: new BitmapColor(211,223,242));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F4, ModifierKey.Shift);
        }
    }
}
