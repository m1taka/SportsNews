using System.Data.Entity; 
namespace SportsNews.Data
{
    public interface ISportsNewsData
    {
        DbSet<NewsArticleCategories> NewsArticleCategories { get; set; }
        DbSet<NewsArticles> NewsArticles { get; set; }
        DbSet<NewsCategories> NewsCategories { get; set; }
        DbSet<User> User { get; set; }        
        int SaveChanges();
    }
}
