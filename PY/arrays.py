# эллементы массива можно ввести с клавиатуры. нужно найти четный элементы в массиве
n = int(input("Кол-во элементов в массиве:\n "))

arr = []

for i in range(n):
    arr.append(int(input("Эллементы для массива {}: ".format(i+1))))

evenCount = sum(1 for x in arr if x % 2 == 0)

print("Кол-во четных элементов:", evenCount)