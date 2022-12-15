int Rand3D() {
    Random rd = new Random();
    int rand = rd.Next(100, 1000);
    return rand;
}

int[] arr = {Rand3D(), Rand3D(), Rand3D(), Rand3D()};
int del = 0;

Console.Write("[");
for (int i = 0; i < arr.Length; i ++) {
    Console.Write(arr[i] + (i < arr.Length - 1 ? ", " : "] -> "));
}

for(int i = 0; i < arr.Length; i++) {
    if(arr[i] % 2 == 0) {
        del++;
    }
}

Console.Write(del);