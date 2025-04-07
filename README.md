# 🎮 WarmCoolUnity - Unity AR 기반 퍼스널 컬러 소셜 시스템

## 📌 프로젝트 개요

**WarmCoolUnity**는 사용자의 얼굴 이미지를 기반으로 퍼스널 컬러를 분석하고, AR 가상 메이크업을 적용하며, 같은 퍼스널 컬러 그룹의 사용자들과 실시간 채팅까지 가능하게 하는 Unity 기반 통합 뷰티 소셜 시스템입니다.

FastAPI 서버와 YOLOv11-CLS 모델을 연동하여 퍼스널 컬러를 분류하고, Unity에서 ARFoundation 및 Photon을 통해 실시간 인터랙션을 제공합니다.

---

## 🎯 주요 기능

- 📷 Unity ARFoundation으로 얼굴 이미지 캡처
- 🛰 FastAPI 서버로 이미지 전송 및 분석 결과 수신
- 💄 분석 결과에 따라 AR 가상 메이크업 적용
- 💬 Photon Chat으로 같은 퍼스널 컬러 그룹 사용자 간 실시간 채팅

---

## 🏗 시스템 구성 요소 관계 흐름

```
[ photon chat ]
  -같은 퍼스널 컬러인 사람들 끼리 커뮤니티를 할수 있는 공간 구현

        ↑ 퍼스널 컬러 제공

[ Unity (시작점)](https://github.com/anyoungjin20040106/WarmCoolunity)
  - 사용자 얼굴 이미지 촬영
  - 분석 결과 기반 AR 메이크업 적용 (ARFoundation)
  - ➕ 결과 기반으로 Photon Chat 연결

이미지 전송   ⇅결과 수신

[ FastAPI 서버 ](https://github.com/anyoungjin20040106/WarmCoolfastapi)
  - YOLOv11-CLS 모델 호출
  - Unity에서 이미지 수신 → 추론 → 결과 응답

이미지 전송   ⇅결과 수신

[ YOLOv11-CLS 모델 (Ultralytics) ](https://github.com/anyoungjin20040106/WarmCoolYolo)
  - 학습된 weight로 이미지 분류
  - 퍼스널 컬러 결과 반환

        ↑ 데이터 제공

[ Roboflow & github]
  - YOLOv11-CLS 학습용 데이터셋 제공=
```

---

## ⚙️ 사용 기술

- Unity (2021.3+)
- ARFoundation (Face Tracking)
- Photon PUN 2 (Chat)

---

## 🚧 개발 단계

- [X] YOLOv11-CLS 모델 학습 및 FastAPI 서버 배포
- [X] Unity ↔ FastAPI 이미지 전송 및 결과 수신 구현
- [ ] AR 메이크업 효과 연동
- [ ] Photon 채팅 시스템 완성 및 UI 디자인

---