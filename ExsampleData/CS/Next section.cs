namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Next_section : PluginDynamicCommand
    {
        public Next_section()
        : base(displayName: "Next section", description: "Next section", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Next section", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Pgdn, ModifierKey.Ctrl);
        }
    }
}
