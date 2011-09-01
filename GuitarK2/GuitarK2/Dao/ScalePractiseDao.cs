using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using GuitarK2.Data;
using GuitarK2.Utils;

namespace GuitarK2.Dao
{
   public class ScalePractiseDao
    {
       private static string SQL_GetAllPractiseRoutine =
          "SELECT Routine, Practise_Type FROM ScalePractisePerType WHERE (Practise_Type IS NOT NULL) ";
        private static string SQL_GetAllPractiseType = "select Practise_Type FROM ScalePractisePerType WHERE Practise_Type is NOT NULL Group BY Practise_Type";
        private static string SQL_GetPractiseForType = "select Practise_Type, Routine from ScalePractisePerType WHERE Practise_Type is NOT NULL AND Practise_Type=@practiseType";

       public List<GeneralScalePractise> getAllPractiseRoutine()
       {
           OleDbCommand cmdMyQuery = new OleDbCommand(SQL_GetAllPractiseRoutine);
           DataTable dTable = DbUtils.SQLSelect(cmdMyQuery);

           List<GeneralScalePractise> scalePractiseList = getListPractiseFromTable(dTable);
           return scalePractiseList;
       }
        public List<String> getAllScalePractiseType()
        {
            OleDbCommand cmdMyQuery = new OleDbCommand(SQL_GetAllPractiseType);
            DataTable dTable = DbUtils.SQLSelect(cmdMyQuery);

            List<String> scalePractiseList = new List<String>();
            foreach (DataRow row_ in dTable.Rows)
            {
                scalePractiseList.Add((string)row_["Practise_Type"]);
            }
            return scalePractiseList;
        }

        public List<GeneralScalePractise> getScalePractiseForType(string practiseType)
        {
            OleDbCommand cmdMyQuery = new OleDbCommand(SQL_GetPractiseForType);
            cmdMyQuery.Parameters.AddWithValue("@practiseType",practiseType);
            DataTable dTable = DbUtils.SQLSelect(cmdMyQuery);

            List<GeneralScalePractise> scalePractiseList = getListPractiseFromTable(dTable);
            return scalePractiseList;
        }

       private List<GeneralScalePractise> getListPractiseFromTable(DataTable dTable)
       {
           List<GeneralScalePractise> scalePractiseList = new List<GeneralScalePractise>();
           foreach (DataRow row_ in dTable.Rows)
           {
               GeneralScalePractise _gsp = new GeneralScalePractise();
               _gsp.PractiseRoutine = (string)row_["Routine"];
               _gsp.PractiseType = (string)row_["Practise_Type"];
               scalePractiseList.Add(_gsp);
           }
           return scalePractiseList;
       }
    }
}
