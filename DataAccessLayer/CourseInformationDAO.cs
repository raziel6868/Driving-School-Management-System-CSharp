﻿using BusinessObjects;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class CourseInformationDAO : SingletonBase<CourseInformationDAO>
    {
        List<CourseInformation> list = new List<CourseInformation>();
        public CourseInformationDAO()
        {
            list.AddRange(new List<CourseInformation> {


                new CourseInformation
                {
                    CourseID = 1,
                    CourseNumber = "101",
                    CourseDescription = "Single Course with a beautiful view of the city.",
                    CourseMaxCapacity = 1,
                    CourseStatus = CourseStatus.Active,
                    CoursePricePerDate = 100.00m,
                    CourseTypeID = 1
                },
                new CourseInformation
                {
                    CourseID = 2,
                    CourseNumber = "102",
                    CourseDescription = "Double Course with garden access.",
                    CourseMaxCapacity = 2,
                    CourseStatus = CourseStatus.Active,
                    CoursePricePerDate = 150.00m,
                    CourseTypeID = 2
                },
                new CourseInformation
                {
                    CourseID = 3,
                    CourseNumber = "103",
                    CourseDescription = "Suite with a private balcony.",
                    CourseMaxCapacity = 4,
                    CourseStatus = CourseStatus.Active,
                    CoursePricePerDate = 250.00m,
                    CourseTypeID = 3
                },
                new CourseInformation
                {
                    CourseID = 4,
                    CourseNumber = "104",
                    CourseDescription = "Economy single Course.",
                    CourseMaxCapacity = 1,
                    CourseStatus = CourseStatus.Active,
                    CoursePricePerDate = 80.00m,
                    CourseTypeID = 1
                },
                new CourseInformation
                {
                    CourseID = 5,
                    CourseNumber = "105",
                    CourseDescription = "Luxury double Course with ocean view.",
                    CourseMaxCapacity = 2,
                    CourseStatus = CourseStatus.Active,
                    CoursePricePerDate = 300.00m,
                    CourseTypeID = 2
                },
                new CourseInformation
                {
                    CourseID = 6,
                    CourseNumber = "106",
                    CourseDescription = "Family Course with kitchenette.",
                    CourseMaxCapacity = 5,
                    CourseStatus = CourseStatus.Active,
                    CoursePricePerDate = 200.00m,
                    CourseTypeID = 4
                },
                new CourseInformation
                {
                    CourseID = 7,
                    CourseNumber = "107",
                    CourseDescription = "Single Course with a queen-sized bed.",
                    CourseMaxCapacity = 1,
                    CourseStatus = CourseStatus.Active,
                    CoursePricePerDate = 120.00m,
                    CourseTypeID = 1
                },
                new CourseInformation
                {
                    CourseID = 8,
                    CourseNumber = "108",
                    CourseDescription = "Double Course with two single beds.",
                    CourseMaxCapacity = 2,
                    CourseStatus = CourseStatus.Active,
                    CoursePricePerDate = 130.00m,
                    CourseTypeID = 2
                },
                new CourseInformation
                {
                    CourseID = 9,
                    CourseNumber = "109",
                    CourseDescription = "Single Course with workspace.",
                    CourseMaxCapacity = 1,
                    CourseStatus = CourseStatus.Active,
                    CoursePricePerDate = 110.00m,
                    CourseTypeID = 1
                },
                new CourseInformation
                {
                    CourseID = 10,
                    CourseNumber = "110",
                    CourseDescription = "Deluxe suite with two bedCourses.",
                    CourseMaxCapacity = 6,
                    CourseStatus = CourseStatus.Active,
                    CoursePricePerDate = 350.00m,
                    CourseTypeID = 3
                } }

               );
        }

        public List<CourseInformation> GetCourseInformations()
        {


            return list;
        }
        public void SaveCourseInformation(CourseInformation r)
        {
            list.Add(r);
        }

        public void UpdateCourseInformation(CourseInformation r)
        {
            foreach (var current in list.ToList())
            {
                if (current.CourseID == r.CourseID)
                {
                    current.CourseDescription = r.CourseDescription;
                    current.CoursePricePerDate = r.CoursePricePerDate;
                    current.CourseTypeID = r.CourseTypeID;
                    current.CourseNumber = r.CourseNumber;
                    current.CourseDescription = r.CourseDescription;
                    current.CourseMaxCapacity = r.CourseMaxCapacity;
                    current.CourseStatus = r.CourseStatus;
                }
            }
        }

        public void DeleteCourseInformation(CourseInformation r)
        {
            foreach (var current in list.ToList())
            {
                if (current.CourseID == r.CourseID)
                {
                    list.Remove(current);
                }
            }
        }

        public CourseInformation GetCourseInformationById(int id)
        {
            foreach (var current in list.ToList())
            {
                if (current.CourseID == id)
                {
                    return current;
                }
            }
            return null;
        }

        public int GetNewId()
        {
            return list.Max(x => x.CourseID) + 1;
        }

    
    }
}
   

