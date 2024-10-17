import math

x = int(input('Видите число X\n'))
n = 1
p = 4
while n<=p:
   n = n+1
   z = math.log(n)
   resualt = n * (2*n+3+z*x)
   print(resualt)