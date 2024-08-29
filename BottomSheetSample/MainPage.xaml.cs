using Microsoft.Maui.Controls;

namespace BottomSheetSample
{
    public partial class MainPage : ContentPage
    {

        MyBottomSheet sheet = new MyBottomSheet();
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
            sheet.CornerRadius = 20;
            sheet.HasHandle = true;
            sheet.HandleColor = Color.FromHex("#FF0000");
            //sheet.HasBackdrop = true;
            sheet.BackgroundColor=Color.FromRgb(200,200,200);
            sheet.ShowAsync(Window);
        }

        private void OnDismissClicked(object sender, EventArgs e)
        {
            sheet.DismissAsync();
        }
    }

}
