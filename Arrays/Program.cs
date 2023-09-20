
// massiivid - salvestatakse vahemälus heap-is. Massiivid on vajalikud selleks, et salvestad andmeid ühes kohas. Ei pea olema sümbolid, sõned ,numbrid
// võivad olla mis iganes. Ühes massiivis peab olema ainult ühte tüüpi andmed. String[]- ehk ei ole lihtsalt sõne, vaid kogumik

// string[] fruit = { "apples", "bananas", "oranges" };  // siia loogeliste sulgude vahele ei saa salvestada veel nt. 3 - mis on int ja true - mis on boolean, sest
//algus on string 



string[] fruit = new string[3];

fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";
Console.Write($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArrayLength  = fruit.Length;


Console.WriteLine($"There are {fruitArrayLength} in your array.");

for (int i = 0; i < fruitArrayLength; i++)  // kui vaja muuta elementide kasutada seda For-i 
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0])); // suur erinevus massiivide ja sõnede vahel on see, et massiivide sees olevaid väärtusi võib ümber kirjutada 
}

foreach(string element in fruit)     //iga element (ehk apples, bananas, oranges)  fruit massiivis , foreach ei lase muuta elementide sisu, ehk suur tähte panna nt.
    //foreaci kasutatakse selleks, et midagi kuvada, või andmebaasi salvestada. kui tahame nt. suur tähte siis kasutada for. 
{
   
    Console.WriteLine(element);    
}
