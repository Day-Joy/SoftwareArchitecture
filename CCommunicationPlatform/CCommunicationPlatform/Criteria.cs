using System;
using System.Collections.Generic;
using System.Text;

namespace CCommunicationPlatform
{
    public interface Criteria
    {
        List<Course> MeetCriteria(List<Course> courses);
    }

    public class CriteriaCompulsory : Criteria
    {
        public List<Course> MeetCriteria(List<Course> courses)
        {
            List<Course> compulsories = new List<Course>();
            courses.ForEach(s => { if (s.getKind().Contains("compulsory")) compulsories.Add(s); });
            return compulsories;
        }
    }

    public class CriteriaOptional : Criteria
    {
        public List<Course> MeetCriteria(List<Course> courses)
        {
            List<Course> optionals = new List<Course>();
            courses.ForEach(s => { if (s.getKind().Contains("optional")) optionals.Add(s); });
            return optionals;
        }
    }

    public class CriteriaPublic : Criteria
    {
        public List<Course> MeetCriteria(List<Course> courses)
        {
            List<Course> publics = new List<Course>();
            courses.ForEach(s => { if (s.getKind().Contains("public")) publics.Add(s); });
            return publics;
        }
    }

    public class CriteriaSpecialized : Criteria
    {
        public List<Course> MeetCriteria(List<Course> courses)
        {
            List<Course> specializeds = new List<Course>();
            courses.ForEach(s => { if (s.getKind().Contains("specialized")) specializeds.Add(s); });
            return specializeds;
        }
    }


}
