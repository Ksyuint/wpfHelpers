## Some wpf helpers:
* Editable label
* WaitControl
* Tracker control
* Zoombox

***

### Editable label:
Just a little control, containes textbox with edit\nonedit mode. If press pen or double click - edit enables, click somethere else - disables.

Preview:

![](https://github.com/Znakes/wpfHelpers/blob/master/docs/editLabel.PNG)

### Wait Control:
Can be used while waiting data load.
[Read more here](http://habrahabr.ru/post/102105/)

Usage:
```
<ListBox x:Name="ItemsListBox" 
    <ListBox x:Name="ItemsListBox" 
            Grid.Row="0" 
            ItemsSource="{Binding Items, IsAsync=True}"
            SelectedItem="{Binding SelectedItem}">
    <ListBox.Style>
        <Style TargetType="{x:Type ListBox}">
            <Style.Triggers>
                <Trigger Property="ItemsSource" Value="{x:Null}">
                    <Setter Property="Template" Value="{StaticResource WaitControlTemplate}" />
                </Trigger>
            </Style.Triggers>
        </Style>
    </ListBox.Style>
</ListBox>
```

Result: 

![](http://habrastorage.org/storage/habraeffect/f8/0a/f80a12e2bb303dbc7dc288f7df0dee41.jpg)

### Tracker control
Allow to draw lines and polylines on canvas by mouse/code

Usage:

```
var tracker = new TrackersController(Application.Current.MainWindow, Canvas);
tracker.Init();
track.AddPoint(new Point(100,100));
track.AddPoint(new Point(50,50));
track.AddPoint(new Point(70,40));
```

Preview:

<img src="https://github.com/Znakes/wpfHelpers/blob/master/docs/tracker.PNG" height="200">

### Tracker control
Simple control to zoom and pan controls

Usage:
```
<zoombox:ZoomControl HorizontalAlignment="Stretch" VerticalAlignment="Stretch">
	<Canvas x:Name="Canvas" ClipToBounds="True"
			Width="{Binding ElementName=Host, Path=ActualWidth}"
			Height="{Binding ElementName=Host, Path=ActualHeight}" RenderTransformOrigin="0.5,0.5">
		<Image Name="Host" Source="..." Stretch="Fill"  />
	</Canvas>
</zoombox:ZoomControl>
```

Preview:

<img src="https://github.com/Znakes/wpfHelpers/blob/master/docs/zoom.PNG">

## Collections

* Object pool
* Limited object pool with blocking
