# Lab 3: Introduction to Testing

## Функциональное тестирование сайта [Avatrade](https://www.avatrade.com/).

### <u>Тест-кейс 1</u>

| **Название** | **Описание** |
| -------- | -------- |
| **Номер**       | 1            |
| **Заголовок** | Создание сделки для покупки BTCUSD. |
| **Предусловие** | Открыта страница "[Торговля](https://webtrader6.avatrade.com/trade/-5/US_500)". Выполнена авторизация. На балансе достаточно средств для совершения сделки. |
| **Шаг** | **Ожидаемый результат** |
| Ввести в поле "Поиск актива", находящееся справа от бокового меню сайта, название актива: BTCUSD. | Снизу появился список активов, среди которых находится актив BTCUSD. |
| Нажать на требуемый актив. | С правой стороны страницы появилась область с названием актива в заголовке. |
| Ввести сумму актива в поле "Сумма BTCUSD". | В поле "Значение $" появилась сумма сделки. В поле "Маржа $" появилась сумма маржи. |
| Внизу области сделки нажать на кнопку "Купить" синего цвета. | Область сделки исчезла со страницы. На логотипе вкладки "Сделки" появился красный круг с цифрой 1 внутри. В верхней части страницы изменился баланс. |
| В меню, с левой стороны сайта, нажать на вкладку "Сделки". | Открылась страница "[Сделки](https://webtrader6.avatrade.com/positions/103257307)". На странице появился список активных сделок. Среди активных сделок появилась выполненная сделка с активом BTCUSD. |

### <u>Тест-кейс 2</u>

| **Название**                                                 | **Описание**                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| **Номер**                                                    | 2                                                            |
| **Заголовок**                                                | Создание сделки для продажи BTCUSD.                          |
| **Предусловие**                                              | Открыта страница "[Торговля](https://webtrader6.avatrade.com/trade/-5/US_500)". Выполнена авторизация. На балансе достаточно средств для совершения сделки. |
| **Шаг**                                                      | **Ожидаемый результат**                                      |
| Ввести в поле "Поиск актива", находящееся справа от бокового меню сайта, название актива: BTCUSD. | Снизу появился список активов, среди которых требуемый актив. |
| Нажать на требуемый актив.                                   | С правой стороны страницы появилась область сделки с названием BTCUSD в заголовке. |
| Нажать на, закругленную с правой стороны, синюю кнопку "Продать" под заголовком. | Область сделки перезагрузилась. Внизу появилась кнопка "Продать" вместо кнопки "Купить". |
| Ввести количество акций актива для покупки в поле "Сумма BTCUSD". | В поле "Значение $" появилась сумма сделки. В поле "Маржа $" появилась сумма маржи. |
| Внизу области сделки нажать на кнопку "Продать" синего цвета. | Область сделки исчезла со страницы. На логотипе вкладки "Сделки" появился красный круг с цифрой 1 внутри. В верхней части страницы изменился баланс. |
| В меню, с левой стороны сайта, нажать на вкладку "Сделки".   | Открылась страница "[Сделки](https://webtrader6.avatrade.com/positions/103257307)". На странице появился список активных сделок. Среди активных сделок появилась только что выполненная сделка по продаже BTCUSD. |

### <u>Тест-кейс 3</u>

| **Название**                                                 | **Описание**                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| **Номер**                                                    | 3                                                            |
| **Заголовок**                                                | Закрытие сделки BTCUSD.                                      |
| **Предусловие**                                              | Открыта страница "[Торговля](https://webtrader6.avatrade.com/trade/-5/US_500)". Выполнена авторизация. Выполнена хотя бы одна сделка. |
| **Шаг**                                                      | **Ожидаемый результат**                                      |
| В меню, с левой стороны сайта, нажать на вкладку "Сделки".   | Открыта страница "[Сделки](https://webtrader6.avatrade.com/positions/103257307)". На странице появился список активных сделок. |
| Выбрать сделку для закрытия, нажав на строку с названием актива BTCUSD. | Изменился цвет выбранной строки сделки на темно-синий.       |
| Нажать на иконку в виде крестика серого цвета в правой части выделенной строки сделки. | С правой стороны страницы появилась область с заголовком "Закрытие сделки". |
| Ввести объем/часть сделки для закрытия в поле "Сумма".       | В поле "Прибыль" появилось значение прибыли сделки.          |
| Внизу области закрытия сделки нажать на кнопку "Закрыть сделку" синего цвета . | Область закрытия сделки исчезла со страницы. Выбранная сделка исчезла со страницы. В верхней части страницы изменился баланс. |
| В меню, с левой стороны сайта, нажать на вкладку "История".  | Открылась страница "[История](https://webtrader6.avatrade.com/history)". На странице появился список всех закрытых сделок, среди которых, информация о только что закрытой сделке по продаже BTCUSD. |

