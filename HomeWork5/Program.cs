using System ;

namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //string[] letterA = { "a", "A" };
            //string[] letterB = { "b", "B" };

            ////Tester test
            //string input = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Vitae aliquam sunt laboriosam nobis. In facere ipsam incidunt eligendi laborum necessitatibus deleniti, culpa veritatis similique itaque possimus numquam repellendus est inventore temporibus, rerum, consequuntur adipisci! Veniam blanditiis rem cumque commodi laborum quas molestiae, odio iusto deleniti ut eligendi magni quis ex nisi perferendis obcaecati. Quam, est! Est commodi aut fugit alias deleniti molestias necessitatibus tempora iure expedita exercitationem. Vitae soluta in delectus accusamus molestias, iusto consectetur illum? Nemo culpa sapiente quisquam perspiciatis accusantium exercitationem labore, voluptatem sint ullam ab cumque quas blanditiis, dolore assumenda, officiis sunt voluptatum maxime illo! Ratione, quis.";

            ////Regexden isstifade ederek Coutun hesablanmasi
            //int ACount = letterA.Sum(letter => Regex.Matches(input, letter).Count);
            //int BCount = letterB.Sum(letter => Regex.Matches(input, letter).Count);

            ////A bolunsun B
            //Console.WriteLine($"A ededi B ededinden ne qeder coxdur: {ACount / BCount}");
            #endregion

            #region Task2
            //string[] spearator = { ", ", ".", " ", "!", "?", "/" };
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Zehmet olmasa bir metn daxil ediniz");
            //string input = Console.ReadLine();


            //string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            //string joined = string.Join("", strlist);

            //var inde = input.IndexOf('a');

            //if (inde % 2 == 0)
            //{
            //    Console.WriteLine($"Tek yerde dayanan simvol {'a'} simvoludu mellim");
            //}
            //else
            //{
            //    Console.WriteLine($"Tek yerde dayanan simvol {'a'} simvolu deyil ay mellim");
            //}
            #endregion


            #region Task3

            #endregion


            #region Task4
            //string[] spearator = { ", ", ".", " ", "!", "?", "/" };
            //Console.WriteLine("Zehmet olmasa bir metin daxil ediniz");

            //string input = Console.ReadLine();
            //string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            //string joined = string.Join("", strlist);

            //int count = 0;
            //char[] chrtotal1 = joined.ToCharArray();
            //for (int i = 0; i < chrtotal1.Length; i++)
            //{
            //    count++;
            //    if (chrtotal1[i] == 'a' && count % 2 == 0)
            //    {
            //        Console.WriteLine($"Cixacaq simvol: {chrtotal1[i]} ----> indeksi: {count}");
            //        Console.WriteLine("Cutdur");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Cut deyil");
            //    }
            //}
            #endregion


            #region Task5
            //string[] spearator = { ", ", ".", " ", "!", "?" };

            //string input = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Vitae aliquam sunt laboriosam nobis. In facere ipsam incidunt eligendi laborum necessitatibus deleniti, culpa veritatis similique itaque possimus numquam repellendus est inventore temporibus, rerum, consequuntur adipisci! Veniam blanditiis rem cumque commodi laborum quas molestiae, odio iusto deleniti ut eligendi magni quis ex nisi perferendis obcaecati. Quam, est! Est commodi aut fugit alias deleniti molestias necessitatibus tempora iure expedita exercitationem. Vitae soluta in delectus accusamus molestias, iusto consectetur illum? Nemo culpa sapiente quisquam perspiciatis accusantium exercitationem labore, voluptatem sint ullam ab cumque quas blanditiis, dolore assumenda, officiis sunt voluptatum maxime illo! Ratione, quis.";


            //string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            //string joined = string.Join("", strlist);

            //int count = 0;
            //char[] chrtotal1 = joined.ToCharArray();
            ////For-u arrayin uzunlugu yeni length den basladiriq ve i-- verib arxadan cixiriq 

            //for (int i = chrtotal1.Length - 1; i > 0; i--)
            //{
            //    count++;
            //    if (chrtotal1[i] == 'b' || chrtotal1[i] == 'a' || chrtotal1[i] == 'c')
            //    {
            //        Console.WriteLine($"Cixacaq simvol: {chrtotal1[i]} ----> indeksi: {count}");
            //        return;
            //    }

            //}


            #endregion

            #region Task6
            //string[] spearator = { ", ", ".", " ", "!", "?", "/" };
            //Console.WriteLine("Zehmet olmasa bir metin daxil ediniz");
            //string input = Console.ReadLine().ToLower();


            //string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            //string joined = string.Join("", strlist);
            //#region index metodlaridi buda ay mellim ehehehhe

            //int indexFirstA = joined.IndexOf("a");

            //char[] charArray = joined.ToCharArray();
            //Array.Reverse(charArray);
            //string reversedstr = new string(charArray);

            //int indexLastA = reversedstr.IndexOf("a");

            //Console.WriteLine("------------------------");
            //Console.Write("Netice: ");
            //if (indexFirstA == indexLastA)
            //{
            //    Console.WriteLine("beraberdir");
            //}
            //else
            //{
            //    Console.WriteLine("beraber deyil");
            //}
            #endregion

            #region Task7
            //Console.WriteLine("A herfinin B herfinden sonra gelmesi ve C herfininde her ikisinden sonra gelmesi CONSOL-u ");
            //string[] spearator = { ", ", ".", " ", "!", "?", "/" };
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Zehmet olmasa bir metn daxil ediniz");
            //string input = Console.ReadLine().ToLower();


            //string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            //string joined = string.Join("", strlist);
            ////string[] finders = { "abc" };
            //int lettersOfA = joined.IndexOf("a");
            //int lettersOfB = joined.IndexOf("b");
            //int lettersOfC = joined.IndexOf("c");

            //int firstMath = lettersOfB - lettersOfA;
            //int secondMath = lettersOfC - lettersOfB;

            ////char[] charedStr = joined.ToCharArray();

            ////for (int i = 0; i < charedStr.Length; i++)
            ////{
            ////    if (charedStr[i]=='a')
            ////    {
            ////        //Console.WriteLine($"A herfinin indeksi : {i}");

            ////    }
            ////    if (charedStr[i] == 'b')
            ////    {
            ////        //Console.WriteLine($"B herfinin  indeksi : {i}");
            ////    }
            ////    if (charedStr[i] == 'c')
            ////    {
            ////        //Console.WriteLine($"C herfinin indeksi : {i}");
            ////    }

            ////}


            //if (firstmath > 0 && secondmath > 0)
            //{
            //    console.writeline("a herfi b herfinden c herfide her ikisinden sonra gelir");

            //}
            //else
            //{
            //    console.writeline("sherte uygun netuce tapilmadi!!");
            //}

            #endregion

            #region Task8
            //string[] spearator = { ", ", ".", " ", "!", "?", "/" };
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Zehmet olmasa bir metn daxil ediniz");
            //string input = Console.ReadLine().ToLower();


            //string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            //string joined = string.Join("", strlist);

            //int lettersOfA = joined.IndexOf("a");
            //Console.WriteLine(new string(joined[lettersOfA + 1], 10));
            #endregion

            #region Task9
            /* 9) Verilmish metinde ilk 3 simvol, 
              son 3 simvolun tersine formasina beraberdirmi.?*/

            //string metn = "abc111cba";
            //string sub1 = metn.Substring(0, 3);
            //string sub2 = metn.Substring(metn.Length-3, 3);

            //char[] chars = sub2.ToCharArray();

            //Array.Reverse(chars);

            //string revSub2 = string.Join("", chars);


            //if (revSub2 == sub1)
            //{     
            //    Console.WriteLine("eynidir");
            //}
            //else
            //{
            //    Console.WriteLine("eyni deil");

            #endregion

            #region Task10
            //string[] spearator = { ", ", ".", " ", "!", "?", "/" };
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Zehmet olmasa bir metn daxil ediniz");
            //string input = Console.ReadLine().ToLower();


            //string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            //string joined = string.Join("", strlist);

            //string withoutNumbers = Regex.Replace(joined, "[0-9]", "");

            //Console.WriteLine(withoutNumbers);

            #endregion

            #region Task11
            //string[] spearator = { ", ", ".", " ", "!", "?", "/" };
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Zehmet olmasa bir metn daxil ediniz");
            //string input = Console.ReadLine().ToLower();


            //string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            //string joined = string.Join("", strlist);

            //int letterOfA = joined.IndexOf("a");
            //int letterOfB = joined.IndexOf("b");

            //string newstr1 = joined.Insert(letterOfA, "b");
            //string newstr2 = newstr1.Insert(letterOfB, "a");

            //Console.WriteLine(newstr2);



            #endregion

            #region Task12
            //string[] spearator = { ", ", ".", " ", "!", "?", "/", "a" };
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Zehmet olmasa bir metn daxil ediniz");
            //string input = Console.ReadLine();


            //string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            //string joined = string.Join("", strlist);

            //Console.WriteLine(joined);
            #endregion

            #region Task13
            ////string[] spearator = { ", ", ".", " ", "!", "?", "/" };
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Zehmet olmasa bir metn daxil ediniz");
            //string input = Console.ReadLine().ToLower();
            ////string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
            ////string joined = string.Join("", strlist);
            //string free;
            //char[] chararr1 = input.ToCharArray();
            //for (int i = 0; i < chararr1.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        chararr1[i] = char.ToUpper(chararr1[i]);
            //    }
            //}
            //free = new string(chararr1);
            //Console.WriteLine(free);
            #endregion

            #region Task 14
            /*
             14) Verilmish metinde butun tek yerde dayanan simvollari 
            ondan sonra gelen simvolun BOYUK formasi ile evez et.
            */
            //string metn = "14) Verilmish metinde butun tek yerde dayanan simvollari ondan sonra gelen simvolun BOYUK formasi ile evez et.";

            //for (int i = 0; i < metn.Length - 1; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        metn = metn.Insert(i+1, metn[i + 1].ToString().ToUpper());
            //        metn = metn.Remove(i,1);
            //    }
            //}

            //Console.WriteLine(metn);
            #endregion

            #region Task15
            //string[] spearator = { ", ", ".", " ", "!", "?", "/" };
            //string[] removeC = { "c" };
            //Console.WriteLine("Zehmet olmasa bir metin daxil ediniz");
            //string input = Console.ReadLine().ToLower();


            //string[] strlist = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            //string joined = string.Join("", strlist);
            //#region index metodu

            //char[] charArray = joined.ToCharArray();
            //string firstletter = charArray[0].ToString();
            //string lastletter = charArray[charArray.Length - 1].ToString();

            //Console.WriteLine("------------------------");
            //if (firstletter == lastletter && joined.Contains("aa") && !joined.Contains("b"))
            //{
            //    string[] strlist2 = joined.Split(removeC, StringSplitOptions.RemoveEmptyEntries);

            //    string joined2 = string.Join("", strlist2);
            //    Console.WriteLine($"Neticede alinan Metin: {joined2}");
            //}
            //else
            //{
            //    Console.WriteLine("Shertlere uygun bir netice tapilmadi");
            //}
            #endregion


        }

    }
  
}

