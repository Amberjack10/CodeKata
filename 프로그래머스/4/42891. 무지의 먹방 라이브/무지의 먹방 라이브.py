import heapq

# 모든 음식 최소 힙에 삽입하기
def solution(food_times, k):
    # 전체 음식을 먹는 시간보다 k가 크거나 같다면 -1
    if sum(food_times) <= k:
        return -1

    # 시간이 작은 음식부터 빼야 하므로 우선순위 큐를 이용
    q = []
    for i in range(len(food_times)):
        heapq.heappush(q, (food_times[i], i + 1))

    summary = 0 # 먹기 위해 사용한 시간
    previous = 0 # 직전에 다 먹은 음식 시간

    length = len(food_times) # 남은 음식 개수

    # summary + (현재의 음식 시간 - 이전 음식 시간) * 현재 음식 개수와 k 비교
    while summary + ((q[0][0] - previous) * length) <= k:
        now = heapq.heappop(q)[0]
        summary += (now - previous) * length
        length -= 1 # 다 먹은 음식 제외
        previous = now # 이전 음식 시간 재설정

    answer = sorted(q, key = lambda x: x[1]) # 음식의 번호 기준으로 정렬
    return answer[(k - summary) % length][1]