### <u>Тест-кейс 4</u>

| **Название**                                                 | **Описание**                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| **Номер**                                                    | 4                                                            |
| **Заголовок**                                                | Создание ордера сделки для покупки BTCUSD.                   |
| **Предусловие**                                              | Открыта страница "[Торговля](https://webtrader6.avatrade.com/trade/-5/US_500)". Выполнена авторизация. На балансе достаточно средств для создания ордера сделки. |
| **Шаг**                                                      | **Ожидаемый результат**                                      |
| Ввести в поле "Поиск актива", находящееся справа от бокового меню сайта, название актива: BTCUSD. | Снизу появился список активов, среди которых находится требуемый актив. |
| Нажать на актив BTCUSD.                                      | С правой стороны страницы появилась область с названием BTCUSD в заголовке. |
| Ввести количество акций актива для покупки в поле "Сумма BTCUSD". | В поле "Значение $" появилась сумма сделки. В поле "Маржа $" появилась сумма маржи. |
| Под полем "Сумма BTCUSD" нажать на выпадающий список "Дополнительные параметры". | Снизу появился список с дополнительными параметрами.         |
| Нажать на чек-бокс с заголовком "Выполнить когда цена достигнет". | Появилось два поля: "Цена" и "Отменить к дате".              |
| В поле "Цена" ввести цену сделки.                            | Кнопка "Купить", в нижней части области сделки, стала синего цвета. |
| Внизу области сделки нажать на кнопку "Купить" синего цвета. | Область сделки исчезла со страницы. На логотипе вкладки "Ордера" появился красный круг с цифрой 1 внутри. |
| В меню, с левой стороны сайта, нажать на вкладку "Сделки".   | Открылась страница "[Ордера](https://webtrader6.avatrade.com/orders/103256072)". На странице появился список активных ордеров, среди которых находится только что созданный ордер для сделки BTCUSD. |

### <u>Тест-кейс 5</u>

| **Название**                                                 | **Описание**                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| **Номер**                                                    | 5                                                            |
| **Заголовок**                                                | Включение "стоп-лосс" для существующей сделки BTCUSD.        |
| **Предусловие**                                              | Открыта страница "[Торговля](https://webtrader6.avatrade.com/trade/-5/US_500)". Выполнена авторизация. Выполнена хотя бы одна сделка BTCUSD. |
| **Шаг**                                                      | **Ожидаемый результат**                                      |
| В меню, с левой стороны сайта, нажать на вкладку "Сделки".   | Открыта страница "[Сделки](https://webtrader6.avatrade.com/positions/103257307)". На странице показана информация о выполненных сделках и кнопки для их редактирования. |
| Выбрать сделку  для закрытия, нажав на строку со сделкой BTCUSD. | Изменился цвет выбранной строки сделки на темно-синий.       |
| В колонке "Стоп-лосс" нажать на кнопку "Включить" синего цвета. | С правой стороны страницы появилась область с заголовком "Изменить сделку". Внизу области появился активный чек-бокс с заголовком "Стоп-лосс". Под заголовком появилось два поля: "Цена" и "Возможн. убыток". |
| Ввести нужную цену в поле "Цена".                            | В поле "Возможн. убыток" появилась сумма возможного убытка при закрытии сделки. |
| В нижней части области для изменения сделки нажать на кнопку "Обновить" синего цвета. | Область изменения сделки исчезла со страницы. В колонке "Стоп-лосс", выделенной сделки, появилась цена. |

### <u>Тест-кейс 6</u>

| **Название**                                                 | **Описание**                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| **Номер**                                                    | 6                                                            |
| **Заголовок**                                                | Включение "Тейк-профит" для существующей сделки BTCUSD.      |
| **Предусловие**                                              | Открыта страница "[Торговля](https://webtrader6.avatrade.com/trade/-5/US_500)". Выполнена авторизация. Выполнена хотя бы одна сделка. |
| **Шаг**                                                      | **Ожидаемый результат**                                      |
| В меню, с левой стороны сайта, нажать на вкладку "Сделки".   | Открылась страница "[Сделки](https://webtrader6.avatrade.com/positions/103257307)". На странице появился список всех активных сделок. |
| Выбрать сделку для закрытия, нажав на строку со сделкой BTCUSD. | Изменился цвет выбранной строки сделки на темно-синий.       |
| В колонке "Стоп-лосс" нажать на кнопку "Включить" синего цвета. | С правой стороны страницы появилась область с заголовком "Изменить сделку". Внизу области появился активный чек-бокс с заголовком "Тейк-профит". Под заголовком появилось два поля: "Цена" и "Возможн. прибыль". |
| Ввести нужную цену в поле "Цена".                            | В поле "Возможн. прибыль" появилась сумма возможной прибыли при закрытии сделки. |
| В нижней части области для изменения сделки нажать на кнопку "Обновить" синего цвета. | Область изменения сделки исчезла со страницы. В колонке "Тейк-профит", выделенной сделки, появилась цена. |

