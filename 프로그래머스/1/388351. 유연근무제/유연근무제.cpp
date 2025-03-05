#include <string>
#include <vector>

using namespace std;

bool isTrue(int a, int b) {
    if (a / 100 - b / 100 == 1) return a % 100 + 60 - b % 100 >= 0 && a % 100 + 60 - b % 100 <= 10;
    else if (a / 100 - b / 100 == 0) return a % 100 - b % 100 <= 10;
    else if(a / 100 - b / 100 < 0) return true;

    return false;
}

int solution(vector<int> schedules, vector<vector<int>> timelogs, int startday) {
    int answer = 0;
    int date = startday;

    // schedules = 희망 출근 시간
    // timelogs = 직원들이 실제로 출근한 시간. timelogs[i][j] = i + 1번째 직원이 이벤트 시작 j + 1일에 출근한 시간.
    // startday = 이벤트를 시작한 날짜. 1 = 월요일 ~ 7 = 일요일.
    // startday = 6, 7은 이벤트에 영향 X

    int counter = 0;

    for (int i = 0; i < timelogs.size(); i++) {
        date = startday;
        for (int j = 0; j < 7; j++) {
            if (date >= 6) {
                date++;
                if (date >= 8) date = 1;
                continue;
            }
            else {
                if (isTrue(timelogs[i][j], schedules[i])) counter++;
                date++;
            }
        }
        if (counter >= 5) answer++;
        counter = 0;
    }

    return answer;
}