using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AutoFitSample
{
    public class SfListViewExt : SfListView
    {
        Grid headerGrid;
        Grid footerGrid;

        public SfListViewExt()
        {
            headerGrid = new Grid();
            headerGrid.BackgroundColor = Color.Teal;
            Label headerLabel = new Label();
            headerLabel.Text = "Header Item";
            headerLabel.FontSize = 18;
            headerLabel.TextColor = Color.White;
            headerLabel.HorizontalOptions = LayoutOptions.Center;
            headerLabel.VerticalOptions = LayoutOptions.Center;
            headerGrid.Children.Add(headerLabel);

            footerGrid = new Grid();
            footerGrid.BackgroundColor = Color.Teal;
            Label footerLabel = new Label();
            footerLabel.Text = "Footer Item";
            footerLabel.FontSize = 18;
            footerLabel.TextColor = Color.White;
            footerLabel.HorizontalOptions = LayoutOptions.Center;
            footerLabel.VerticalOptions = LayoutOptions.Center;
            footerGrid.Children.Add(footerLabel);

            this.Children.Add(headerGrid);
            this.Children.Add(footerGrid);
        }

        protected override void LayoutChildren(double x, double y, double width, double height)
        {
            headerGrid.Layout(new Rectangle(0, 0, width, 70));
            footerGrid.Layout(new Rectangle(0, height - 70, width, 70));
            base.LayoutChildren(0, 70, width, height);
        }
    }
}