### <u>Тест-кейс 7</u>

| **Название**                                                 | **Описание**                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| **Номер**                                                    | 7                                                            |
| **Заголовок**                                                | Отправка сообщений в "Онлайн-чат"                            |
| **Предусловие**                                              | Открыта страница "[Торговля](https://webtrader6.avatrade.com/trade/-5/US_500)". Выполнена авторизация. |
| **Шаг**                                                      | **Ожидаемый результат**                                      |
| В меню, с левой стороны сайта, нажать на вкладку "Онлайн-чат". | Справа от меню появилось всплывающее окно.                   |
| В всплывающем окне в поле "Введите сообщение" ввести требуемое сообщение. | Круглая кнопка в виде стрелки вверх, справа от поля ввода сообщения, стала синего цвета. |
| Нажать на кнопку отправки сообщения справа от поля ввода.    | В чате появилось отправленное сообщение.                     |

### <u>Тест-кейс 8</u>

| **Название**                                                 | **Описание**                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| **Номер**                                                    | 8                                                            |
| **Заголовок**                                                | Агрегирование списка сделок.                                 |
| **Предусловие**                                              | Открыта страница "[Торговля](https://webtrader6.avatrade.com/trade/-5/US_500)". Выполнена авторизация. Выполнена хотя бы одна сделка. |
| **Шаг**                                                      | **Ожидаемый результат**                                      |
| В меню, с левой стороны сайта, нажать на вкладку "Сделки".   | Открылась страница "[Сделки](https://webtrader6.avatrade.com/positions/103257307)". На странице появился список всех активных сделок. |
| В правом верхнем углу страницы нажать на чек-бокс с заголовком "Агрегировать". | На странице появилось несколько выпадающих списков с заголовками активов. |

### <u>Тест-кейс 9</u>

| **Название**                                                 | **Описание**                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| **Номер**                                                    | 9                                                            |
| **Заголовок**                                                | Установление линии тренда на графике рынка.                  |
| **Предусловие**                                              | Открыта страница "[Торговля](https://webtrader6.avatrade.com/trade/-5/US_500)". Выполнена авторизация. |
| **Шаг**                                                      | **Ожидаемый результат**                                      |
| В верхней части графика, расположенного внизу страницы, нажать на логотип в виде диагональной линии. | Появился выпадающий список.                                  |
| В появившемся выпадающем списке выбрать пункт "Линия тренда". | Выпадающий список исчез. Вместо стандартного указателя мыши пользователя появился указатель в виде черного круга. |
| Нажать на график в месте, где нужно установить линию тренда. | На графике появилась розовая линия.                          |
| Нажать второй раз на график, для фиксации линии тренда.      | Линия тренда зафиксировалась под определенным углом.         |

### <u>Тест-кейс 10</u>

| **Название**                                                 | **Описание**                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| **Номер**                                                    | 10                                                           |
| **Заголовок**                                                | Изменение вида графика на линию.                             |
| **Предусловие**                                              | Открыта страница "[Торговля](https://webtrader6.avatrade.com/trade/-5/US_500)". Выполнена авторизация. |
| **Шаг**                                                      | **Ожидаемый результат**                                      |
| В верхней части графика, расположенного внизу страницы, нажать на второй по счету слева логотип. | Появился выпадающий список.                                  |
| В появившемся выпадающем списке выбрать пункт "Линия".       | Выпадающий список исчез. Внешний вид графика стал в виде прямых линий. |

### <u>Тест-кейс 11</u>

| **Название**                                                 | **Описание**                                                 |
| ------------------------------------------------------------ | ------------------------------------------------------------ |
| **Номер**                                                    | 11                                                           |
| **Заголовок**                                                | Добавление аналитики на график                               |
| **Предусловие**                                              | Открыта страница "[Торговля](https://webtrader6.avatrade.com/trade/-5/US_500)". Выполнена авторизация. |
| **Шаг**                                                      | **Ожидаемый результат**                                      |
| В верхней части графика, расположенного внизу страницы, нажать на кнопку "Аналитика". | Появилось модальное окно с заголовком "Редактировать аналитику". |
| В модальном окне с левой стороны, в поле поиска ввести нужный тип аналитики. | Появился список искомых видов аналитики.                     |
| Выбрать нужный тип аналитики, нажав на него дважды.          | Справой стороны модального окна, в списке "Добавленная аналитика" появился выбранный тип аналитики. |
| В нижнем правом углу модального окна нажать на кнопку "Готово" синего цвета. | Модальное окно закрылось. На графике появились дополнительные линии аналитики. |

