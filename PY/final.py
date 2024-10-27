for i in range(1, 100):
   for j in range(1, 50):
      res = (i-j+1)/(j+i)

resualt = res + res
print(resualt)


i = 1
while i < 100:
   j = 1
   while j < 50:
      res = (i-j+1)/(j+i)
      j = j+1
   i = i+1

resualt = res + res
print(resualt)