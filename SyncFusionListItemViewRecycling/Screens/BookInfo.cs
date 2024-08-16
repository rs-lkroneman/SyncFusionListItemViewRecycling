using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SyncFusionListItemViewRecycling.Screens;

public partial class BookInfo : ObservableObject
{
    public string Name { get; init; } = null!;

    [ObservableProperty] private int count;
    
    [RelayCommand]
    private void DropItem()
    {
        Count++;
    }
}