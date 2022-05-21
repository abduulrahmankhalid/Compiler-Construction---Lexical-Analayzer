using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScannerWb.Models;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.IO;


namespace ScannerWb.Controllers
{
    public class HomeController : Controller
    {

        string input;

        string output;

        [HttpGet]
        public IActionResult Scanner_get()
        {
            Transition_Table.TransitionTable_Fill();
            Dictionaries.Dic_Fill();

            ViewBag.Input = "";

            return View();
        }



        [HttpPost]
        public IActionResult Scanner_get(string input, IFormFile ScanFile)
        {            

            if (ScanFile != null)
            {
                string FilePath = UploadFile(ScanFile);

                string Input = System.IO.File.ReadAllText("Upload/"+FilePath);

                ViewBag.Input = Input;

                ViewBag.ErrorCount = ScanText(Input);

                return View();
            }

            ViewBag.ErrorCount = ScanText(input);

            ViewBag.Input = input;
            
            return View();
        }

        public string UploadFile(IFormFile ScanFile)
        {
            string path = "";

            bool iscopied = false;

            FileStream filestream;

            try
            {
                if (ScanFile.Length > 0)
                {
                    string filename = Path.GetFileName(ScanFile.FileName);

                    path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "Upload"));

                    using ( filestream = new FileStream(Path.Combine(path, filename), FileMode.Create))
                    {
                         ScanFile.CopyToAsync(filestream);
                    }

                    iscopied = true;
                    return filename;
                }
                else
                {
                    iscopied = false;
                }
            }
            catch (Exception)
            {
                throw;
            }            

