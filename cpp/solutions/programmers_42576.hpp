// https://school.programmers.co.kr/learn/courses/30/lessons/42576

#include <string>
#include <vector>
#include <map>

using namespace std;

class programmers_42576 {
public:
    static void execute() {
        programmers_42576 solution{};
        solution.test(std::vector<string>{"leo", "kiki", "eden"}, std::vector<string>{"kiki", "eden"});
        solution.test(std::vector<string>{"marina", "josipa", "nikola", "vinko", "filipa"}, std::vector<string>{"josipa", "filipa", "marina", "nikola"});
        solution.test(std::vector<string>{"mislav", "stanko", "mislav", "ana"}, std::vector<string>{"stanko", "ana", "mislav"});
    }

    void test(vector<string> participant, vector<string> completion) {
        std::cout << programmers_42576::solution(participant, completion) << std::endl;
    }

    string solution(vector<string> participant, vector<string> completion) {
        map<string, int> result;
        string answer = "";
        
        for(int i = 0; i < participant.size(); i++) {
            result[participant[i]]++;
        }
        
        for(int i = 0; i < completion.size(); i++) {
            result[completion[i]]--;
        }
        
        for(auto iter = result.begin(); iter != result.end(); iter++) {
            if(iter->second != 0)
            {
                answer += iter->first;
                break;
            }
        }
        
        return answer;
    }
};