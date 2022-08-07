// https://school.programmers.co.kr/learn/courses/30/lessons/42576

#include <string>
#include <vector>
#include <map>

class programmers_42576 {
public:
    static void execute() {
        programmers_42576 solution{};
        solution.test(
            std::vector<std::string>{"leo", "kiki", "eden"}, 
            std::vector<std::string>{"kiki", "eden"}
            );
        solution.test(
            std::vector<std::string>{"marina", "josipa", "nikola", "vinko", "filipa"}, 
            std::vector<std::string>{"josipa", "filipa", "marina", "nikola"}
            );
        solution.test(
            std::vector<std::string>{"mislav", "stanko", "mislav", "ana"}, 
            std::vector<std::string>{"stanko", "ana", "mislav"}
            );
    }

    void test(std::vector<std::string> participant, std::vector<std::string> completion) {
        std::cout << solution(participant, completion) << std::endl;
    }

    std::string solution(std::vector<std::string> participant, std::vector<std::string> completion) {
        std::map<std::string, int> result;
        std::string answer = "";
        
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