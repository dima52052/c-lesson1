int [] GArr(int size=8){
    int[] arr=new int[size];
    for (int i=0; i<arr.Length;i++){
        arr[i]=new Random().Next(100);
    }

    return arr;
}

foreach (var item in GArr()){
Console.WriteLine(item);
}