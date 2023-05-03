namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Go_to_File_Function : PluginDynamicCommand
    {
        public Go_to_File_Function()
        : base(displayName: "Go to File Function", description: "Go to File Function", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Go to File Function", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Period , ModifierKey.Ctrl);
        }
    }
}
