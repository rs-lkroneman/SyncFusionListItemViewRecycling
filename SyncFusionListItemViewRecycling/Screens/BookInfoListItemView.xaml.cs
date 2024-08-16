using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncFusionListItemViewRecycling.Screens;

public partial class BookInfoListItemView : ContentView
{
    public BookInfoListItemView()
    {
        InitializeComponent();
    }
    
    private void DragOverItem(object? sender, DragEventArgs e)
    {
        if (sender == null)
        {
            return;
        }
        
        var gestureRecognizer = (DropGestureRecognizer)sender;
        if(gestureRecognizer.Parent is View bookListItem)
        {
            bookListItem.BackgroundColor = Colors.Tomato;
        }
    }

    private void DragLeaveItem(object? sender, DragEventArgs e)
    {
        if (sender == null)
        {
            return;
        }
        
        var gestureRecognizer = (DropGestureRecognizer)sender;
        if(gestureRecognizer.Parent is View bookListItem)
        {
            bookListItem.BackgroundColor = Colors.Transparent;
        }
    }
}