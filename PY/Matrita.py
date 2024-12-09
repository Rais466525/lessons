# Определить имеються ли в двухмерном массиве найти индекс самого большого числа.
n = int(input("Enter number of rows: "))
m = int(input("Enter number of columns: "))

arr = [[int(input("Enter element ({},{}): ".format(i, j))) for j in range(m)] for i in range(n)]

max_element = max(max(row) for row in arr)
max_index = [(i, j) for i, row in enumerate(arr) for j, x in enumerate(row) if x == max_element]

print("Max element:", max_element)
print("Max index:", max_index[0])