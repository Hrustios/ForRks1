//Window Analises Profiler

//Project Settings\Player\other settings - statis ~ , dynamic batching галочки
//всем статичным объектам справа сверху ставим static
//всем динамическим - в материале почти внизу галочку на Enable  GPU Instancing

//удаление лишных Rigidbody и фриз contraints , ещЄ можно collision detection (discrete - без быстрого - самый лучший,
//              пул€ проход€ща€ сквозь объекты - Continuous Dynamic,объекты в которые будет попадать пул€ - Continuous  - дорогие)
//у колайдеров использовать как можно более целые числа
//в project settings\physics layer mask - попробовать оставить только сама€ нижн€€ одна галочка, в первом р€ду 1,2 и последнее ~риск~
//в том же Physics - Auto Sync Transforms (false) , Reuse Collision Callbacks (true) ~риск~
//в mesh coliders  можно cooking options оставить только на Use Fast Midphase ~риск~

//можно window\rendering\occlusion culling -> bake!!! (то что вне камеры не отрисовываетс€, работает только со статик объектами)
//можно добавить все объекты в пустышки и у ненЄ сверху справа , правее "static" - галочки на всЄ

//~mesh combiner - объедин€ешь объекты под пустышку,на неЄ компонент mesh combiner, на нЄм 1,3 и 5 галочки->combine meshes~

//если модель с большим кол-вом полигонов - кидаем в блендер + модификатор decimate