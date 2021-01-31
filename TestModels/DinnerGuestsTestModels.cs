using System.Collections.Generic;

namespace Carlton.Dashboard.Models.TestModels
{
    public static class DinnerGuestsTestModels
    {
        private static readonly IList<DinnerGuestReason> SampleReasons = new List<DinnerGuestReason>
                {
                    new DinnerGuestReason(1, "Japan School"),
                    new DinnerGuestReason(2, "Out With Friends")
                };


        public static DinnerGuests DefaultHomeForDinnerModel()
        {
            var dinnerGuests = new List<DinnerGuest>()
                {
                    DinnerGuest.CreateHomeForDinnerGuest(1, "Nick"),
                    DinnerGuest.CreateNotHomeForDinnerGuest(2, "Steve", SampleReasons[0])
                };


            var myDinnerGuestStatus = DinnerGuest.CreateHomeForDinnerGuest(1, "Nick");
            var dinnerGuestSelfModel = new DinnerGuestSelfStatus(myDinnerGuestStatus, SampleReasons);

            return new DinnerGuests(dinnerGuestSelfModel, dinnerGuests);
        }

        public static DinnerGuest DinnerGuestHomeModel()
        {
            return DinnerGuest.CreateHomeForDinnerGuest(1, "Nick");
        }

        public static DinnerGuest DinnerGuestNotHomeModel()
        {
            var reason = new DinnerGuestReason(1, "Japan School");
            return DinnerGuest.CreateNotHomeForDinnerGuest(2, "Steve", reason);
        }

        public static DinnerGuestSelfStatus DinnerGuestsSelfHomeModel()
        {
            return new DinnerGuestSelfStatus(DinnerGuestHomeModel(),
                new List<DinnerGuestReason>
                {
                    new DinnerGuestReason(1, "Japan School"),
                    new DinnerGuestReason(2, "Out With Friends")
                });
        }

        public static DinnerGuestSelfStatus DinnerGuestsSelfNotHomeModel()
        {
            return new DinnerGuestSelfStatus(DinnerGuestNotHomeModel(), SampleReasons);
        }
    }
}
