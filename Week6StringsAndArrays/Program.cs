

string hello = " we are the champions? ";  // nt. sõna hello , täht h indeks on 0, e on 1 jne. viimase sümboli asukoht on alati ühe võrra väikem kui terve sõne pikkus. ehk kokku 5 tähte aga 
 //viimane täht o=4. 


int stringLength = hello.Length;  //lenght on sõne kirjeldus, kui pikk see sõne on 

//string trimmedString = hello.Trim();  // trim on käsk, et lõika see tühik sealt "hello, world! " lause lõpust ära. 


hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);


hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');  // suuremaks tehakse ükskõik mis täht lause alguses, enne oli hello,world, siis konsool kuvas h, nüüd w

firstLetter = hello[0];

Console.WriteLine(firstLetter);

Console.WriteLine(hello);



//int wordCounter = 0;    

//for (int i = 0; i < hello.Length; i++)
//{
//    if (char.IsWhiteSpace(hello[i]))  //char.iswhitespace kontrollib kas sümbol on tühik või mitte 
//    {
//        wordCounter++;
//    }

//}

//Console.WriteLine($"Word count in {hello}: {wordCounter + 1} words");

