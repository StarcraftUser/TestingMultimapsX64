### C# TestingMultimapsX64

이 프로젝트는 **C++의 `std::multimap`과 `std::unordered_multimap` 템플릿**을 C++/CLI로 Wrapping하여 C#에서 사용할 수 있도록 만든 DLL입니다.  
C# 프로젝트에 DLL을 추가하여 테스트할 수 있습니다.

- `CSharpMultiMap` → `std::multimap` 대응 클래스  
- `CSharpUnOrderedMultiMap` → `std::unordered_multimap` 대응 클래스  
- 두 클래스 모두 **Generics** 형식을 지원합니다.  

---

### enum 지원
~~enum은 Key 값 또는 Value 값으로 사용이 불가능합니다. enum을 사용 못하게 막았습니다.~~  
~~굳이 사용하고 싶으시다면 int로 형변환하여 사용하시길 바랍니다.~~

이전 버전에서는 enum을 Key 또는 Value로 사용할 수 없었으나, 현재는 **enum도 사용 가능합니다.**  
필요하다면 `int`로 형변환하여 사용하셔도 무방합니다.  

---

### 클래스 Key 값 관련
~~클래스 값을 Key 값으로 설정하게 되면 메모리 누수가 일어날 수 있습니다.~~  
~~erase(Key) 함수를 사용하거나 Clear() 함수를 사용해야 클래스 Key 값이 지워지고 메모리 누수를 막을 수 있습니다.~~  
~~클래스를 Value 값으로 설정하는 것은 메모리 누수는 발생하지 않습니다.~~

이전 버전에서는 클래스 값을 Key 값으로 사용할 경우 메모리 누수가 발생했으나, 현재는 수정되어 문제가 발생하지 않습니다.  

---

### 기타 기능
- `foreach` 구문을 사용할 수 있습니다.  
- 64bit(X64) 환경에서 동작합니다.  
- 32bit(X86) 버전이 필요하신 분들은 아래 링크를 참고하세요.  

https://github.com/naverstarcraft/TestingMultimapsX86

---

### 참고
코드가 다소 장황하고 반복적인 구조(노가다성)를 가지고 있어 우아한 코드라고 보기는 어렵습니다.
사용 중에 예상치 못한 오류가 발생할 수 있으니 사용 시 주의하시기 바랍니다.

감사합니다.  

---

C# TestingMultimapsX64
This project provides a DLL that wraps C++ std::multimap and std::unordered_multimap templates using C++/CLI, making them available for use in C#.
You can add the DLL to your C# project and run tests with it.
- CSharpMultiMap → corresponds to std::multimap
- CSharpUnOrderedMultiMap → corresponds to std::unordered_multimap
- Both classes support Generics.

enum Support
Enums could not be used as a Key or Value, and their usage was restricted.
If you really wanted to use them, you had to cast them to int.
In previous versions, enums could not be used as a Key or Value, but they are now fully supported.
If necessary, you may still cast an enum to int for use.

Class Key Values
Using a class as a Key could cause memory leaks.
You had to call erase(Key) or Clear() to remove class Key values and prevent leaks.
Using a class as a Value did not cause memory leaks.
In previous versions, using a class as a Key could result in memory leaks, but this issue has now been fixed and no longer occurs.

Other Features
- Supports the foreach loop.
- Works in 64-bit (X64) environments.
- If you need a 32-bit (X86) version, please refer to the link below.
https://github.com/naverstarcraft/TestingMultimapsX86

Notes
The code is somewhat verbose and repetitive (boilerplate-heavy), so it may not be the most elegant solution.
Unexpected errors may occur, so please use with caution.

Thank you.

