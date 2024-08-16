using System.Collections.ObjectModel;

namespace SyncFusionListItemViewRecycling.Screens;

public class BookInfoRepository
{
    public ObservableCollection<BookInfo> BookInfo { get; set; } =
    [
        new BookInfo() { Name = "Object-Oriented Programming in C#"},
        new BookInfo() { Name = "C# Code Contracts", },
        new BookInfo() { Name = "Machine Learning Using C#",  },
        new BookInfo() { Name = "Neural Networks Using C#",  },
        new BookInfo() { Name = "Visual Studio Code", },
        new BookInfo() { Name = "Android Programming", },
        new BookInfo() { Name = "iOS Succinctly",  },
        new BookInfo() { Name = "Visual Studio 2015",  },
        new BookInfo() { Name = "Xamarin.Forms",  },
        new BookInfo() { Name = "Windows Store Apps", },
        new BookInfo() { Name = "Object-Oriented Programming in C#"},
        new BookInfo() { Name = "C# Code Contracts", },
        new BookInfo() { Name = "Machine Learning Using C#",  },
        new BookInfo() { Name = "Neural Networks Using C#",  },
        new BookInfo() { Name = "Visual Studio Code", },
        new BookInfo() { Name = "Android Programming", },
        new BookInfo() { Name = "iOS Succinctly",  },
        new BookInfo() { Name = "Visual Studio 2015",  },
        new BookInfo() { Name = "Xamarin.Forms",  },
        new BookInfo() { Name = "Windows Store Apps" },
        new BookInfo() { Name = "Object-Oriented Programming in C#" },
        new BookInfo() { Name = "C# Code Contracts", },
        new BookInfo() { Name = "Machine Learning Using C#",  },
        new BookInfo() { Name = "Neural Networks Using C#",  },
        new BookInfo() { Name = "Visual Studio Code", },
        new BookInfo() { Name = "Android Programming", },
        new BookInfo() { Name = "iOS Succinctly",  },
        new BookInfo() { Name = "Visual Studio 2015",  },
        new BookInfo() { Name = "Xamarin.Forms",  },
        new BookInfo() { Name = "Windows Store Apps", },
        new BookInfo() { Name = "Object-Oriented Programming in C#"},
        new BookInfo() { Name = "C# Code Contracts", },
        new BookInfo() { Name = "Machine Learning Using C#",  },
        new BookInfo() { Name = "Neural Networks Using C#",  },
        new BookInfo() { Name = "Visual Studio Code", },
        new BookInfo() { Name = "Android Programming", },
        new BookInfo() { Name = "iOS Succinctly",  },
        new BookInfo() { Name = "Visual Studio 2015",  },
        new BookInfo() { Name = "Xamarin.Forms",  },
        new BookInfo() { Name = "Windows Store Apps" },
        new BookInfo() { Name = "Object-Oriented Programming in C#"  },
        new BookInfo() { Name = "C# Code Contracts", },
        new BookInfo() { Name = "Machine Learning Using C#",  },
        new BookInfo() { Name = "Neural Networks Using C#",  },
        new BookInfo() { Name = "Visual Studio Code", },
        new BookInfo() { Name = "Android Programming", },
        new BookInfo() { Name = "iOS Succinctly",  },
        new BookInfo() { Name = "Visual Studio 2015",  },
        new BookInfo() { Name = "Xamarin.Forms",  },
        new BookInfo() { Name = "Windows Store Apps", }
    ];

    public void DeleteBookInfo(BookInfo bookInfo)
    {
        BookInfo.Remove(bookInfo);
    }
}