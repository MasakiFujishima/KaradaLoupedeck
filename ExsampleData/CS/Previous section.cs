namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Previous_section : PluginDynamicCommand
    {
        public Previous_section()
        : base(displayName: "Previous section", description: "Previous section", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Previous section", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Pgarrowup, ModifierKey.Ctrl);
        }
    }
}
