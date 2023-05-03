namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Finish_Function_Loop : PluginDynamicCommand
    {
        public Finish_Function_Loop()
        : base(displayName: "Finish Function Loop", description: "Finish Function Loop", groupName: "Debug")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Debug.png")));
                bitmapBuilder.DrawText("Finish Function Loop", color: new BitmapColor(211,223,242));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F7, ModifierKey.Shift);
        }
    }
}
