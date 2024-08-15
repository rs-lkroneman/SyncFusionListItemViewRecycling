using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncFusionListItemViewRecycling.Screens;

public partial class ListItemRefreshView : ContentPage
{
    public ListItemRefreshView()
    {
        BookInfoRepository viewModel = new BookInfoRepository();
        BindingContext = viewModel;
        InitializeComponent();
    }
}