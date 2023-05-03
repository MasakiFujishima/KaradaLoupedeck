namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Check_Package : PluginDynamicCommand
    {
        public Check_Package()
        : base(displayName: "Check Package", description: "Check Package", groupName: "Build")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Build.png")));
                bitmapBuilder.DrawText("Check Package", color: new BitmapColor(4,0,0));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyE, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
