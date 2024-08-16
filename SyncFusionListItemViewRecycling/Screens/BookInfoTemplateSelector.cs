namespace SyncFusionListItemViewRecycling.Screens;

public class BookInfoTemplateSelector: DataTemplateSelector
{
    private readonly DataTemplate bookInfoListItemView =
        new(typeof(BookInfoListItemView));

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        return bookInfoListItemView;
    }
}