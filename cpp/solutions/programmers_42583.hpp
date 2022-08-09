// https://school.programmers.co.kr/learn/courses/30/lessons/42583

#include <string>
#include <vector>
#include <queue>

class programmers_42583 {
public:
    static void execute() {
        programmers_42583 solution{};
        solution.test(2, 10, std::vector{7,4,5,6});
        solution.test(100, 100, std::vector{10});
        solution.test(100, 100, std::vector{10,10,10,10,10,10,10,10,10,10});
    }

    void test(int bridge_length, int weight, std::vector<int> truck_weights) {
        std::cout << solution(bridge_length, weight, truck_weights) << std::endl;
    }

    typedef struct truckProgress {
        int progress;
        int weight;
    };

    int solution(int bridge_length, int weight, std::vector<int> truck_weights) {
        int answer = 0;
        std::queue<int> truckReady{};
        std::queue<truckProgress> truckOnBridge{};
        int currentWeightBridge = 0;
        int turnCount = 0;

        for(int i = 0; i < truck_weights.size(); i++)
            truckReady.push(truck_weights[i]);


        while (!truckReady.empty() || !truckOnBridge.empty())
        {
            turnCount++;

            bool isEnterNextTruck = truckReady.size() > 0 && 
                                    truckOnBridge.size() < bridge_length &&
                                    currentWeightBridge + truckReady.front() <= weight;

            if (isEnterNextTruck)
            {
                int truck = truckReady.front(); 
                truckOnBridge.push(truckProgress{0, truck});
                currentWeightBridge += truck;
                truckReady.pop();
            }

            int truckCountOnBridge = truckOnBridge.size();
            for (int i = 0; i < truckCountOnBridge; i++)
            {
                auto t = truckOnBridge.front();
                t.progress++;
                truckOnBridge.pop();
                if (t.progress >= bridge_length)
                {
                    currentWeightBridge -= t.weight;
                    continue;
                }
                else
                {
                    truckOnBridge.push(t);
                }
            }
        }

        answer = turnCount + 1;

        return answer;
    }
};