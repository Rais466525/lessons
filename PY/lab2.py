import math

x = int(input('Видите число X\n'))
n = 1
p = 4
while True:
   n = n+1
   z = math.log(n)
   result = n * (2*n+3+z*x)
   print(result)
   if n > p:
      break