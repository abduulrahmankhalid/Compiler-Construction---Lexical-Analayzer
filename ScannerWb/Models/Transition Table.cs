using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScannerWb.Models
{
    public class Transition_Table
    {

        public static string[,] Transiton_Table = new string[200, 200];

        public static  int rowLength = Transiton_Table.GetLength(0);

        public static int colLength = Transiton_Table.GetLength(1);


        public static void TransitionTable_Fill()
        {
            for (int i = 0; i < Transiton_Table.GetLength(0); i++)
            {
                for (int j = 0; j < Transiton_Table.GetLength(1); j++)
                {
                    Transiton_Table[i, j] = "0";
                }
            }
            for (int i = 0; i < Transiton_Table.GetLength(0); i++)
            {
                Transiton_Table[i, 0] = i.ToString();
            }


            Transiton_Table[0, 1] = "C";
            Transiton_Table[0, 2] = "D";
            Transiton_Table[0, 3] = "I";
            Transiton_Table[0, 4] = "E";
            Transiton_Table[0, 5] = "S";
            Transiton_Table[0, 6] = "N";
            Transiton_Table[0, 7] = "L";
            Transiton_Table[0, 8] = "R";
            Transiton_Table[0, 9] = "P";
            Transiton_Table[0, 10] = "U";
            Transiton_Table[0, 11] = "a";
            Transiton_Table[0, 12] = "t";
            Transiton_Table[0, 13] = "e";
            Transiton_Table[0, 14] = "g";
            Transiton_Table[0, 15] = "o";
            Transiton_Table[0, 16] = "r";
            Transiton_Table[0, 17] = "y";
            Transiton_Table[0, 18] = "i";
            Transiton_Table[0, 19] = "v";
            Transiton_Table[0, 20] = "f";
            Transiton_Table[0, 21] = "l";
            Transiton_Table[0, 22] = "s";
            Transiton_Table[0, 23] = "p";
            Transiton_Table[0, 24] = "n";
            Transiton_Table[0, 25] = "c";
            Transiton_Table[0, 26] = "m";
            Transiton_Table[0, 27] = "h";
            Transiton_Table[0, 28] = "w";
            Transiton_Table[0, 29] = "u";
            Transiton_Table[0, 30] = "d";
            Transiton_Table[0, 31] = "k";
            Transiton_Table[0, 32] = "+";
            Transiton_Table[0, 33] = "-";
            Transiton_Table[0, 34] = "*";
            Transiton_Table[0, 35] = "/";
            Transiton_Table[0, 36] = "&";
            Transiton_Table[0, 37] = "|";
            Transiton_Table[0, 38] = "~";
            Transiton_Table[0, 39] = "=";
            Transiton_Table[0, 40] = "<";
            Transiton_Table[0, 41] = ">";
            Transiton_Table[0, 42] = "!";
            Transiton_Table[0, 43] = ".";
            Transiton_Table[0, 44] = "{";
            Transiton_Table[0, 45] = "}";
            Transiton_Table[0, 46] = "[";
            Transiton_Table[0, 47] = "]";
            Transiton_Table[0, 48] = "\"";
            Transiton_Table[0, 49] = "'";
            Transiton_Table[1, 1] = "59";
            Transiton_Table[1, 2] = "33";
            Transiton_Table[1, 3] = "90";
            Transiton_Table[1, 4] = "3";
            Transiton_Table[1, 5] = "120";
            Transiton_Table[1, 6] = "28";
            Transiton_Table[1, 7] = "20";
            Transiton_Table[1, 8] = "99";
            Transiton_Table[1, 9] = "12";
            Transiton_Table[1, 10] = "53";
            Transiton_Table[1, 12] = "39";
            Transiton_Table[1, 22] = "138";
            Transiton_Table[1, 32] = "177";
            Transiton_Table[1, 33] = "179";
            Transiton_Table[1, 34] = "182";
            Transiton_Table[1, 35] = "185";
            Transiton_Table[1, 36] = "187";
            Transiton_Table[1, 37] = "190";
            Transiton_Table[1, 38] = "193";
            Transiton_Table[1, 39] = "161";
            Transiton_Table[1, 40] = "170";
            Transiton_Table[1, 41] = "167";
            Transiton_Table[1, 42] = "164";
            Transiton_Table[1, 43] = "159";
            Transiton_Table[1, 44] = "155";
            Transiton_Table[1, 45] = "157";
            Transiton_Table[1, 46] = "151";
            Transiton_Table[1, 47] = "153";
            Transiton_Table[1, 48] = "195";
            Transiton_Table[1, 49] = "197";

            Transiton_Table[3, 21] = "5";
            Transiton_Table[3, 24] = "9";

            Transiton_Table[5, 22] = "6";

            Transiton_Table[6, 13] = "7";

            Transiton_Table[9, 30] = "10";

            Transiton_Table[12, 16] = "13";

            Transiton_Table[13, 15] = "14";

            Transiton_Table[14, 14] = "15";

            Transiton_Table[15, 16] = "16";

            Transiton_Table[16, 11] = "17";

            Transiton_Table[17, 26] = "18";

            Transiton_Table[20, 15] = "21";

            Transiton_Table[21, 14] = "22";

            Transiton_Table[22, 18] = "23";

            Transiton_Table[23, 25] = "24";

            Transiton_Table[24, 11] = "25";

            Transiton_Table[25, 21] = "26";

            Transiton_Table[28, 15] = "29";

            Transiton_Table[29, 24] = "30";

            Transiton_Table[30, 13] = "31";

            Transiton_Table[33, 16] = "34";

            Transiton_Table[34, 18] = "35";

            Transiton_Table[35, 19] = "36";

            Transiton_Table[36, 13] = "37";

            Transiton_Table[39, 13] = "40";

            Transiton_Table[40, 16] = "41";

            Transiton_Table[41, 26] = "42";

            Transiton_Table[42, 18] = "43";

            Transiton_Table[43, 24] = "44";

            Transiton_Table[44, 11] = "45";

            Transiton_Table[45, 12] = "46";

            Transiton_Table[46, 13] = "47";

            Transiton_Table[47, 12] = "48";

            Transiton_Table[48, 27] = "49";

            Transiton_Table[49, 18] = "50";

            Transiton_Table[50, 22] = "51";

            Transiton_Table[53, 22] = "54";

            Transiton_Table[54, 18] = "55";

            Transiton_Table[55, 24] = "56";

            Transiton_Table[56, 14] = "57";

            Transiton_Table[59, 11] = "61";
            Transiton_Table[59, 15] = "78";
            Transiton_Table[59, 21] = "74";
            Transiton_Table[59, 27] = "69";


            Transiton_Table[61, 12] = "62";

            Transiton_Table[62, 13] = "63";

            Transiton_Table[63, 14] = "64";

            Transiton_Table[64, 15] = "65";

            Transiton_Table[65, 16] = "66";

            Transiton_Table[66, 17] = "67";

            Transiton_Table[69, 13] = "70";

            Transiton_Table[70, 25] = "71";

            Transiton_Table[71, 31] = "72";

            Transiton_Table[74, 15] = "75";

            Transiton_Table[75, 23] = "76";

            Transiton_Table[78, 24] = "79";

            Transiton_Table[79, 12] = "80";

            Transiton_Table[80, 18] = "81";

            Transiton_Table[81, 24] = "82";

            Transiton_Table[82, 29] = "83";

            Transiton_Table[83, 13] = "84";

            Transiton_Table[84, 28] = "85";

            Transiton_Table[85, 27] = "86";

            Transiton_Table[86, 13] = "87";

            Transiton_Table[87, 24] = "88";

            Transiton_Table[90, 20] = "97";
            Transiton_Table[90, 21] = "92";

            Transiton_Table[92, 11] = "93";

            Transiton_Table[93, 23] = "94";

            Transiton_Table[94, 20] = "95";

            Transiton_Table[99, 13] = "111";
            Transiton_Table[99, 15] = "101";

            Transiton_Table[101, 12] = "102";

            Transiton_Table[102, 11] = "103";

            Transiton_Table[103, 12] = "104";

            Transiton_Table[104, 13] = "105";

            Transiton_Table[105, 28] = "106";

            Transiton_Table[106, 27] = "107";

            Transiton_Table[107, 13] = "108";

            Transiton_Table[108, 24] = "109";

            Transiton_Table[111, 23] = "112";

            Transiton_Table[112, 21] = "113";

            Transiton_Table[113, 17] = "114";

            Transiton_Table[114, 28] = "115";

            Transiton_Table[115, 18] = "116";

            Transiton_Table[116, 12] = "117";

            Transiton_Table[117, 27] = "118";

            Transiton_Table[120, 13] = "128";
            Transiton_Table[120, 18] = "122";

            Transiton_Table[122, 21] = "123";

            Transiton_Table[123, 11] = "124";

            Transiton_Table[124, 23] = "125";

            Transiton_Table[125, 20] = "126";

            Transiton_Table[128, 15] = "135";
            Transiton_Table[128, 16] = "130";

            Transiton_Table[130, 18] = "131";

            Transiton_Table[131, 13] = "132";

            Transiton_Table[132, 22] = "133";

            Transiton_Table[135, 23] = "136";

            Transiton_Table[138, 18] = "139";

            Transiton_Table[139, 12] = "140";

            Transiton_Table[140, 29] = "141";

            Transiton_Table[141, 11] = "142";

            Transiton_Table[142, 12] = "143";

            Transiton_Table[143, 18] = "144";

            Transiton_Table[144, 15] = "145";

            Transiton_Table[145, 24] = "146";

            Transiton_Table[146, 15] = "147";

            Transiton_Table[147, 20] = "148";

            Transiton_Table[161, 39] = "162";

            Transiton_Table[164, 39] = "165";

            Transiton_Table[167, 39] = "168";

            Transiton_Table[170, 34] = "174";
            Transiton_Table[170, 39] = "172";

            Transiton_Table[179, 33] = "180";

            Transiton_Table[182, 41] = "183";

            Transiton_Table[187, 36] = "188";

            Transiton_Table[190, 37] = "191";


        }

    }
}
