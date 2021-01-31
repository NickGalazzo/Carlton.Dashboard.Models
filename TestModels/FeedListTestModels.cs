using System;
using System.Collections.Generic;
using System.Linq;


namespace Carlton.Dashboard.Models.TestModels
{
    public static class FeedListTestModels
    {
        public static FeedItems DefaultFeedItemListModel()
        {
            const string TOOK_OUT_GARBAGE = "Took Out Garbage";
            var feedItems = new List<FeedItem>();
            var feedUser = new FeedUser("Nick", string.Empty);

         
            feedItems.Add(new FeedItem("Garbage", TOOK_OUT_GARBAGE, feedUser, DateTimeOffset.Now));

            feedItems.Add(new FeedItem("Garbage", TOOK_OUT_GARBAGE, feedUser, DateTimeOffset.Now.AddMinutes(-10)));

            feedItems.Add(new FeedItem("Groceries", "Purchahsed Groceries", feedUser, DateTimeOffset.Now.AddHours(-3)));

            feedItems.Add(new FeedItem("Groceries", "Purchahsed Groceries", feedUser, new DateTime(1989, 10, 9, 2, 7, 0, 0)));


            return new FeedItems(feedItems);
        }
    
        public static FeedItem DefaultFeedListItemModel()
        {
            return DefaultFeedItemListModel().Items.First();
        }

        public static FeedItem MomentsAgoFeedListItemModel()
        {
            return DefaultFeedItemListModel().Items.First();
        }
        public static FeedItem TenMinutesAgoFeedListItemModel()
        {
            return DefaultFeedItemListModel().Items.ElementAt(1);
        }

        public static FeedItem ThreeHoursAgoFeedListItemModel()
        {
            return DefaultFeedItemListModel().Items.ElementAt(2);
        }

        public static FeedItem PreviousDateFeedListItemModel()
        {
            return DefaultFeedItemListModel().Items.ElementAt(3);
        }
    }
}
