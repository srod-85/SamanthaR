
Console.WriteLine("Hello, world!");


Console.WriteLine("[1] - condition 1");
Console.WriteLine("[2] - condition 2");
Console.WriteLine("[3] - condition 3");
Console.WriteLine("[4] - condition 4");
Console.WriteLine("Please input a value");

int test = int.Parse(Console.ReadLine());

test = int.Parse(Console.ReadLine());

switch (test)  {
    case 1: 
        Console.WriteLine("Condition 1");
    break;
    
    case 2:
        Console.WriteLine("Condition 2");
        break;
    
    case 3: 
        Console.WriteLine("Condition 3");
        break;
    
    case 4: 
        Console.WriteLine("Condition 4");
        break;
    
    default: 
        Console.WriteLine("Not a valid condition");
}






Console.WriteLine("######### While ###########");

bool newTest = true;

Console.WriteLine("this happens before the loop");
while (newTest == true)
{
    Console.WriteLine("your test was true");
    newTest = false;
}
Console.WriteLine("This happens after the loop");

Console.WriteLine("######### Do While #######");

int j = 0;
do {
    Console.WriteLine(j);
    j++;

    if(j == 3) {
        Console.WriteLine("Did the if work?)");
    }
}
while(j<5);

Console.WriteLine("######## While Loop w/ j");
j = 0;
while(j<5) {
    Console.WriteLine(j);
    j++;
}