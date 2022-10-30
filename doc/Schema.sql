CREATE TABLE [系所資料] (
    -- 系所代碼 系所代碼是唯一
    [DEPT_CODE] BIGINT NOT NULL UNIQUE,
    -- 系所中文名稱
    [DEPT_NAME] VARCHAR(100) NOT NULL,
    -- 系所英文名稱
    [DEPT_NAME_ENG] VARCHAR(100) NOT NULL,
    PRIMARY KEY (DEPT_CODE),
);

CREATE TABLE [學生學籍資料] (
    -- 學號 學號是唯一
    [STUD_NO] BIGINT NOT NULL UNIQUE,
    -- 姓名
    [STUD_NAME] VARCHAR(100) NOT NULL,
    -- 性別，社會性別有64種
    [SEX] CHAR(20) NOT NULL,
    -- 就讀系所代碼
    [DEPT_CODE] BIGINT NOT NULL,
    -- 電話
    [TEL] VARCHAR(100) NOT NULL,
    -- 地址
    [ADDRESS] VARCHAR(100) NOT NULL,
    PRIMARY KEY ([STUD_NO]),
);

CREATE TABLE [課程資料] (
    -- 課程編號 課程編號是唯一
    [SUBJ_NO] BIGINT NOT NULL UNIQUE,
    -- 中文課程名稱
    [SUBJ_NAME] VARCHAR(100) NOT NULL,
    -- 英文課程名稱
    [SUBJ_NAME_ENG] VARCHAR(100) NOT NULL,
    PRIMARY KEY ([SUBJ_NO]),
);

CREATE TABLE [學期課程資料] (
    -- 學年 
    [ACAD_YEAR] TINYINT NOT NULL,
    -- 學期
    [SEME_TYPE] CHAR(3) NOT NULL,
    -- 學期課號
    [COURSE_NO] BIGINT NOT NULL UNIQUE,
    -- 開課系所代碼
    [DEPT_CODE] BIGINT NOT NULL,
    -- 課程編號 每學期課號是唯一
    [SUBJ_NO] BIGINT NOT NULL,
    -- 學分數
    [CREDITS] INT NOT NULL,
    -- 修別??
    [MAJ_OP] CHAR(2) NOT NULL,
    -- 授課教師
    [TEACHER] VARCHAR(20) NOT NULL,
    PRIMARY KEY ([COURSE_NO]),
);

CREATE TABLE [學生選課資料] (
    -- 每位學生每學期可以選許多課程，一門課可以有多位學生選
    -- 學號 
    [STUD_NO] BIGINT NOT NULL,
    -- 學年
    [ACAD_YEAR] TINYINT NOT NULL,
    -- 學期
    [SEME_TYPE] CHAR(3) NOT NULL,
    -- 學期課號
    [COURSE_NO] BIGINT NOT NULL,
    PRIMARY KEY ([STUD_NO]),
);