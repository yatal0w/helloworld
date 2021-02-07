add_library (HelloWorld SHARED HelloWorld.cpp)
add_library (HelloWorld2 STATIC HelloWorld2.cpp)
add_executable (Hello Hello.cpp)
target_link_libraries (Hello HelloWorld HelloWorld2)
