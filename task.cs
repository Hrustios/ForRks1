// post processing:
//      добавить layer
//      на камеру post process layer - добавить анти элазинг
//      на пустышку(также ей указываем слой postprocessing) post process Volume - глобал  первые 5+screen (-bloom)
//
//throwable :
//      attachment flags - чтоб не проходили друг сквозь друга 3(через одного)579
//      ParentToHand во фгалах - дочерний объект к руке
//      Realise Velocity Style - инерция, Short~ плохая инерция Advanced~ качественная инерция
//
//UI:   Canvas - World Space (настроить scale = 0.001 ,width и heigth)
//      UI default а не TMPro
//      у button:   Normal Color - стандартный, Highlighted ~ - при подведении,...
//                  Должен быть колайдер, можно IsTrigger
//                  нужен UI Element - остальное стандартно
//                  если интерфейс далеко  - на какой то преваб руки (можно RightHand ) добавить Steam VR_Laser_Pointer
//                  надо открыть этот скрипт и править OnPointerIn ~Out ~Click ,лучше вывести в отдельный скрипт создав свой
//                  
//Перемещение объектов:  Linear Drive:  объект кидаем под пустышку, делаем два нивидимых дубликата - старт и конец (мин и макс поз),
//                                      добавляем LinearDrive.cs, ещё надо добавить LinearMapping.cs  и тут же кидаем всё что нужно
//                       Circular:  для правильного поворота дочерний можно сместить относительно родительского|| кидаем скрипт CircularDrive.cs ,
//                                  Axis of Rotation меняем на Y(2 строка) ,Limited - галочка ,задаём лимиты


