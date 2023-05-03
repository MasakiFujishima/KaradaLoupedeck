namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Add_Cursor_Above_Current_Cursor : PluginDynamicCommand
    {
        public Add_Cursor_Above_Current_Cursor()
        : base(displayName: "Add Cursor Above Current Cursor", description: "Add Cursor Above Current Cursor", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Add Cursor Above Current Cursor", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Arrowup, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
