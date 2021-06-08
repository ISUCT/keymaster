import React from 'react'
import {IWeather} from './WeatherList'

interface IProps {
    item: IWeather;
}

export default function WeatherItem(props: IProps) {
    return (
        <div style={{backgroundColor: "red"}}>
            <p>{props.item.summary}</p>
            <p>{props.item.temperatureC}</p>
        </div>
    )
}
