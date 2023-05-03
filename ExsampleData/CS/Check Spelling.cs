namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Check_Spelling : PluginDynamicCommand
    {
        public Check_Spelling()
        : base(displayName: "Check Spelling", description: "Check Spelling", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Check Spelling", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F7, );
        }
    }
}
