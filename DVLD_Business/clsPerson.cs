//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;
//using DVLD_DataAccess;
//using System.Data;
//using System.Data.SqlClient;
//using System.Dynamic;

//namespace DVLD_Business;

//public class clsPerson
//{
//    public enum enMode { AddMode = 0, UpdateMode =1 }
//    enMode Mode;
//    public int PersonId { set; get; }
//    public string FirstName { set; get; }
//    public string SecondName { set; get; }
//    public string ThirdName { set; get; }
//    public string LastName { set; get; }
//    public string FullName {
//        get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
//    }
//    public string NationalNo { set; get; }
//    public DateTime DateOfBirth { set; get; }
//    public short Gender { set; get; }
//    public string Address { set; get; }
//    public string Phone { set; get; }
//    public string Email { set; get; }
//    public int NationalCountryId { set; get; }

//    public clsCountry CountryInfo;

//    private string _ImagePath;
//    public string ImagePath
//    {
//        get { return _ImagePath; }
//        set { _ImagePath = value; }
//    }

//    public clsPerson()

//    {
//        this.PersonId = -1;
//        this.FirstName = "";
//        this.SecondName = "";
//        this.ThirdName = "";
//        this.LastName = "";
//        this.DateOfBirth = DateTime.Now;
//        this.Address = "";
//        this.Phone = "";
//        this.Email = "";
//        this.NationalCountryId = -1;
//        this.ImagePath = "";

//        Mode = enMode.AddMode;
//    }
//    public clsPerson(int PersonId,string FirstName, string SecondName, string ThirdName,
//       string LastName, DateTime DateOfBirth,string NationalNo, short Gender,string Address,string Phone,string Email, 
//       int NationalCountryId, string ImagePath)
       
       
//    {

//        this.PersonId = PersonId;
//        this.FirstName = FirstName;
//        this.SecondName = SecondName;
//        this.ThirdName = ThirdName;
//        this.LastName = LastName;
//        this.NationalNo = NationalNo;
//        this.DateOfBirth = DateOfBirth;
//        this.Gender = Gender;
//        this.Address = Address;
//        this.Phone = Phone;
//        this.Email = Email;
//        this.NationalCountryId = NationalCountryId;
//        this.ImagePath = ImagePath;
//        //this.CountryInfo = ;//clsCountry.Find(NationalCountryID);
//        Mode = enMode.UpdateMode;
//    }

//    //public GetPersonInfoById(int personId, ref String FirstName, ref string SecondName,ref string ThirdName,
//    //   ref string LastName,ref DateTime DateOfBirth, ref string NationalNo,ref short Gender,ref string Address, ref string Phone, ref string Email,
//    //   ref int NationalCountryId, ref string ImagePath)
//    //{
//    //    SqlConnection connection = new SqlConnection(dbConnection.ConnectionString);
//    //}
//    public static DataTable LisAllPeople()
//    {
//        return GetAllPeople();
//    }
//}
