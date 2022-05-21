using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScannerWb.Models
{
    public class Dictionaries
    {
        public static Dictionary<int, List<String>> FinStat_Key_Token_Dic = new Dictionary<int, List<String>>();

        public static Dictionary<int, string> Saved_KeyWords = new Dictionary<int, string>();


        public static void Dic_Fill()
        {

            //create list one and store values
            List<string> valSet1 = new List<string>();
            valSet1.Add("Category");
            valSet1.Add("Class");
            // create list two and store values
            List<String> valSet2 = new List<String>();
            valSet2.Add("Drive");
            valSet2.Add("Inheritance");
            // create list three and store values
            List<String> valSet3 = new List<String>();
            valSet3.Add("If");
            valSet3.Add("Condition");
            // create list four and store values
            List<String> valSet4 = new List<String>();
            valSet4.Add("Else");
            valSet4.Add("Condition");


            List<String> valSet5 = new List<String>();
            valSet5.Add("Ilap");
            valSet5.Add("Integer");



            List<String> valSet6 = new List<String>();
            valSet6.Add("Silap");
            valSet6.Add("SInteger");


            List<String> valSet7 = new List<String>();
            valSet7.Add("Clop");
            valSet7.Add("Character");


            List<String> valSet8 = new List<String>();
            valSet8.Add("Series");
            valSet8.Add("String");


            List<String> valSet9 = new List<String>();
            valSet9.Add("Ilapf");
            valSet9.Add("Float");


            List<String> valSet10 = new List<String>();
            valSet10.Add("Silapf");
            valSet10.Add("SFloat");


            List<String> valSet11 = new List<String>();
            valSet11.Add("None");
            valSet11.Add("Void");


            List<String> valSet12 = new List<String>();
            valSet12.Add("Logical");
            valSet12.Add("Boolean");


            List<String> valSet13 = new List<String>();
            valSet13.Add("terminatethis");
            valSet13.Add("Break");


            List<String> valSet14 = new List<String>();
            valSet14.Add("Rotatewhen");
            valSet14.Add("Loop");


            List<String> valSet15 = new List<String>();
            valSet15.Add("Continuewhen");
            valSet15.Add("Loop");


            List<String> valSet16 = new List<String>();
            valSet16.Add("Replywith");
            valSet16.Add("Return");


            List<String> valSet17 = new List<String>();
            valSet17.Add("Seop");
            valSet17.Add("Struct");


            List<String> valSet18 = new List<String>();
            valSet18.Add("Check");
            valSet18.Add("Switch");


            List<String> valSet19 = new List<String>();
            valSet19.Add("situationof");
            valSet19.Add("Switch");


            List<String> valSet20 = new List<String>();
            valSet20.Add("Program");
            valSet20.Add("Stat Statement");


            List<String> valSet21 = new List<String>();
            valSet21.Add("End");
            valSet21.Add("End Statement");


            List<String> valSet22 = new List<String>();
            valSet22.Add("Using");
            valSet22.Add("Inclusion");


            List<String> valSet23 = new List<String>();
            valSet23.Add("+");
            valSet23.Add("Arithmetic Operation");


            List<String> valSet24 = new List<String>();
            valSet24.Add("-");
            valSet24.Add("Arithmetic Operation");


            List<String> valSet25 = new List<String>();
            valSet25.Add("*");
            valSet25.Add("Arithmetic Operation");


            List<String> valSet26 = new List<String>();
            valSet26.Add("/");
            valSet26.Add("Arithmetic Operation");


            List<String> valSet27 = new List<String>();
            valSet27.Add("&&");
            valSet27.Add("Logic Operators");


            List<String> valSet28 = new List<String>();
            valSet28.Add("||");
            valSet28.Add("Logic Operators");


            List<String> valSet29 = new List<String>();
            valSet29.Add("~");
            valSet29.Add("Logic Operators");


            List<String> valSet30 = new List<String>();
            valSet30.Add("==");
            valSet30.Add("relational Operators");


            List<String> valSet31 = new List<String>();
            valSet31.Add("<");
            valSet31.Add("relational Operators");


            List<String> valSet32 = new List<String>();
            valSet32.Add(">");
            valSet32.Add("relational Operators");


            List<String> valSet33 = new List<String>();
            valSet33.Add("!=");
            valSet33.Add("relational Operators");


            List<String> valSet34 = new List<String>();
            valSet34.Add("<=");
            valSet34.Add("relational Operators");


            List<String> valSet35 = new List<String>();
            valSet35.Add(">=");
            valSet35.Add("relational Operators");


            List<String> valSet36 = new List<String>();
            valSet36.Add("=");
            valSet36.Add("Assignment Operator");


            List<String> valSet37 = new List<String>();
            valSet37.Add("{");
            valSet37.Add("Braces");


            List<String> valSet38 = new List<String>();
            valSet38.Add("}");
            valSet38.Add("Braces");


            List<String> valSet39 = new List<String>();
            valSet39.Add("[");
            valSet39.Add("Braces");


            List<String> valSet40 = new List<String>();
            valSet40.Add("]");
            valSet40.Add("Braces");


            List<String> valSet41 = new List<String>();
            valSet41.Add("\"");
            valSet41.Add("QuotationMark");



            List<String> valSet42 = new List<String>();
            valSet42.Add("'");
            valSet42.Add("QuotationMark");


            List<String> valSet43 = new List<String>();
            valSet43.Add("--");
            valSet43.Add("Single Comment");


            List<String> valSet44 = new List<String>();
            valSet44.Add("<*");
            valSet44.Add("Start Comment");


            List<String> valSet45 = new List<String>();
            valSet45.Add("*>");
            valSet45.Add("End Comment");

            List<String> valSet46 = new List<String>();
            valSet46.Add("");
            valSet46.Add("Identifier");

            List<String> valSet47 = new List<String>();
            valSet47.Add("");
            valSet47.Add("Constant");

            List<String> valSet48 = new List<String>();
            valSet48.Add("");
            valSet48.Add("Multi Comment");

            List<String> valSet49 = new List<String>();
            valSet49.Add("");
            valSet49.Add("Comment");

            //add values into map

            FinStat_Key_Token_Dic.Add(7, valSet4);

            FinStat_Key_Token_Dic.Add(10, valSet21);

            FinStat_Key_Token_Dic.Add(18, valSet20);

            FinStat_Key_Token_Dic.Add(26, valSet12);

            FinStat_Key_Token_Dic.Add(37, valSet2);

            FinStat_Key_Token_Dic.Add(51, valSet13);

            FinStat_Key_Token_Dic.Add(57, valSet22);

            FinStat_Key_Token_Dic.Add(67, valSet1);

            FinStat_Key_Token_Dic.Add(72, valSet18);

            FinStat_Key_Token_Dic.Add(76, valSet7);

            FinStat_Key_Token_Dic.Add(88, valSet15);

            FinStat_Key_Token_Dic.Add(94, valSet5);

            FinStat_Key_Token_Dic.Add(95, valSet9);

            FinStat_Key_Token_Dic.Add(97, valSet3);

            FinStat_Key_Token_Dic.Add(109, valSet14);

            FinStat_Key_Token_Dic.Add(118, valSet16);

            FinStat_Key_Token_Dic.Add(125, valSet6);

            FinStat_Key_Token_Dic.Add(126, valSet10);

            FinStat_Key_Token_Dic.Add(131, valSet11);

            FinStat_Key_Token_Dic.Add(133, valSet8);

            FinStat_Key_Token_Dic.Add(136, valSet17);            

            FinStat_Key_Token_Dic.Add(148, valSet19);
                       
            FinStat_Key_Token_Dic.Add(151, valSet39);

            FinStat_Key_Token_Dic.Add(153, valSet40);

            FinStat_Key_Token_Dic.Add(155, valSet37);

            FinStat_Key_Token_Dic.Add(157, valSet38);

            FinStat_Key_Token_Dic.Add(161, valSet36);

            FinStat_Key_Token_Dic.Add(162, valSet30);

            FinStat_Key_Token_Dic.Add(165, valSet33);

            FinStat_Key_Token_Dic.Add(167, valSet32);

            FinStat_Key_Token_Dic.Add(168, valSet35);

            FinStat_Key_Token_Dic.Add(170, valSet31);

            FinStat_Key_Token_Dic.Add(172, valSet34);

            FinStat_Key_Token_Dic.Add(174, valSet44);

            FinStat_Key_Token_Dic.Add(177, valSet23);

            FinStat_Key_Token_Dic.Add(179, valSet24);

            FinStat_Key_Token_Dic.Add(180, valSet43);

            FinStat_Key_Token_Dic.Add(182, valSet25);

            FinStat_Key_Token_Dic.Add(183, valSet45);

            FinStat_Key_Token_Dic.Add(185, valSet26);

            FinStat_Key_Token_Dic.Add(188, valSet27);

            FinStat_Key_Token_Dic.Add(191, valSet28);

            FinStat_Key_Token_Dic.Add(193, valSet29);

            FinStat_Key_Token_Dic.Add(195, valSet41);

            FinStat_Key_Token_Dic.Add(197, valSet42);

            FinStat_Key_Token_Dic.Add(198, valSet46);

            FinStat_Key_Token_Dic.Add(199, valSet47);

            FinStat_Key_Token_Dic.Add(200, valSet48);

            FinStat_Key_Token_Dic.Add(201, valSet49);

        }

    }
}
