namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Compile_Notebook : PluginDynamicCommand
    {
        public Compile_Notebook()
        : base(displayName: "Compile Notebook", description: "Compile Notebook", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Compile Notebook", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyK, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
