import math

x = int(input('Видите число X\n'))
p = 5

for n in range(1, p+1):
   z = math.log(n)
   result = n * (2*n+3+z*x)
   print(result)