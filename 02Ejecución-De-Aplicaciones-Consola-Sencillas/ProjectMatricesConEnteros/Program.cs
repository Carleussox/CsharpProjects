int [] inventory = [200,450,700,175,250];

int sum = 0;
int iteration =0;
foreach(int item in inventory){
   iteration++;
    sum += item;
    Console.WriteLine($"Bin{iteration}: {item} (running total {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");