namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Insert_code_section : PluginDynamicCommand
    {
        public Insert_code_section()
        : base(displayName: "Insert code section", description: "Insert code section", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Insert code section", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyR, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
