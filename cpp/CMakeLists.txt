# cmake 버전을 지정
cmake_minimum_required(VERSION 3.23.2)

# 프로젝트 이름 설정
project(codetest)

# C++ 표준 지정 (C++ 17)
set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED True)

# 실행 파일 추가
add_executable(codetest main.cpp)