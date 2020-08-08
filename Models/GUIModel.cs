using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskReceiverMVC.Models
{
    public class GUIModel
    {
        public GUIModel(string userName, string userName1, string userName2, string userName3, 
            string passWord, string firstName, string lastName, 
            double commission, int totalCredit, int maxCreditLimit, int maxPerBet,
            int maxBetMatch, int maxPerBetSub, int maxBetMatchSub, int maxBetNumberGame,
            int accountNumber, DropUser dropDownListUser, DropWeb dropDownListWed)
        {
            DropDownListUser = dropDownListUser;
            DropDownListWed = dropDownListWed;
            AccountNumber = accountNumber;
            UserName = userName;
            UserName1 = userName1;
            UserName2 = userName2;
            UserName3 = userName3;
            PassWord = passWord;
            FirstName = firstName;
            LastName = lastName;
            Commission = commission;
            TotalCredit = totalCredit;
            MaxCreditLimit = maxCreditLimit;
            MaxPerBet = maxPerBet;
            MaxBetMatch = maxBetMatch;
            MaxPerBetSub = maxPerBetSub;
            MaxBetMatchSub = maxBetMatchSub;
            MaxBetNumberGame = maxBetNumberGame;
        }

        public int AccountNumber { get; set; }
        public string UserName { get; set; }
        public string UserName1 { get; set; }
        public string UserName2 { get; set; }
        public string UserName3 { get; set; }
        public string PassWord { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }
        public int TotalCredit { get; set; }
        public int MaxCreditLimit { get; set; }
        public int MaxPerBet { get; set; }
        public int MaxBetMatch { get; set; }
        public int MaxPerBetSub { get; set; }
        public int MaxBetMatchSub { get; set; }
        public int MaxBetNumberGame { get; set; }
        public DropUser DropDownListUser { get; set; }
        public DropWeb DropDownListWed { get; set; }
        public bool IsChecked { get; set; }
    }
    public enum DropWeb
    {
        VIVA88, SBOBET,
        SV388, S128,
        WBET, OK368,
        HK1101, LD789,
        LASVEGAS, SGD,
        [Description("3IN1")]
        ThreeSome
    }
    public enum DropUser
    {
        Player1,
        Player2,
        Player3
    }


}