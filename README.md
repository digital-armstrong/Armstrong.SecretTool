# ARMStrong secret tools

## Что это?
ARMStrong secret tools - маленькая утилитка, чтобы просто прокинуть нужные `environment variable`, которые нужны для работы клиента [ARMStrong](https://github.com/digital-armstrong/Armstrong.Client).

## Как пользоваться?
Для того, что бы прокинуть переменные:
* Внесите изменения в файл `appsettings.json`
* Запустите `ArmstrongSecretTools.exe`
* Be cool =)

Переменные среды прокидываются как пользовательские, __не__ системные. 

В будущем, если это понадобится, утилита будет включена в состав [клиента](https://github.com/digital-armstrong/Armstrong.Client).