using System.Collections.Generic;

namespace Carlton.Dashboard.Models.TestModels
{
    public static class ApartmentStatusTestModels
    {
        public static ApartmentStatuses DefaultApartmentStatusModel()
        {
            var apartmentStatuses = new List<ApartmentStatus>
                     {
                            new ApartmentStatus(ApartmentStatusName.Garbage, ApartmentStatusValue.Complete),
                            new ApartmentStatus(ApartmentStatusName.Recycle, ApartmentStatusValue.Complete),
                            new ApartmentStatus(ApartmentStatusName.Groceries, ApartmentStatusValue.Complete),
                            new ApartmentStatus(ApartmentStatusName.Cleaning, ApartmentStatusValue.Complete),
                            new ApartmentStatus(ApartmentStatusName.Laundry, ApartmentStatusValue.Complete),
                            new ApartmentStatus(ApartmentStatusName.DryCleaning, ApartmentStatusValue.Incomplete)
                      };

            return new ApartmentStatuses(apartmentStatuses);
        }

        public static ApartmentStatus CompletedStatusModel()
        {
            return new ApartmentStatus(ApartmentStatusName.Garbage, ApartmentStatusValue.Complete);
        }

        public static ApartmentStatus InCompleteStatusModel()
        {
            return new ApartmentStatus(ApartmentStatusName.Garbage, ApartmentStatusValue.Incomplete);
        }

        public static ApartmentStatus GarbageModel()
        {
            return new ApartmentStatus(ApartmentStatusName.Garbage, ApartmentStatusValue.Complete);
        }

        public static ApartmentStatus RecycleModel()
        {
            return new ApartmentStatus(ApartmentStatusName.Recycle, ApartmentStatusValue.Complete);
        }

        public static ApartmentStatus GroceriesModel()
        {
            return new ApartmentStatus(ApartmentStatusName.Groceries, ApartmentStatusValue.Complete);
        }

        public static ApartmentStatus CleaningModel()
        {
            return new ApartmentStatus(ApartmentStatusName.Cleaning, ApartmentStatusValue.Complete);
        }

        public static ApartmentStatus LaundryModel()
        {
            return new ApartmentStatus(ApartmentStatusName.Laundry, ApartmentStatusValue.Complete);
        }

        public static ApartmentStatus DryCleaningModel()
        {
            return new ApartmentStatus(ApartmentStatusName.DryCleaning, ApartmentStatusValue.Complete);
        }
    }
}
