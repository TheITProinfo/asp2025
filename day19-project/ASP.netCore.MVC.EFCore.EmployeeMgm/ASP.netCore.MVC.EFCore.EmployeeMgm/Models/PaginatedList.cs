using Microsoft.EntityFrameworkCore;
namespace ASP.netCore.MVC.EFCore.EmployeeMgm.Models;

public class PaginatedList<T>
{
    public List<T> Items { get; private set; }
    public int TotalCount { get; private set; }
    public int PageIndex { get; private set; }
    public int PageSize { get; private set; }
    public int TotalPages { get; private set; }

    // public List<Employee> Items { get; private set; }
    // constructor to initialize the properties
    public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
    {

        PageIndex = pageIndex;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        Items = items;



    }

    public bool HasPreviousPage => (PageIndex > 1);
    public bool HasNextPage => (PageIndex < TotalPages);

    public int FirstItemIndex => (PageIndex - 1) * PageSize + 1;
    public int LastItemIndex => Math.Min(PageIndex * PageSize, TotalCount);

    public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
    {
        var count = await source.CountAsync(); //total number of items in the source data.      
        var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
        return new PaginatedList<T>(items, count, pageIndex, pageSize);

    }



}//end of class
