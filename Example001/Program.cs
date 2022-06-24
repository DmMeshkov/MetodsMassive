int a1 = 87;
int b1 = 21;
int c1 = 33;
int a2 = 43;
int b2 = 32;
int c2 = 64;
int a3 = 65;
int b3 = 30;
int c3 = 42;

int max = a1;
if(b1>max) max =b1;
if(c1>max) max =c1;

if(a2>max) max =a2;
if(b2>max) max =b2;
if(c2>max) max =c2;

if(a3>max) max =a3;
if(b3>max) max =b3;
if(c3>max) max =c3;

Console.WriteLine(max);