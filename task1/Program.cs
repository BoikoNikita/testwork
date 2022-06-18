string[]array = {"2022", "tea", "=)","a+b"};

int newArrayLength = 0;
for (int i = 0; i < 4; i++)
{
    if (array[i].Length <= 3) 
    newArrayLength++;
}
string[] newArray = new string[newArrayLength];

int count = 0; 
for (int k = 0; k < 4; k++)
{
    if (array[k].Length <= 3)
    {
        newArray[count] = array[k];
        count++;
    }
}