## Some wpf helpers:
* Editable label
* WaitControl

***

### Editable label:
Just a little control, containes textbox with edit\nonedit mode. If press pen or double click - edit enables, click somethere else - disables.

Preview:

![](https://github.com/Znakes/wpfHelpers/blob/master/docs/editLabel.PNG)

### Wait Control:
Can be used while waiting data load.
[More from here](http://habrahabr.ru/post/102105/)

Usage:
````
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
````

Result: 

![](http://habrastorage.org/storage/habraeffect/f8/0a/f80a12e2bb303dbc7dc288f7df0dee41.jpg)

