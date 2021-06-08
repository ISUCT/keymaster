import React, { useEffect, useState } from "react";
import WeatherItem from "./WeatherItem";

export interface IWeather {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

const data: IWeather[] = [
  {
    date: "string",
    temperatureC: 1,
    temperatureF: 38,
    summary: "Some",
  },
  {
    date: "string1",
    temperatureC: 2,
    temperatureF: 38,
    summary: "Some",
  },
  {
    date: "string2",
    temperatureC: 3,
    temperatureF: 38,
    summary: "Some",
  },
];

export default function WeatherList() {
  const [weatherItems, setWeatherItems] = useState<IWeather[]>([]);

  
  useEffect(() => {

    const temp = async () => {
        const responce = await fetch('/api/WeatherForecast');
        const data = await responce.json() as IWeather[];
        console.log("Data received");
        setWeatherItems(data);
    }
    temp();

  }, []);
  
  console.log("Render");

  return (
    <>
      <div>Hello List</div>
      {weatherItems.map((item: IWeather) => {
        return <WeatherItem key={item.date+item.summary} item={item} />;
      })}
    </>
  );
}
