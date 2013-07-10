unity-examples
==============

## APKs

* http://dl.dropbox.com/s/nw4rkgbv483g878/unity-dynamic-font-tester.apk

## 테스트

    가나다라마바사
    ABCDEFGHIJKLM
    아자차카타파하
    OPQRSTUVWXYZ!
    간난단란만반산
    1234567890@#$
    안잔찬칸탄판한
    
* 앱 실행시 1초당 1줄씩 출력되며 가득차면 전체가 지워지고 처음부터 다시 출력됨
* 글자 순서가 뒤바뀌어서 출력되는 건 정상 작동임
* 2개 이상의 텍스트가 한꺼번에 출력되는 것은 정상 작동임
* 일부 안드로이드 장치에서는 텍스트가 표시되지 않거나 일부만 출력됨
  * 정상: 아자차카타파하
  * 문제: 아자

* 문제 현상 발생시 왼쪽 상단 [o] BUG [ ] FIX 에서 FIX 를 눌러 정상 작동 여부를 확인함

## 테스트 결과

* 삼성 갤럭시 S3 - 문제 없음 (GPU: mali-400MP)
* 삼성 갤럭시 노트 8인치 - 문제 없음 (GPU: mali-400MP4)
* 구글 넥서스4 - BUG 발생, FIX 가능 (GPU: adreno 320)
* 구글 넥서스7 - 문제없음 (GPU: nvidia ULP geforce 416 MHz)
* LG 옵티머스LTE2 - BUG 발생, FIX 가능 (GPU: adreno 225)
* 펜텍 베가 NO.6 - 문제 없음 (GPU: adreno 320)
