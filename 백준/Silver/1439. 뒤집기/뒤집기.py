# s 길이 100만
s = list(map(int, input()))

# counter를 2개 만든 후, s를 순회하면서 각각 0으로 뒤집을 때, 1로 뒤집을 때를 count.
# 이후 비교하여 결과로 출력
count_0 = 0 # 전부 0으로 바꾸는 경우
count_1 = 0 # 전부 1로 바꾸는 경우

# 첫 번째 원소에 대한 처리
if s[0] == 1:
    count_0 += 1
else:
    count_1 += 1

for i in range(len(s) - 1):
    if s[i] != s[i + 1]: # 만약 i의 다음 원소가 i 번째 원소와 같지 않다면
        if s[i + 1] == 1: count_0 += 1 # 다음으로 오는 원소가 1이면 => 그 전까지의 0들을 1로 뒤집음
        else: count_1 += 1 # 다음으로 오는 원소가 0이면 => 그 전까지의 1들을 0으로 뒤집음

# 두 counter 중 더 작은 값 출력하기
print(min(count_0, count_1))