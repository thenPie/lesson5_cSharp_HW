int Rand() {
    Random rd = new Random();
    int rand = rd.Next(1, 101);
    return rand;
}

int[] arr = {Rand(), Rand(), Rand(), Rand()};
int min = arr[0], max = arr[0];

Console.Write("[");
for (int i = 0; i < arr.Length; i ++) {
    Console.Write(arr[i] + (i < arr.Length - 1 ? ", " : "] -> "));
}

for(int i = 0; i < arr.Length; i++) {
    if(arr[i] < min) {
        min = arr[i];
    }
    if(max < arr[i]) {
        max = arr[i];
    }
}

int difference = max - min;

Console.Write(difference);