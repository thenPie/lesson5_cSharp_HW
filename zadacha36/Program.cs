int Rand() {
    Random rd = new Random();
    int rand = rd.Next(-10, 21);
    return rand;
}

int[] arr = {Rand(), Rand(), Rand(), Rand()};
int del = 0;

Console.Write("[");
for (int i = 0; i < arr.Length; i ++) {
    Console.Write(arr[i] + (i < arr.Length - 1 ? ", " : "] -> "));
}

for(int i = 0; i < arr.Length; i++) {
    if(arr[i] % 2 != 0) {
        del = del + arr[i];
    }
}

Console.Write(del);