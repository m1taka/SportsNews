//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportsNews.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class NewsArticleCategories
    {
        public int Id { get; set; }
        public int NewsCategoriesId { get; set; }
        public int NewsArticleId { get; set; }
    
        public virtual NewsArticles NewsArticles { get; set; }
        public virtual NewsCategories NewsCategories { get; set; }
    }
}
