**Overview**
In some scenarios, you may need to ensure that all tab items in the [.NET MAUI TabView](https://www.syncfusion.com/maui-controls/maui-tab-view) control have equal width while allowing users to scroll horizontally to access items that exceed the visible area. This can be achieved by customizing the [HeaderItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_HeaderItemTemplate) in the TabView.

The following steps will guide you on how to create equal-width tab items and enable horizontal scrolling in the .NET MAUI TabView:

**Implementation Steps**

To create a TabView with equal width for all tab items and enable horizontal scrolling, follow these steps:
1. **Define the TabView**: Start by defining the `TabView` in your XAML.
2. **Set the HeaderItemTemplate**: Use the `HeaderItemTemplate` to specify how each tab item should be displayed. This template will allow you to set a common width for all tab items.
3. **Enable Scrolling**: Wrap the tab items in a `ScrollView` to enable horizontal scrolling when the number of items exceeds the visible area.

Here is an example of how to implement this:

**Model**

```
public class Model
{
    public string? Name { get; set; }
}
```

**ViewModel**

```
public class ViewModel : INotifyPropertyChanged
{
    private ObservableCollection<Model>? tabHeaderCollection;
    public ObservableCollection<Model>? TabHeaderCollection
    {
        get { return tabHeaderCollection; }
        set { tabHeaderCollection = value; 
        OnPropertyChanged(nameof(TabHeaderCollection)); }

    }
    ...
    public ViewModel()
    {
        TabHeaderCollection = new ObservableCollection<Model>()
        {
            new Model(){Name = "Call"},
            new Model(){Name = "Favourite"},
            new Model(){Name = "Contacts"},
            new Model(){Name = "More"},
            new Model(){Name = "Help"},
            new Model(){Name = "Info" },
            new Model(){Name = "About"},
            new Model(){Name = "Settings"},
        };
    }
}
```

**XAML**

```xml
<tabView:SfTabView x:Name="tabView"
                   ItemsSource="{Binding TabHeaderCollection}">
    <tabView:SfTabView.HeaderItemTemplate>
        <DataTemplate>
            <ScrollView>
                <HorizontalStackLayout Spacing="2">
                    <Label FontAttributes="Bold" 
                           WidthRequest="70"
                           HorizontalTextAlignment="Center"
                           VerticalTextAlignment="Center"
                           Text="{Binding Name}"/>
                </HorizontalStackLayout>
            </ScrollView>
        </DataTemplate>
    </tabView:SfTabView.HeaderItemTemplate>
    <tabView:SfTabView.Items>
        <tabView:SfTabItem>
            <tabView:SfTabItem.Content>
                <!-- Content for the first tab -->
            </tabView:SfTabItem.Content>
        </tabView:SfTabItem>
        <!-- Additional tab items can be added here -->
    </tabView:SfTabView.Items>
</tabView:SfTabView>
```

By following the above steps, you can create a Syncfusion TabView with equal-width tab items and horizontal scrolling functionality. This enhances the user experience by allowing easy navigation through multiple-tabs.

**Output**

![TabViewHeaderItemTemplate.gif](https://support.syncfusion.com/kb/agent/attachment/article/17124/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI4MjY4Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.osrFaKzEaaChH3dYfxtcZyunnvgsSC7WxCEiUr64wCk)
