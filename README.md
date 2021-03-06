# Header and footer in vertical mode when ListView is in horizontal mode

By customizing the [SfListView](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView.html), layout the header and footer items in `Vertical` mode with listview items in `Horizontal` mode.

```
<ContentPage >

    <ContentPage.BindingContext>
        <local:ListViewAutoFitContentViewModel x:Name="ViewModel"/>
    </ContentPage.BindingContext>
   
    <local:SfListViewExt x:Name="listView" ItemSize="180" GroupHeaderSize="80"
                         ItemSpacing="2" Orientation="Horizontal"
                         ItemsSource="{Binding BookInfo}"
                         SelectionMode="None"
                         IsStickyGroupHeader="False"
                         SelectionBackgroundColor="#d3d3d3">
        <local:SfListViewExt.ItemTemplate>
                <DataTemplate>
                    <Grid RowSpacing="0">
                        <Grid.RowDefinitions>
                            <RowDefinition Height="Auto" />
                            <RowDefinition Height="Auto" />
                            <RowDefinition Height="1" />
                        </Grid.RowDefinitions>
                        <Grid Grid.Row="0" RowSpacing="0" Padding="5,10,5,5">
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="Auto" />
                                <ColumnDefinition Width="Auto" />
                            </Grid.ColumnDefinitions>
                            <StackLayout Padding="10,0,0,0" Orientation="Vertical" Grid.Column="1">
                                <Label Text="{Binding BookName}" FontAttributes="Bold" FontSize="18" TextColor="#474747" VerticalTextAlignment="Center"/>
                                <Label Text="By Syncfusion Software" FontSize="12" TextColor="#474747" VerticalTextAlignment="Center"/>
                                <Label Text="Published on: March 22, 2017" FontSize="12" TextColor="#474747" VerticalTextAlignment="Center"/>
                            </StackLayout>
                        </Grid>
                        <StackLayout Padding="5,10,0,5" Grid.Row="1" Orientation="Vertical">
                            <Label Text="Description" FontSize="15" FontAttributes="Bold"  TextColor="#474747" VerticalTextAlignment="Center"/>
                            <Label Text="{Binding BookDescription}" TextColor="#474747" FontSize="14" VerticalTextAlignment="Center"/>
                        </StackLayout>
                        <BoxView Grid.Row="2" HeightRequest="1" BackgroundColor="#474747" />
                    </Grid>
                </DataTemplate>
            </local:SfListViewExt.ItemTemplate>
        </local:SfListViewExt>
</ContentPage>
```
To know more about ListView header and footer, please refer our documentation [here](https://help.syncfusion.com/xamarin/sflistview/headerandfooter)