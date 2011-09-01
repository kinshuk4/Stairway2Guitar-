using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GuitarK2.Dao;
using GuitarK2.Data;

namespace GuitarK2.PractiseList
{
    public class AllPractiseList
    {
        IDictionary<string, List<GeneralScalePractise>> scalePractiseList;
        public IDictionary<string, List<GeneralScalePractise>> ScalePractiseListPerType { get { return scalePractiseList; } }
        public List<String> AllScalePracTypes { get; set; }
        public AllPractiseList()
        {
            scalePractiseList = new Dictionary<string, List<GeneralScalePractise>>();
            initializeScalePrac();
        }

        private void initializeScalePrac()
        {
            ScalePractiseDao scalePractiseDao = new ScalePractiseDao();
            
            AllScalePracTypes = scalePractiseDao.getAllScalePractiseType();

            foreach (string pracType in AllScalePracTypes)
            {
                List<GeneralScalePractise> value = scalePractiseDao.getScalePractiseForType(pracType);
                scalePractiseList.Add(pracType,value);
            }
//            foreach (var generalScalePractise in listScalePrac)
//            {
//                String key = generalScalePractise.PractiseType;
//                if(scalePractiseList.ContainsKey(key))
//                    scalePractiseList[key].Add(generalScalePractise);
//                else
//                {
//                    List<GeneralScalePractise> pracWiseList = new List<GeneralScalePractise>();
//                    pracWiseList.Add(generalScalePractise);
//                    scalePractiseList.Add(key, pracWiseList);
//                }
//            }
            
        }
    }
}
