/* eslint-disable jsx-a11y/anchor-is-valid */
import React, { useState, useEffect } from 'react'
import './Home.scss'
import moment from 'moment';
import Delay from '../Delay/Delay';
import Card from './Card';
import Data from '../../Utils/Data';
export default function Home() {
    const [weatherArray, setWeatherArray] = useState('')
    const [isLoading, setIsLoading] = useState(true);
    const [selectedItem, setSelectedItem] = useState(0);
    const [open, setOpen] = useState(false)
    const [selectVal, setSelectVal] = useState("choose")

    const date = moment();
    const formated = date.format("dddd, D MMM YYYY")
    const handleItemClick = (index) => {
        setSelectedItem(index);
    };
    function valueSelect(value) {
        if (value !== undefined) {
            localStorage.setItem("sort", value)
            setSelectVal(value)
        }
        else {
            localStorage.setItem("sort", "")
            setSelectVal("choose")
        }
        setOpen(false)
    }
    useEffect(() => {
        

        let sorts = localStorage.getItem("sort")
        if (sorts != "") {
            setSelectVal(sorts)
        }
        else {
            setSelectVal("choose")
        }
        setIsLoading(false)
        const delay = 1000;
        <Delay />
        const redirectTimeout = setTimeout(() => {
            setIsLoading(true)
        }, delay);

        return () => {
            clearTimeout(redirectTimeout);
        };
    }, [])
    useEffect(() =>{
        Data.GetWeather()
        .then(response =>{
            setWeatherArray(response)
        })
    })
    const Header = (
        <div>
            <header>
                <div>
                    <h2>Ташкент</h2>
                    <div className='weather'>
                    <p >{formated}</p>
                    <div className='d-flex'><p>{Math.floor(weatherArray?.main?.temp - 273 ) + "°C"}</p> <p className='mx-3'>{weatherArray?.weather?.length > 0 && weatherArray?.weather?.map(iteam =>{
                        return(
                            <p>{iteam?.description}</p>
                        )
                    })}</p> </div>
              
                    </div>
                </div>
                <div>
                    <div className='search'>
                        <i className="bi bi-search"></i>
                        <input type="search" placeholder='Search for food, coffe, etc..' name="" id="" />
                    </div>
                </div>
            </header>
        </div>
    )
    const Categoriy = (
        <div>
            <div className='categoriy'>
                <div>
                    <p className={`categoriy-iteam ${selectedItem === 0 ? 'selected' : ''}`} onClick={() => handleItemClick(0)}>HotDefsdf</p>
                    <div className={`categoriy-iteam ${selectedItem === 0 ? 'selected-bottom' : ''}`}></div>
                </div>
                <div>
                    <p className={`categoriy-iteam ${selectedItem === 1 ? 'selected' : ''}`} onClick={() => handleItemClick(1)} >HotDefsdf</p>
                    <div className={`categoriy-iteam ${selectedItem === 1 ? 'selected-bottom' : ''}`}></div>
                </div>
                <div>
                    <p className={`categoriy-iteam ${selectedItem === 2 ? 'selected' : ''}`} onClick={() => handleItemClick(2)}>HotDefsdf</p>
                    <div className={`categoriy-iteam ${selectedItem === 2 ? 'selected-bottom' : ''}`}></div>
                </div>
                <div>
                    <p className={`categoriy-iteam ${selectedItem === 3 ? 'selected' : ''}`} onClick={() => handleItemClick(3)}>HotDefsdf</p>
                    <div className={`categoriy-iteam ${selectedItem === 3 ? 'selected-bottom' : ''}`}></div>
                </div>
                <div>
                    <p className={`categoriy-iteam ${selectedItem === 4 ? 'selected' : ''}`} onClick={() => handleItemClick(4)}>HotDefsdf</p>
                    <div className={`categoriy-iteam ${selectedItem === 4 ? 'selected-bottom' : ''}`}></div>
                </div>
                <div>
                    <p className={`categoriy-iteam ${selectedItem === 5 ? 'selected' : ''}`} onClick={() => handleItemClick(5)}>HotDefsdf</p>
                    <div className={`categoriy-iteam ${selectedItem === 5 ? 'selected-bottom' : ''}`}></div>
                </div>
            </div>
        </div>
    )

    const Select = (
        <div>
            <div className='select-row'>
                <div>
                    <h2>
                        Choose Dishes
                    </h2>
                </div>
                <div>
                    <div className='select' type="button" data-bs-toggle="dropdown" aria-expanded="false">
                        {open ? <i className="bi bi-arrow-up-short"></i> : <i className="bi bi-arrow-down-short"></i>} <div>{selectVal}</div>
                        <ul className={`${open ? "open-select" : ""} dropdown-menu select-iteam`}>
                            <li><a class="dropdown-item" href="#" onClick={() => valueSelect("Count")}>Count</a></li>
                            <li><a class="dropdown-item" href="#" onClick={() => valueSelect("Price")}>Price</a></li>
                            <li><a class="dropdown-item" href="#" onClick={() => valueSelect("Name")} >name</a></li>
                            <li><a class="dropdown-item" onClick={() => valueSelect()} >Delete</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    )
    return (
        <div>
            {!isLoading ? <Delay /> : <>
                <div className='home-page'>
                    <div className='container'>
                        {Header}
                        {Categoriy}
                        {Select}
                        <Card />
                    </div>
                </div>
            </>}

        </div>
    )
}
