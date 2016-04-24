using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_D_FangXiaoCheng_140368P
{
    class CreditCard
    {
        private string salutations, name, address,cardtype;
        private float salary, creditlimits;
        private bool occupied = false;
        private int contactno;
        //null constructor
        public CreditCard()
        { }
        //overloading constructors
        public CreditCard(string newcardtype,string newsalutation, string newname, float newsalary, string newaddress, bool newoccupied, float newcreditlimits)
        {
            cardtype = newcardtype;
            salutations = newsalutation;
            name = newname;
            salary = newsalary;
            address = newaddress;
            occupied = newoccupied;
            creditlimits = newcreditlimits;
        }

        public CreditCard(string newcardtype,string newsalutation, string newname, float newsalary, int newcontactno, string newaddress, bool newoccupied, float newcreditlimits)
        {
            cardtype = newcardtype;
            salutations = newsalutation;
            name = newname;
            salary = newsalary;
            contactno = newcontactno;
            address = newaddress;
            occupied = newoccupied;
            creditlimits = newcreditlimits;
        }
        //properties of getter and setter
        public string detailName
        {
            get { return name; }
            set { name = value; }
        }
        public string detailSalutation
        {
            get { return salutations; }
            set { salutations = value; }
        }
        public float detailSalary
        {
            get { return salary; }
            set { salary = value; }
        }
        public int detailContactNo
        {
            get { return contactno; }
            set { contactno = value; }
        }
        public string detailAddress
        {
            get { return address; }
            set { address = value; }
        }
        public bool detailOccupation
        {
            get { return occupied; }
            set { occupied = value; }
        }
        public float detailCreditLimits
        {
            get { return creditlimits; }
            set { creditlimits = value; }
        }
        public string detailCardType
        {
            get { return cardtype; }
            set { cardtype = value; }
        }
    }
}
