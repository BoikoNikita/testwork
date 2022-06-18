string[]array = {"2022", "tea", "=)","a+b"};

int newArrayLength = 0;
for (int i = 0; i < 4; i++)
{
    if (array[i].Length < 4) 
    newArrayLength++;
}
string[] newArray = new string[newArrayLength];

int count = 0; 
for (int k = 0; k < 4; k++)
{
    if (array[k].Length < 4)
    {
        newArray[count] = array[k];
        count++;
    }
}

for (int j = 0; j < newArrayLength; j++)
{
    Console.Write(newArray[j]);
    if (j < newArrayLength - 1) 
    Console.Write("; ");
}