string[]array = {"2022", "tea", "=)","a+b"};

int newArrayLength = 0;
for (int i = 0; i < 4; i++)
{
    if (array[i].Length <= 3) 
    newArrayLength++;
}
string[] newArray = new string[newArrayLength];