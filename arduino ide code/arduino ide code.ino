#include <DHT.h>

// === Пины подключения ===
#define DHTPIN 2         // Пин DHT датчика (Data)
#define DHTTYPE DHT11    // Тип датчика: DHT11 или DHT22
#define LDR_PIN A0       // Аналоговый пин для фоторезистора

// === Создаем объект DHT ===
DHT dht(DHTPIN, DHTTYPE);

void setup() {
  // === Инициализация последовательного порта ===
  Serial.begin(9600);

  // === Запуск датчика DHT ===
  dht.begin();

  // === Сообщение о запуске ===
  Serial.println("=== Сенсоры запущены ===");
  Serial.println("Температура | Влажность | Яркость");
}

void loop() {
  // === Чтение данных с DHT ===
  float humidity = dht.readHumidity();           // Влажность (%)
  float temperature = dht.readTemperature();     // Температура (°C)

  // === Чтение яркости с фоторезистора ===
  int light = analogRead(LDR_PIN);              // 0–1023

  // === Проверка на корректность показаний ===
  if (!isnan(humidity) && !isnan(temperature)) {
    // === Форматированный вывод в Serial Monitor ===
    Serial.print(temperature);
    Serial.print("°C\t");

    Serial.print(humidity);
    Serial.print("%\t");

    Serial.println(light);
  } else {
    Serial.println("Ошибка чтения с DHT!");
  }

  // === Задержка перед следующим замером ===
  delay(2000); // раз в 2 секунды
}
