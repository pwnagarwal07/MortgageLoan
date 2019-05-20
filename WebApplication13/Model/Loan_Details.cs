using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class Loan_Details
    {
        int L_Id;
        int Requested_For;
        int Assinged_To;
        int Requested_Amount;
        string RequestStatus;
        string Assessment;
        string Loan_Description;
        string Email_Id;

        public Loan_Details(int l_Id, int requested_For, int assinged_To, int requested_Amount, string requestStatus, string assessment, string loan_Description, string email_Id)
        {
            L_Id = l_Id;
            Requested_For = requested_For;
            Assinged_To = assinged_To;
            Requested_Amount = requested_Amount;
            RequestStatus = requestStatus;
            Assessment = assessment;
            Loan_Description = loan_Description;
            Email_Id = email_Id;
        }

        public int L_Id1 { get { return L_Id; } set { L_Id = value; } }
        public int Requested_For1
        {
            get
            {
                return Requested_For;
            }
            set { Requested_For = value; }
        }
        public int Assinged_To1
        {
            get
            {
                return Assinged_To;
            }
            set { Assinged_To = value; }
        }
        public int Requested_Amount1
        {
            get
            {
                return Requested_Amount;
            }
            set { Requested_Amount = value; }
        }
        public string RequestStatus1
        {
            get
            {
                return RequestStatus;
            }
            set { RequestStatus = value; }
        }
        public string Assessment1
        {
            get
            {
                return Assessment;
            }
            set { Assessment = value; }
        }
        public string Loan_Description1
        {
            get
            {
                return Loan_Description;
            }
            set { Loan_Description = value; }
        }
        public string Email_Id1 { get { return Email_Id; } set { Email_Id = value; } }
    }
}