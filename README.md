# π¬ OST
#### π’ Office messenger Supporting Telecommuting
<br><br>

# κ°λ° κΈ°κ°
##### 3νλ 1νκΈ° μμ©μννΈμ¨μ΄μ€μ΅ (2021-03-12 ~ 2021-06-11)
μΉ΄μΉ΄μ€ν‘μ λͺ¨ν°λΈλ‘ `C# (.Net Core 3.1, .Net Framework 4.7.2)` κ³Ό `MySQL` λ±μ μ¬μ©ν΄ λ§λ  **μ¬λ΄ μ±ν νλ‘κ·Έλ¨** ννλ‘μ νΈ μλλ€.

μ€ννκΈ° μν΄μλ λͺκ°μ§ μ€μ μ΄ νμν©λλ€.
<br><br>

# λ°μ΄ν° λ² μ΄μ€ λ° μ μ  μμ±
μλ² νλ‘κ·Έλ¨μ λλ¦¬κΈ° μν΄ `.Net Core` μ `MySQL` νλ‘κ·Έλ¨μ΄ μ€μΉλ  μ μλ `Ubuntu 20.04 LTS` μ΄μμ²΄μ μμ μ°μ  `MySQL` μ μ€μΉνκ³  `DB` λ° `User` λ₯Ό μμ±ν©λλ€.
##### bash
``` bash
sudo mysql -u root -p
```
##### sql
``` sql
CREATE DATABASE ost DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
CREATE USER ost@localhost identified BY 'dr@M@0st';
GRANT ALL PRIVILEGES ON ost.* TO ost@localhost;
FLUSH PRIVILEGES;
```
<br><br>

# νμ΄λΈ μμ±
##### sql
``` sql
CREATE TABLE `ost`.`employee` (
  `id` INT NOT NULL,
  `password` VARCHAR(64) NOT NULL,
  `name` VARCHAR(20) NOT NULL,
  `phone` VARCHAR(14) NULL,
  `central` VARCHAR(45) NOT NULL,
  `team` VARCHAR(45) NOT NULL,
  `rank` VARCHAR(45) NOT NULL,
  `profile` LONGBLOB NULL,
  `profile_length` INT UNSIGNED NULL,
  PRIMARY KEY (`id`));

CREATE TABLE `ost`.`schedule` (
  `author` INT NOT NULL,
  `title` VARCHAR(45) NULL,
  `start` DATETIME NOT NULL,
  `end` DATETIME NOT NULL,
  `scope` VARCHAR(45) NULL,
  `contents` LONGTEXT NULL,
  `target` VARCHAR(45) NULL,
  CONSTRAINT `schedule_id`
    FOREIGN KEY (`author`)
    REFERENCES `ost`.`employee` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

CREATE TABLE `ost`.`room` (
  `id` VARCHAR(32) NOT NULL,
  `scope` INT NULL,
  `target` VARCHAR(45) NULL,
  PRIMARY KEY (`id`));

CREATE TABLE `ost`.`chat` (
  `room_id` VARCHAR(32) NOT NULL,
  `chat_date` DATETIME(6) NOT NULL,
  `employee_id` INT NOT NULL,
  `data` LONGBLOB NULL,
  `data_length` INT NULL,
  `data_type` INT NULL,
  UNIQUE INDEX `chat_date_UNIQUE` (`chat_date` ASC) VISIBLE,
  INDEX `chat_room_id_idx` (`room_id` ASC) VISIBLE,
  INDEX `chat_date_idx` (`chat_date` ASC) VISIBLE,
  INDEX `chat_employee_id_idx` (`employee_id` ASC) VISIBLE,
  CONSTRAINT `chat_room_id`
    FOREIGN KEY (`room_id`)
    REFERENCES `ost`.`room` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `chat_employee_id`
    FOREIGN KEY (`employee_id`)
    REFERENCES `ost`.`employee` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
```

μ΄λ‘μ¨ μ¬μ  μΈνμ΄ λͺ¨λ λλ¬μ΅λλ€.
<br><br>

# μλ² μ€ν
`Release` ν­μμ `OSTServer.zip` μ λ€μ΄λ°κ³  μμΆμ νμ΄μ£ΌμΈμ.

