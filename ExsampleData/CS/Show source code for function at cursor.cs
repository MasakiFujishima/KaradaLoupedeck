namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Show_source_code_for_function_at_cursor : PluginDynamicCommand
    {
        public Show_source_code_for_function_at_cursor()
        : base(displayName: "Show source code for function at cursor", description: "Show source code for function at cursor", groupName: "Editing (Console and Source)")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Editing (Console and Source).png")));
                bitmapBuilder.DrawText("Show source code for function at cursor", color: new BitmapColor(241,228,240));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(F2, );
        }
    }
}
