using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace ProjectAlexKadyn
{
    public class GetResults
    {

        public class Rootobject
        {
            public string href { get; set; }
            public int total { get; set; }
            public int limit { get; set; }
            public int offset { get; set; }
            public Itemsummary[] itemSummaries { get; set; }
        }

        public class Itemsummary
        {
            public string itemId { get; set; }
            public string title { get; set; }
            public string[] leafCategoryIds { get; set; }
            public Category[] categories { get; set; }
            public Price price { get; set; }
            public string itemHref { get; set; }
            public Seller seller { get; set; }
            public string condition { get; set; }
            public string conditionId { get; set; }
            public Shippingoption[] shippingOptions { get; set; }
            public string[] buyingOptions { get; set; }
            public string itemWebUrl { get; set; }
            public Itemlocation itemLocation { get; set; }
            public bool adultOnly { get; set; }
            public string legacyItemId { get; set; }
            public bool availableCoupons { get; set; }
            public DateTime itemCreationDate { get; set; }
            public bool topRatedBuyingExperience { get; set; }
            public bool priorityListing { get; set; }
            public string listingMarketplaceId { get; set; }
        }

        public class Price
        {
            public string value { get; set; }
            public string currency { get; set; }
        }

        public class Seller
        {
            public int feedbackScore { get; set; }
        }

        public class Itemlocation
        {
            public string postalCode { get; set; }
            public string country { get; set; }
        }

        public class Category
        {
            public string categoryId { get; set; }
            public string categoryName { get; set; }
        }

        public class Shippingoption
        {
            public string shippingCostType { get; set; }
            public Shippingcost shippingCost { get; set; }
        }

        public class Shippingcost
        {
            public string value { get; set; }
            public string currency { get; set; }
        }

    }
}
