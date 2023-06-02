# 스무고개 게임 프로젝트

Winform을 사용하여 개발된 스무고개 게임

## 🚀 Contributors

- **전귀로** ([GitHub 링크](https://github.com/GRJeon))
- 박혜주 ([GitHub 링크](https://github.com/daisy0417))
- 배영현 ([GitHub 링크](https://github.com/Youngbae1126))
- 이정원 ([GitHub 링크](https://github.com/won31080))

## ⚠️ 폰트가 제대로 보이지 않을 경우

게임에서 사용된 폰트 파일의 경로

`KWProj_TQ/client/client/Resources/HANCOMMALANGMALANG-BOLD.TTF`

## ⚠️ Sqlite 에러가 발생할 경우

만약 ServerForm을 실행할 때 Sqlite 에러가 발생한다면 다음 단계를 따라 해결할 수 있습니다:

1. Visual Studio를 엽니다.
2. "도구" 메뉴로 이동합니다.
3. "Nuget 패키지 관리자"를 선택합니다.
4. "솔루션용 Nuget 패키지 관리"를 선택합니다.
5. "SQLite"를 찾아 제거합니다.
6. 다시 "SQLite"를 설치합니다.

## 🔧 고정 서버 IP 변경 방법

만약 고정된 서버 IP를 변경하고 싶다면 다음 단계를 따라 할 수 있습니다:

1. "client" 프로젝트를 빌드합니다.
2. `KWProj_TQ/client/client/bin/Debug/MyServerIP.txt` 파일을 엽니다.
3. 원하는 IP를 위에서부터 작성합니다. 기본값은 `127.0.0.1`입니다.
