// https://school.programmers.co.kr/learn/courses/30/lessons/1845

#include <iostream>
#include <string>
#include <vector>
#include <map>

class programmers_1845 {
public:
    static void execute() {
        programmers_1845 solution{};
        solution.test(std::vector{3,1,2,3});
        solution.test(std::vector{3,3,3,2,2,4});
        solution.test(std::vector{3,3,3,2,2,2});
    }

    void test(std::vector<int> nums) {
        std::cout << solution(nums) << std::endl;
    }

    int solution(std::vector<int> nums) {
        int answer = 0;
        std::map<int,int> caseContainer{};

        for(auto iter = nums.begin(); iter != nums.end(); iter++) {
            caseContainer[*iter]++;
        }

        answer = std::min(caseContainer.size(), nums.size() / 2);

        return answer;
    }
};