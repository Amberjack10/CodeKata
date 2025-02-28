#include <string>
#include <vector>

using namespace std;

int solution(vector<int> bandage, int health, vector<vector<int>> attacks) {
    int answer = health;
    int counter = 0;
    int start_heal = 0;

    // bandage[시전 시간, 초당 회복량, 추가 회복량]
    // attack[공격 시간, 피해량]

    // todo : 0 ~ 몬스터의 마지막 공격 시간까지 힐 진행.
    // 힐 시전 시간이 완료되면 추가 회복량만큼 더 회복.
    
    for (int i = 1; i <= attacks[attacks.size() - 1][0]; i++) {
        if (i == attacks[counter][0]) {
            answer -= attacks[counter][1];
            if (answer <= 0) return answer = -1;

            counter++;
            start_heal = 0;
        }
        else {
            answer += bandage[1];
            start_heal++;

            if (start_heal == bandage[0]) {
                answer += bandage[2];
                start_heal = 0;
            }

            if (answer >= health) answer = health;
        }
    }

    return answer;
}