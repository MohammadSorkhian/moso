
def maxCrossingSum(arr, l, m, h) : 

	sm = 0; 
	left_sum = -10000
	left_ind = -1
	
	for i in range(m, l-1, -1) : 
		sm = sm + arr[i] 
		if (sm > left_sum) : 
			left_sum = sm 
			left_ind = i
	
	
	sm = 0; 
	right_sum = -1000
	right_ind = -1

	for i in range(m + 1, h + 1) : 
		sm = sm + arr[i]
		if (sm > right_sum) :
			right_sum = sm
			right_ind = i
	
	maximum = max(left_sum + right_sum, left_sum, right_sum)
	if (maximum == (left_sum+right_sum)):
		r = [left_ind, right_ind]
	elif (maximum == left_sum):
		r = [left_ind, m]
	else:
		r = [m, right_ind]


	return [maximum,r]



def maxSubArraySum(arr, l, h) : 
	
	if (l == h) : 
		return [arr[l],l] 

	m = (l + h) // 2
	left = maxSubArraySum(arr, l, m)
	right = maxSubArraySum(arr, m+1, h)
	middle = maxCrossingSum(arr, l, m, h)
	
	maximum = max(left[0], right[0], middle[0])
	if (maximum == left[0]):
		return left
	elif(maximum == right[0]):
		return right
	else:
		return middle


# arr = [3,11,-9,-1] 
# arr = [59,-63,41,11,-13,53,-35,11]
arr = [63,-59,41,11,-13,53,-35,11]
# arr = [59,-63,41,11,-1,53]
n = len(arr) 
max_sum = maxSubArraySum(arr, 0, n-1) 
print("Maximum contiguous sum is ", max_sum) 