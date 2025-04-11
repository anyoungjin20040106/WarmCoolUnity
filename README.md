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




## 🏗 시스템 구성
프로젝트는 다음 다섯 개의 주요 리포지토리로 구성되어 있습니다:

### 1. [WarmCoolYolo](https://github.com/anyoungjin20040106/WarmCoolYolo)
- YOLOv11-CLS 기반 퍼스널 컬러 분류 모델
- Roboflow를 통한 데이터셋 관리
- 모델 학습 및 평가 파이프라인

### 2. [WarmCoolFastapi](https://github.com/anyoungjin20040106/WarmCoolFastapi)
- FastAPI 기반 백엔드 서버
- YOLOv11-CLS 모델 서빙
- RESTful API 엔드포인트 제공
- MySQL 데이터베이스 연동

### 3. [WarmCoolUnity](https://github.com/anyoungjin20040106/WarmCoolUnity)
- Unity 기반 AR 애플리케이션
- ARFoundation을 통한 얼굴 인식
- 가상 메이크업 적용
- Photon 기반 실시간 채팅

### 4. [WarmCoolSQL](https://github.com/anyoungjin20040106/WarmCoolSQL)
- 채팅 정보 관리
- 유저 정보 관리
- 퍼스널 컬러 해설

### 5. [WarmCoolDataset](https://github.com/anyoungjin20040106/WarmCoolDataset)
- roboflow를 활용한 데이터 수집
- github를 활용한 데이터 수집
- 데이터 전처리
---

## 🛠 사용 기술

- Unity (2021.3+)
- ARFoundation (Face Tracking)
- Photon PUN 2 (Chat)

---


## 💻 기술 스택
- **AI/ML**: YOLOv11-CLS, Ultralytics
- **백엔드**: FastAPI, MySQL
- **프론트엔드**: Unity, ARFoundation
- **네트워킹**: Photon PUN2
- **데이터**: Roboflow
