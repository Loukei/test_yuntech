# TODO

- [x][建立網站骨架並成功執行](#建立網站骨架並成功執行)
- [x][建立一個halloworld的頁面](#建立一個halloworld的頁面)
  - [x][嘗試使用Template修改Hallo world頁面](#嘗試使用Template修改Hallo world頁面)

## 建立網站骨架並成功執行

[ASP.NET Core MVC 使用者入門 | Microsoft Learn](https://learn.microsoft.com/zh-tw/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-6.0&tabs=visual-studio)

## 建立一個HalloWorld的頁面

~~新增一個URL規則~~
~~建立一個Controller，輸出hallo world字串~~

## 嘗試使用Template修改Hallo world頁面

## 建立SQL server與專案的連線

## 引入Model層，建立簡單的資料模型

## 設計School的頁面與資源

### 學籍資料清單

`GET ./School/Student/List`

- 列出所有的學生及其科系
- 標題旁邊有個[新增按鈕](#學生資料)

### 選課資料

`GET ./School/Student/<int: sid>/class/list`

- 列出該學生的所有選課資料

### 學生資料

`GET ./School/Student/<int: sid>/edit`

- 顯示學生的編輯資料表

### (學生資料)刪除頁面

`GET ./School/Student/<int: sid>/delete`

- 一個對話框
- 確定->刪除指定`id`的學生資料
  - `POST ./School/Student/<int: sid>/delete`
- 取消->返回[學籍資料清單](#學籍資料清單)

## .net的 package manager? 類似pipenv