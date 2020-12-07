# items = sorted([2, 3, 5, 10, 15, 16, 19])
items = sorted([10,15,20,25,20,35,5,45,60,75,10,60,50,30,40,60,45,100,19,34])
inputGoats = [40,50,87,48,120,30,1290]
acceptableGoats = []
solution = []
maxGoatPrice = max(inputGoats)
table = arr = [[0 for i in range(maxGoatPrice+1)] for j in range(len(items)+1)]
for row in table: row[0]=1

for i in range(1, len(items)+1):
    for j in range(1, maxGoatPrice+1):
        if j < items[i-1]:
            table[i][j] = table[i-1][j]
        if j == items[i-1]:
            table[i][j] = 1
        if j > items[i-1]:
            table[i][j] = table[i-1][j-items[i-1]]

for row in table: print(row)

for goat in inputGoats:
    for i in range(len(items)):
        if table[i][goat] == 1 :
            acceptableGoats.append(goat)
            break

for sum in acceptableGoats:
    tempSolution = []
    while sum > 0:
            for i in range(len(items)):
                if (table[i][sum] == 1):
                    tempSolution.append(items[i-1])
                    sum -= items[i-1]
                    break
    solution.append(tempSolution)

print(solution)