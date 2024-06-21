C# TestingMultimapsX64

C++의 template std::multimap과 std::unordered_multimap을 C++/CLI을 이용하여 C#에서 사용할 수 있게 dll파일로 Wapping하였습니다.

dll 파일을 C#프로젝트에 추가하여 테스트한 파일입니다.

multimap의 클래스명은 CSharpMultiMap이고 unordered_multimap의 클래스명은 CSharpUnOrderedMultiMap입니다.

두 함수 모두 Generics 형식입니다.

enum은 Key값 또는 Value값으로 사용이 불가능합니다. enum을 사용 못하게 막았습니다.

굳이 사용하고 싶으시다면 int로 형변환하여 사용하시길 바랍니다.

클래스값을 Key 값으로 설정하게되면 메모리 누수가 일어날 수 있습니다.

erase(Key) 함수를 사용하거나 Clear() 함수를 사용해야 클래스 Key값이 지워지고 메모리 누수를 막을 수 있습니다.

foreach를 사용할 수 있습니다.

클래스를 Value 값으로 설정하는 것은 메모리 누수는 발생하지 않습니다.

64bit(X64)용으로 올려봅니다.

코드가 마음에 들지 않는 노가다성 코드라서 좋은 코드는 아닌듯하고 누군가가 여기저기에서 사용하다가 심각한 오류에 직면하실 수도 있으실것 같아 걱정이됩니다.

32bit(X86)용이 필요하신분들은 아래 링크로 이동하시길 바랍니다.

https://github.com/naverstarcraft/TestingMultimapsX86

감사합니다.

/*========================================*/

C# TestingMultimapsX64

Using C++/CLI, I've wrapped template std::multimap and std::unordered_multimap from C++ to be usable in C# as DLL files.

This is a file that was tested by adding the DLL file to a C# project.

The class name for multimap is CSharpMultiMap, and for unordered_multimap, it is CSharpUnOrderedMultiMap.

Both functions are in generic format.

Enums cannot be used as key or value types. I've prevented the use of enums.

If you wish to use them, please convert them to int and use.

If you use a class as a key value, memory leaks may occur.

To prevent memory leaks, you need to use the erase(Key) function or the Clear() function to remove the class key value."

Using a class object as a value does not cause memory leaks.

You can use foreach.

Here is the version for 64-bit (x64) systems.

I don't think it's a good code as it feels like tedious and repetitive work. I'm concerned that someone might use it here and there and encounter serious errors.

If you need the 32-bit (x86) version, please follow the link below.

https://github.com/naverstarcraft/TestingMultimapsX86

Thank you.