            return null;
        }
        
        
        public static bool isDigit(string isDigit)
        {
            bool flag = false;
            int i = 0;

            foreach (var item in isDigit)
            {
                if (item >= '0' && item <= '9')
                    flag = true;
                else if (item == '\0')
                    continue;
                else
                {
                    flag = false;
                    return flag;
                }
            }
            return flag;
        } // check if it's digit 


        public static bool isIdentifier(string id)
        {

            char[] id_Check = id.ToCharArray();

            bool flag = false;
            if ((id_Check[0] >= 'a' && id_Check[0] <= 'z') || (id_Check[0] >= 'A' && id_Check[0] <= 'Z') || id_Check[0] == '_')
                flag = true;
            else
            {
                flag = false;
                return flag;
            }

            for (int i = 1; i < id_Check.Length - 1; i++)
            {
                if ((id_Check[i] >= '0' && id_Check[i] <= '9') || (id_Check[i] >= 'A' && id_Check[i] <= 'Z') || (id_Check[i] >= 'a' && id_Check[i] <= 'z'))
                    flag = true;

                else if (id_Check[i] == '\0')
                {
                    continue;
                }

                else
                {
                    flag = false;
                    return flag;
                }
            }

            return flag;
        } // check if it's identifier 


        public static int IndexOfChar(char ch)     // is  character in transition table ?
        {
            int flag = -1;

            for (int i = 1; i < Transition_Table.colLength; i++)
            {
                if (ch == Convert.ToChar(Transition_Table.Transiton_Table[0, i]))
                {
                    flag = 1;
                    return i;
                }
            }

            return flag;
        }


        public static int ScanText(string text)
        {
            //Stores String In CharArray

            char[] charArr = text.ToCharArray();



            int next_state = 1, x, errorCount = 0, temp = 0, j = 0, k = 0, z = 0;

            
            char[] Word = new char[charArr.Length];


            char[] Digit = new char[charArr.Length];


            char[] Comment = new char[text.Length];
            

            char next_char, curr_char;


            for (int i = 0; i < charArr.Length && temp < charArr.Length; i++)
            {

                temp = i; temp++;

                curr_char = charArr[i];

                Word[j] = curr_char;

                Digit[k] = curr_char;

                // Last Character ?

                if (i == charArr.Length - 1)
                {

                    if (curr_char == '\n' || curr_char == '\t' ||
                        curr_char == ' ' || curr_char == ';' ||
                        curr_char == '\r')
                    {
                        break;
                    }
                                        
                    else
                    {
                        if (IndexOfChar(curr_char) != -1) // letter in table (Word)
                        {
                            x = IndexOfChar(curr_char);  //col num

                            
                            try
                            {
                                next_state = Convert.ToInt32(Transition_Table.Transiton_Table[next_state, x]);

                            } catch(FormatException e)
                            {
                                if (e.Data == null)
                                {
                                    throw;
                                }
                                else
                                {
                                    next_state = 0;
                                }                                
                            } 
                            
                            if (Dictionaries.FinStat_Key_Token_Dic.ContainsKey(next_state))
                            {
                                string token_text = new string(Word);

                                Dictionaries.Saved_KeyWords.Add(next_state, token_text);
                                next_state = 1;
                            }
                            else
                            {
                                string token_text = new string(Word);

                                if (isIdentifier(token_text))
                                {
                                    Dictionaries.Saved_KeyWords.Add(198, token_text);
                                }

                                if (isDigit(token_text))
                                {
                                    Dictionaries.Saved_KeyWords.Add(199, token_text);
                                }                                
                            }


                        }
                        else
                        {
                            string token_text = new string(Word);

                            if (isIdentifier(token_text))
                            {
                                Dictionaries.Saved_KeyWords.Add(198, token_text);
                            }

                            else
                            {
                                string token_text_num = new string(Digit);

                                if (isDigit(token_text_num))
                                {
                                    Dictionaries.Saved_KeyWords.Add(199, token_text_num);
                                }
                            }

                        }
                    }


                }

                else
                {

                    // Delimitar ?

                    if (curr_char == '\n' || curr_char == '\t' ||
                        curr_char == ' ' || curr_char == ';' ||
                        curr_char == '\r')
                    {
                        next_state = 1;
                        Array.Clear(Word, 0, Word.Length);
                        j = 0;
                        continue;
                    }

                    next_char = charArr[temp];


                    //Multi Comment

                    if (curr_char == '<' && next_char == '*')
                    {
                        for (i = 2, z = 0; i < text.Length; i++, z++)
                        {

                            if (text[i] == '*' && text[i + 1] == '>')
                            {

                                string token_text = new string(Comment);

                                Dictionaries.Saved_KeyWords.Add(200, token_text);
                            }

                            Comment[z] += text[i];


                        }
                    }


                    //Single Comment

                    if (curr_char == '-' && next_char == '-')
                    {
                        for (i = 2, z = 0; i < text.Length; i++, z++)
                        {
                            if (text[i] == '\n'  || (i == text.Length-1))
                            {

                                Comment[z] += text[i];

                                string token_text = new string(Comment);

                                Dictionaries.Saved_KeyWords.Add(201, token_text);
                            }

                            Comment[z] += text[i];

                        }
                    }


                    // if not special continue like above
                    
                    if (IndexOfChar(curr_char) != -1)
                    {
                        
                        if (next_char == '\n' || next_char == '\t' ||
                            next_char == ' ' || next_char == ';' ||
                            next_char == '\r')
                        {

                            x = IndexOfChar(curr_char);

                            try
                            { 

                                next_state = Convert.ToInt32(Transition_Table.Transiton_Table[next_state, x]);

                            } catch (FormatException e)
                            {
                                if (e.Data == null)
                                {
                                    throw;
                                }
                                else
                                {
                                    next_state = 0;
                                }
                            }

                            
                            if (Dictionaries.FinStat_Key_Token_Dic.ContainsKey(next_state))
                            {

                                    string token_text = new string(Word);

                                    Dictionaries.Saved_KeyWords.Add(next_state, token_text);

                                    next_state = 1;
                            }
                                
                            else
                            {

                                string token_text = new string(Word);

                                if (isIdentifier(token_text))
                                {
                                    Dictionaries.Saved_KeyWords.Add(198, token_text);
                                }

                                next_state = 1;
                            }
                        }

                        
                        else if (next_state == 0)
                        {
                            next_state = 1;                            
                        }
                        
                        else
                        {
                            x = IndexOfChar(curr_char);
                            next_state = Convert.ToInt32( Transition_Table.Transiton_Table[next_state, x]);
                        }
                    }

                        else if (next_char == '\n' || next_char == '\t' ||
                                next_char == ' ' || next_char == ';' ||
                                next_char == '\r')
                         {

                                string token_text = new string(Word);

                                if (isIdentifier(token_text))
                                {
                                    Dictionaries.Saved_KeyWords.Add(198, token_text);
                                }
                                else
                                {
                                    string token_text_num = new string(Digit);

                                    if (isDigit(token_text_num))
                                    {
                                        Dictionaries.Saved_KeyWords.Add(199, token_text_num);
                                    }
                                }
                         }

                    // Current Char Digit
                    else
                    {
                        k++;
                        next_state = 1;

                        // Wrong word like 1x

                        if (
                            (curr_char >= '0' && curr_char <= '9') && 
                            
                            ((next_char >= 'a' && next_char <= 'z') ||

                            (next_char >= 'A' && next_char <= 'Z') ||
                            next_char == '_')
                            )
                            errorCount++;
                    }
                }

                j++;
            }
            return errorCount;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
