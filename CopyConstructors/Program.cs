using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructors
{
    class Program
    {
        class SalesRep
        {
            public int SalesRepID { get; set; }
            public string SalesRepAddress { get; set; }
            public string VisitingDoctor { get; set; }
            public string DoctorAddress { get; set; }

            public SalesRep(string pVisitingDoctor, string pDoctorAddress)
            {
                VisitingDoctor = pVisitingDoctor;
                DoctorAddress = pDoctorAddress;
            }

            //Copy Constructor
            public SalesRep(SalesRep pSalesRep, int pSalesRepID, string pSalesRepAddress)
            {
                SalesRepID = pSalesRepID;
                SalesRepAddress = pSalesRepAddress;
                VisitingDoctor = pSalesRep.VisitingDoctor;
                DoctorAddress = pSalesRep.DoctorAddress;
            }
        }

        static void Main(string[] args)
        {
            SalesRep DrA_Obj = new SalesRep("Doctor A", "Delhi");
            SalesRep DrB_Obj = new SalesRep("Doctor B", "Mumbai");
            SalesRep DrC_Obj = new SalesRep("Doctor C", "Bangalore");

            Dictionary<int, string> SalesRepDetails = new Dictionary<int, string>();
            SalesRepDetails.Add(10001, "Delhi");
            SalesRepDetails.Add(10002, "Mumbai");
            SalesRepDetails.Add(10003, "Delhi");
            SalesRepDetails.Add(10004, "Mumbai");
            SalesRepDetails.Add(10005, "Delhi");
            SalesRepDetails.Add(10006, "Delhi");
            SalesRepDetails.Add(10007, "Bangalore");
            SalesRepDetails.Add(10008, "Delhi");
            SalesRepDetails.Add(10009, "Bangalore");
            SalesRepDetails.Add(10010, "Mumbai");



            List<SalesRep> LstSalesRepObjects = new List<SalesRep>();

            SalesRep SalesRepObj;
            foreach (KeyValuePair<int, string> SingleSalesRepDetails in SalesRepDetails)
            {
                if (SingleSalesRepDetails.Value == "Delhi")
                {
                    SalesRepObj = new SalesRep(DrA_Obj, SingleSalesRepDetails.Key, SingleSalesRepDetails.Value);
                }
                else if (SingleSalesRepDetails.Value == "Mumbai")
                {
                    SalesRepObj = new SalesRep(DrB_Obj, SingleSalesRepDetails.Key, SingleSalesRepDetails.Value);
                }
                else
                //(SingleSalesRepDetails.Value == "Bangalore")
                {
                    SalesRepObj = new SalesRep(DrC_Obj, SingleSalesRepDetails.Key, SingleSalesRepDetails.Value);
                }
                LstSalesRepObjects.Add(SalesRepObj);
            }

            foreach (SalesRep SingleSalesRepObject in LstSalesRepObjects)
            {
                StringBuilder SbMessage = new StringBuilder();
                SbMessage.Append("Sales Rep with ID " + SingleSalesRepObject.SalesRepID + "   ");
                SbMessage.Append("Living in the address " + SingleSalesRepObject.SalesRepAddress + "   ");
                SbMessage.Append("Visiting the doctor " + SingleSalesRepObject.VisitingDoctor + "   ");
                SbMessage.Append("Who is living in " + SingleSalesRepObject.DoctorAddress + "   ");
                Console.WriteLine(SbMessage.ToString());
            }
            Console.ReadLine();
        

        }
    }
}
