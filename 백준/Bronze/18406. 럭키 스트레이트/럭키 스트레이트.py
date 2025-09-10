# 점수 N을 입력 받음
n = input()
a = 0
b = 0

# N을 0 ~ n/2 - 1, n/2 ~ n - 1까지 분리
for i in range(int(len(n) / 2)):
    a += int(n[i])
    b += int(n[len(n) // 2 + i])

if a == b:
    print("LUCKY")
else:
    print("READY")