> #### μ κΉ!
> μλ²λ `.Net Core 3.1` λ₯Ό μ¬μ©νλ©° μ€ννλ κ³³μ μ€μΉκ° λμ΄ μμ΄μΌν©λλ€.
λν `MySQL` λλ `MariaDB`κ° μ€μΉλμ΄ μμ΄μΌνλ©° λ°μ΄ν° λ² μ΄μ€λ `127.0.0.1` λ‘ μ μνκΈ° λλ¬Έμ λ‘μ»¬μ μ€μΉλμ΄ μμ΄μΌν©λλ€. (νλ‘μ νΈ `Server/Classes/Database.cs` μμ λ³κ²½ κ°λ₯)
#### Linux (Bash)
``` bash
dotnet [server-ip] [server-port]
```
#### Window (Powershell)
``` powershell
.\OSTServer.exe [port]
```
> `OSTServer.exe` λ₯Ό κ·Έλ₯ μ€νν΄λ λμ§λ§ ν¬νΈλ κΈ°λ³Έκ°μΈ `6756` μΌλ‘λ§ μ€νλ©λλ€.

#### μ€ν κ²°κ³Ό
``` powershell
PS C:\Users\chchc\Downloads\OSTServer> .\OSTServer.exe
[2021-07-14 13:40:19] DB | Server 127.0.0.1 is connected
[2021-07-14 13:40:19] System | Server is opend with port 6756
```
<br><br>

# νλ‘κ·Έλ¨ μ€ν
`.Net Framework 4.7.2` κΈ°λ°μ΄λ©° `Window Forms` λ‘ μ μλμ΄ μλμ°μμλ§ μ€ννμκΈΈ λ°λλλ€.
λ¦¬λμ€μ κ°μ μ΄μμ²΄μ μμ μ€νκ°λ₯ν λ°©λ²λ μμΌλ μ¬κΈ°μ λ€λ£¨μ§ μκ² μ΅λλ€.
#### Window (Powershell)
``` powershell
.\OfficeMessengarST.exe [server-ip] [server-port]
```
> `OfficeMessengarST.exe` λ₯Ό κ·Έλ₯ μ€νν΄λ λμ§λ§ κΈ°λ³Έκ°μΈ `127.0.0.1:6756` μΌλ‘λ§ μ€νλ©λλ€.

<br><br>

# μκ°
μ΄μ λΆν° νλ‘κ·Έλ¨ κΈ°λ₯μ νν΄μ³ λ³΄λλ‘ νκ² μ΅λλ€.

#### μ μ
![](Document/Connection.gif)
<br>

#### μ¬μ λ±λ‘
![](Document/Regist.gif)
<br>

#### λ‘κ·ΈμΈ λ° λ©μΈ νλ©΄
![](Document/LoginAndMain.gif)
<br>

#### μ‘°μ§λ λ° μ¬μ μ λ³΄
![](Document/Organizaiton.gif)
<br>

#### 1:1 μ±ν
![](Document/OneToOneChat.gif)
<br>

#### ν μ±ν
![](Document/TeamChat.gif)
<br>

#### λ³ΈλΆ μ±ν
![](Document/CentralChat.gif)
<br>

#### νμ¬ μ μ²΄ μ±ν
![](Document/OfficeChat.gif)
<br>

#### ER Diagram
![](Document/ERDiagram.PNG)
<br>

#### Table: Employee
![](Document/TableEmployee.PNG)
<br>

#### Table: Room
`target` μ»¬λΌμ΄ μ 1μ κ·νλ λ§μ‘±νμ§ λͺ»νλ€λ μ μ΄ μμ½κΈ΄ ν©λλ€.
![](Document/TableRoom.PNG)
<br>

#### Table: Chat
μ±ν νμ΄λΈμ `key` λ₯Ό μ§μ νκΈ° μν΄ `chat_date` μ»¬λΌμ `DATETIME(6)` μΌλ‘ μ§μ νμ¬ `millisecond` κΉμ§ μ μ₯νλλ‘ νμμ΅λλ€.
![](Document/TableChat.PNG)
<br>


<br><br>

# νΉμ§
#### μ±ν νλ©΄ κ°μν
μΉ΄μΉ΄μ€ν‘ μ²λΌ κ°μμ¬λ, κ°μ μκ°(λΆ λ¨μ κΉμ§) μΌ κ²½μ° μ±νμ΄ μ°κ²°λλλ‘ λμ΄μμ΅λλ€.

![](Document/ChatSeperated.gif)
<br>

#### λΉλ°λ²νΈ μΌλ°©ν₯ μνΈν μ μ₯
λ°μ΄ν°λ² μ΄μ€μ μ¬μ μ λ³΄κ° μ μ₯λ  λ λΉλ°λ²νΈλ₯Ό `SHA-512` μνΈν μκ³ λ¦¬μ¦μ μ μ©νμ¬ μ μ₯νμ¬ λ³΄μμ ν μΈ΅ λ κ°ννμμ΅λλ€.

![](Document/TableEmployeePassword.PNG)
<br>
