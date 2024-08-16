using System.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SyncFusionListItemViewRecycling.Screens;

public partial class ListItemRefreshView : ContentPage
{
    readonly BookInfoRepository viewModel = new();
    public bool IsRefreshing { get; set; }

    public ListItemRefreshView()
    {
        BindingContext = viewModel;
        InitializeComponent();
    }
    
    [RelayCommand]
    private async Task Refresh(BookInfo bookInfo)
    {
        await Task.Delay(300);
        IsRefreshing = false;
    }
    
    [RelayCommand]
    private void DeleteItem(BookInfo bookInfo)
    {
        viewModel.DeleteBookInfo(bookInfo);
    }

    private void OnDragStarting(object? sender, DragStartingEventArgs e)
    {
        dragLabel.Text = "Dragging";
    }



    private void OnDropCompleted(object? sender, DropCompletedEventArgs e)
    { 
        if (sender == null)
        {
            return;
        }

        
        dragLabel.Text = "Drag Me";
        var items = FindAllElementsByName(listViewList, "BookListItem");
        foreach (var item in items)
        {
            item.BackgroundColor = Colors.Transparent;
        }
    }
    
    private List<View> FindAllElementsByName(View? parent, string name)
    {
        var result = new List<View>();
        if (parent == null)
        {
            return result;
        }

        if (parent.StyleId == name)
        {
            result.Add(parent);
        }

        foreach (var child in parent.GetVisualTreeDescendants())
        {
            if (child is View childView)
            {
                if (childView.StyleId == name)
                {
                    result.Add(childView);
                }
            }
        }

        return result;
    }
}